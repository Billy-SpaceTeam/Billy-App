using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billy_App
{
    public partial class Transfert : UserControl
    {
        Form1 form;
        private string cheminFichier;
        //private string arguments = $"-c port=SWD mode=UR -w \"{cheminFichier}\" 0x08000000 -v -rst";
        //private string urlGithub = "https://github.com/Billy-SpaceTeam/Billy-CubeSat";
        public Transfert(Form1 parent)
        {
            InitializeComponent();
            form = parent;

            this.m_BoxTransfert.Text = "Type de transfert";
            this.m_BoxTransfert.Items.Add("Github");
            this.m_BoxTransfert.Items.Add("Fichier local");
        }

        private async void m_BpTransfert_Click(object sender, EventArgs e)
        {
            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            string message = $"[{horodatage}]";
            this.m_TxtBoxTransfert.AppendText(message + "Début du transfert..." + Environment.NewLine);

            if (this.m_BoxTransfert.SelectedItem == null)
            {
                this.m_TxtBoxTransfert.AppendText(message + "Veuillez sélectionner un type de transfert." + Environment.NewLine);
                MessageBox.Show("Erreur de Transfert : Veuillez sélectionner un type de transfert");
                return;
            }
            else if (this.m_BoxTransfert.SelectedItem == "Fichier local" && this.m_LblImportFichier.Text == "Importer un fichier")
            {
                this.m_TxtBoxTransfert.AppendText(message + "Erreur de Transfert : Veuillez importer un fichier." + Environment.NewLine);
                MessageBox.Show("Erreur de Transfert : Veuillez importer un fichier");
                return;
            }

            bool etat = await TransfertFichierSerial();

            if (etat)
            {
                this.m_TxtBoxTransfert.AppendText(message + "Transfert réussi" + Environment.NewLine);
            }
            else
            {
                this.m_TxtBoxTransfert.AppendText(message + "Transfert échoué" + Environment.NewLine);
            }

        }

        private void m_BpImportFichier_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Sélectionner un fichier";
                openFileDialog.InitialDirectory = Properties.Settings.Default.CheminTransfert; //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Tous les fichiers (*.*)|*.*|Fichiers texte (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    cheminFichier = openFileDialog.FileName;
                    this.m_LblImportFichier.Text = (cheminFichier);
                    TraiterFichier(cheminFichier);
                }
            }
        }

        private void m_PanelImportFichier_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void m_PanelImportFichier_DragDrop(object sender, DragEventArgs e)
        {
            // Récupère la liste des fichiers déposés
            string[] fichiers = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (fichiers != null && fichiers.Length > 0)
            {
                string cheminFichier = fichiers[0]; // Prend le premier fichier
                this.m_LblImportFichier.Text = (cheminFichier);
                TraiterFichier(cheminFichier);
            }
        }

        private void TraiterFichier(string chemin)
        {
            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            string message = $"[{horodatage}]";
            try
            {
                // Exemple : lire tout le contenu texte du fichier
                string contenu = System.IO.File.ReadAllText(chemin);
                MessageBox.Show($"Fichier chargé avec succès :\n{chemin}");
                this.m_TxtBoxTransfert.AppendText(message + "Ficher chargé avec succeès" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture du fichier : {ex.Message}");
                this.m_TxtBoxTransfert.AppendText(message + "Erreur : lecture du fichier" + Environment.NewLine);
            }
        }

        private async Task<bool> TransfertFichierSerial()
        {
            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            string message = $"[{horodatage}]";
            // 1. Vérification de l'existence du fichier
            if (!File.Exists(cheminFichier))
            {
                MessageBox.Show("Le fichier .bin est introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.m_TxtBoxTransfert.AppendText(message + "Fichier .bin introuvable" + Environment.NewLine);
                return false;
            }

            DriveInfo lecteurNucleo = null;

            // 2. Recherche automatique du lecteur virtuel de la carte Nucleo
            foreach (DriveInfo lecteur in DriveInfo.GetDrives())
            {
                if (lecteur.IsReady && lecteur.DriveType == DriveType.Removable)
                {
                    if (lecteur.VolumeLabel.StartsWith("NODE") || lecteur.VolumeLabel.StartsWith("NUCLEO"))
                    {
                        lecteurNucleo = lecteur;
                        break;
                    }
                }
            }

            if (lecteurNucleo == null)
            {
                this.m_TxtBoxTransfert.AppendText(message + "Aucune carte Nucleo détectée" + Environment.NewLine);
                MessageBox.Show("Aucune carte STM32 Nucleo détectée. Vérifiez le câble USB", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 3. Récupération et affichage des informations préalables
            FileInfo infoFichier = new FileInfo(cheminFichier);
            long tailleFichier = infoFichier.Length;
            string cheminDestination = Path.Combine(lecteurNucleo.RootDirectory.FullName, infoFichier.Name);

            this.m_TxtBoxTransfert.AppendText(message + $"--- Début du transfert ---{Environment.NewLine}");
            this.m_TxtBoxTransfert.AppendText(message + $"Fichier cible : {infoFichier.Name} ({tailleFichier} octets){Environment.NewLine}");
            this.m_TxtBoxTransfert.AppendText(message + $"Lecteur détecté : {lecteurNucleo.VolumeLabel} ({lecteurNucleo.Name}){Environment.NewLine}");

            // 4. Copie du fichier par flux (Stream) pour déclencher le flashage sans bloquer l'UI
            try
            {
                using (FileStream fluxSource = new FileStream(cheminFichier, FileMode.Open, FileAccess.Read))
                using (FileStream fluxDest = new FileStream(cheminDestination, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[8192]; // Buffer de 8 Ko
                    int octetsLus;
                    long octetsCopies = 0;
                    int dernierPourcentage = 0;

                    // Lecture et écriture asynchrone
                    while ((octetsLus = await fluxSource.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        await fluxDest.WriteAsync(buffer, 0, octetsLus);
                        octetsCopies += octetsLus;

                        // Calcul du pourcentage
                        int pourcentage = (int)((octetsCopies * 100) / tailleFichier);

                        // Pour ne pas inonder la TextBox, on affiche seulement tous les 10% (ou à 100%)
                        if (pourcentage >= dernierPourcentage + 10 || pourcentage == 100)
                        {
                            this.m_TxtBoxTransfert.AppendText(message + $"Avancement : {pourcentage}%{Environment.NewLine}");
                            dernierPourcentage = pourcentage;

                            // Si tu ajoutes une ProgressBar sur ton interface, tu peux la mettre à jour ici :
                            // this.m_ProgressBar.Value = pourcentage;
                        }
                    }
                }

                this.m_TxtBoxTransfert.AppendText(message + "Programme implanté avec succès ! Le microcontrôleur redémarre" + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                this.m_TxtBoxTransfert.AppendText(message + "Erreur lors du flashage : " + ex.Message + Environment.NewLine);
                MessageBox.Show($"Erreur lors du flashage : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
