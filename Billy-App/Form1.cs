using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billy_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            m_TxtStatusConnection.Text = "Attente";
        }

        public bool Connexion(string portName, int baudRate)
        {
            try
            {
                m_SerialPort.PortName = portName;
                m_SerialPort.BaudRate = baudRate;
                m_SerialPort.Open();
                m_TxtStatusConnection.Text = $"Connecté au port {portName} à {baudRate} bauds.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message);
                return false;
            }
        }

        private void m_MenuConnection_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            Connection connection = new Connection();
            connection.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(connection);
        }

        private void m_MenuDonnées_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            Données données = new Données();
            données.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(données);
        }

        private void m_MenuActions_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            Actions actions = new Actions();
            actions.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(actions);
        }

        private void m_MenuModes_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            Modes modes = new Modes();
            modes.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(modes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Dock = DockStyle.Fill;
            m_PanelMenu .Controls.Add(connection);
        }
    }
}
