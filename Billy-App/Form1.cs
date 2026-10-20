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
            m_TxtStatusPort.Text = "Aucun port sélectionné";
            m_TxtStatusBauds.Text = "Aucun débit sélectionné";
        }

        public bool Connexion(string portName, int baudRate)
        {
            bool connexion = false;
            try
            {
                m_SerialPort.PortName = portName;
                m_SerialPort.BaudRate = baudRate;
                m_SerialPort.Open();

                return true;
            }
            catch (Exception ex)
            {
                m_TxtStatusConnection.Text = "Echec de la connexion";
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message);
                return false;
            }
            if(connexion)
            {
                m_TxtStatusPort.Text = portName;
                m_TxtStatusBauds.Text = baudRate.ToString();
                m_TxtStatusConnection.Text = "Connecté";
            }
            else
            {
                m_TxtStatusConnection.Text = "Echec de la connexion";
            }
        }

        public bool Deconnexion()
        {
            bool deconnexion = false;
            try
            {
                m_SerialPort.Close();
                return true;
            }
            catch (Exception ex)
            {
                m_TxtStatusConnection.Text = "Echec de la déconnexion";
                MessageBox.Show("Erreur lors de la déconnexion : " + ex.Message);
                return false;
            }
            if (deconnexion)
            {
                m_TxtStatusPort.Text = "Aucun port sélectionné";
                m_TxtStatusBauds.Text = "Aucun débit sélectionné";
                m_TxtStatusConnection.Text = "Déconnecté";
            }
            else
            {
                m_TxtStatusConnection.Text = "Echec de la déconnexion";
            }
        }

        private void m_MenuConnection_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            Connexion connection = new Connexion();
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
            Connexion connection = new Connexion();
            connection.Dock = DockStyle.Fill;
            m_PanelMenu .Controls.Add(connection);
        }

        private void m_MenuTransfert_Click(object sender, EventArgs e)
        {
            Transfert transfert = new Transfert();
            transfert.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(transfert);
        }
    }
}
