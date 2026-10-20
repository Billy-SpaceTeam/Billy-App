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
        Form1 Form;
        public Connexion()
        {
            InitializeComponent();
            this.Form = new Form1();

            this.m_BoxBauds.Items.Clear();
            this.m_BoxBauds.Items.Add("2400");
            this.m_BoxBauds.Items.Add("9600");
            this.m_BoxBauds.Items.Add("19200");
        }

        private void m_BpDetecter_Click(object sender, EventArgs e)
        {
            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            string message = $"[{horodatage}] Détection des ports série...";
            this.m_TxtBoxConnection.AppendText(message + Environment.NewLine);

            string[] ports = SerialPort.GetPortNames();
            m_BoxPorts.Text = string.Join(", ", ports);
            m_TxtBoxConnection.AppendText("Detect " + string.Join(", ", ports) + Environment.NewLine);
        }

        private void m_BpConnecter_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            bool isConnected = false;

            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Connecting..." + Environment.NewLine);

            if (m_BoxPorts.SelectedItem == null || m_BoxBauds.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un port série et un débit en bauds.");
                return;
            }
            if (isConnected)
            {
                isConnected = form.Connexion(m_BoxPorts.SelectedItem.ToString(), int.Parse(m_BoxBauds.SelectedItem.ToString()));
            }
            
        }
    }   
}

/*
m_TxtHeures.Text = DateTime.Now.Hour.ToString();
m_TxtMinutes.Text = DateTime.Now.Minute.ToString();
m_TxtSecondes.Text = DateTime.Now.Second.ToString();

MessageBox.Show("Veuillez choisir un port série.");
*/