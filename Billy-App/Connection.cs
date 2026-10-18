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
    public partial class Connection : UserControl
    {
        Form1 Form;
        public Connection()
        {
            InitializeComponent();
            this.Form = new Form1();
        }

        private void m_BpDetecter_Click(object sender, EventArgs e)
        {
            m_TxtBoxConnection.Text = "Detecting..."; 
            string[] ports = SerialPort.GetPortNames();
            m_BoxPorts.Text = string.Join(", ", ports);
            m_TxtBoxConnection.Text = "Detect " + string.Join(", ", ports);
        }

        private void m_BpConnecter_Click(object sender, EventArgs e)
        {
            m_TxtBoxConnection.Text = "Connecting...";
        }
    }   
}

/*
m_TxtHeures.Text = DateTime.Now.Hour.ToString();
m_TxtMinutes.Text = DateTime.Now.Minute.ToString();
m_TxtSecondes.Text = DateTime.Now.Second.ToString();

MessageBox.Show("Veuillez choisir un port série.");
*/