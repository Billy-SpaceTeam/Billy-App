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
using System.Windows.Forms.VisualStyles;

namespace Billy_App
{
    public partial class Connexion : UserControl
    {
        Form1 form;
        public Connexion()
        {
            InitializeComponent();
            form = new Form1();

            this.m_BoxBauds.Items.Clear();
            this.m_BoxBauds.Items.Add("2400");
            this.m_BoxBauds.Items.Add("9600");
            this.m_BoxBauds.Items.Add("19200");
        }

        private void m_BpDetecter_Click(object sender, EventArgs e)
        {
            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            string message = $"[{horodatage}]";
            this.m_TxtBoxConnection.AppendText(message + "Détection des ports série..." + Environment.NewLine);

            string[] ports = SerialPort.GetPortNames();

            m_BoxPorts.Items.Add(string.Join(", ", ports));
            if(ports.Length == 0)
            {
                this.m_TxtBoxConnection.AppendText(message + "Aucun port série détecté." + Environment.NewLine);
            }
            else
            {
                this.m_TxtBoxConnection.AppendText(message + "Ports série détectés : " + string.Join(", ", ports) + Environment.NewLine);
            }
        }

        private void m_BpConnecter_Click(object sender, EventArgs e)
        {
            bool isConnected = false;

            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Connecting..." + Environment.NewLine);

            if(m_BoxPorts.SelectedItem == null)
            {
                m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Erreur lors de la connexion : Veuillez choisir un port série" + Environment.NewLine);
                MessageBox.Show("Erreur lors de la connexion : Aucun port série détecté");
                return;

            }
            else if(m_BoxBauds.SelectedItem == null)
            {
                m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Erreur lors de la connexion : Veuillez choisir un débit" + Environment.NewLine);
                MessageBox.Show("Erreur lors de la connexion : Aucun port bauds séléctionné");
                return;
            }
            isConnected = form.Connexion(m_BoxPorts.SelectedItem.ToString(), int.Parse(m_BoxBauds.SelectedItem.ToString()));

            
            if (isConnected)
            {
                m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Connecté au port série " + m_BoxPorts.SelectedItem.ToString() + " avec un débit de " + m_BoxBauds.SelectedItem.ToString() + "." + Environment.NewLine);
            }
            else
            {
                m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Echec de la connexion au port série " + m_BoxPorts.SelectedItem.ToString() + "." + Environment.NewLine);
                MessageBox.Show("Erreur lors de la connexion : Echec de la connexion");
            }
        }
    }   
}