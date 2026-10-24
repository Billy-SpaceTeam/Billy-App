using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        //private string urlGithub = "https://github.com/Billy-SpaceTeam/Billy-CubeSat";
        public Transfert(Form1 parent)
        {
            InitializeComponent();
            form = parent;

            this.m_BoxTransfert.Text = "Type de transfert";
            this.m_BoxTransfert.Items.Add("Github");
            this.m_BoxTransfert.Items.Add("Fichier local");
        }

        private void m_BpTransfert_Click(object sender, EventArgs e)
        {
            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            string message = $"[{horodatage}]";
            this.m_TxtBoxTransfert.AppendText(message + "Début du transfert..." + Environment.NewLine);

            if(this.m_BoxTransfert.SelectedItem == null)
            {
                this.m_TxtBoxTransfert.AppendText(message + "Veuillez sélectionner un type de transfert." + Environment.NewLine);
                MessageBox.Show("Erreur de Transfert : Veuillez sélectionner un type de transfert");
                return;
            }
            else if(this.m_BoxTransfert.SelectedItem == "Fichier local" && this.m_LblImportFichier.Text == "Importer un fichier")
            {
                this.m_TxtBoxTransfert.AppendText(message + "Erreur de Transfert : Veuillez importer un fichier." + Environment.NewLine);
                MessageBox.Show("Erreur de Transfert : Veuillez importer un fichier");
                return;
            }

            bool etat = form.Transfert(cheminFichier);

            if(etat)
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
    }
}
