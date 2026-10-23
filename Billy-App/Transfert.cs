using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billy_App
{
    public partial class Transfert : UserControl
    {
        Form1 form;
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
                return;
            }
            else if(this.m_BoxTransfert.SelectedItem == "Fichier local" && this.m_LblImportFichier.Text == "Importer un fichier")
            {
                this.m_TxtBoxTransfert.AppendText(message + "Erreur de Transfert : Veuillez importer un fichier." + Environment.NewLine);
                return;
            }

            bool etat = form.Transfert("Test");
            if(etat)
            {
                this.m_TxtBoxTransfert.AppendText(message + "Transfert réussi" + Environment.NewLine);
            }
            else
            {
                this.m_TxtBoxTransfert.AppendText(message + "Transfert échoué" + Environment.NewLine);
            }
            */
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
                    string cheminFichier = openFileDialog.FileName;
                    this.m_LblImportFichier.Text = (cheminFichier);
                    //TraiterFichier(cheminFichier);
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
    }
}
