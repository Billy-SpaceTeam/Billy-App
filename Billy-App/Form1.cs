using System;
using System.Windows.Forms;

namespace Billy_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            m_TxtStatusConnection.Text = "Déconnecté";
            m_TxtStatusPort.Text = "Aucun port sélectionné";
            m_TxtStatusBauds.Text = "Aucun débit sélectionné";
        }

        public bool Connexion(string portName, int baudRate)
        {
            bool ConnexionPort = false;
            try
            {
                m_TxtStatusPort.Text = portName;
                m_TxtStatusBauds.Text = baudRate.ToString();


                m_SerialPort.PortName = portName;
                m_SerialPort.BaudRate = baudRate;
                m_SerialPort.Open();

                ConnexionPort = true;
            }
            catch (Exception ex)
            {
                m_TxtStatusConnection.Text = "Echec de la connexion";
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message);

                ConnexionPort = false;
            }
            if (!ConnexionPort)
            {
                m_TxtStatusConnection.Text = "Echec de la connexion";
            }
            else
            {
                m_TxtStatusPort.Text = portName;
                m_TxtStatusBauds.Text = baudRate.ToString();
                m_TxtStatusConnection.Text = "Connecté";
            }
            return ConnexionPort;
        }

        public bool Deconnexion()
        {
            bool deconnexion = false;
            try
            {
                m_SerialPort.Close();
                deconnexion = true;
            }
            catch (Exception ex)
            {
                m_TxtStatusConnection.Text = "Echec de la déconnexion";
                MessageBox.Show("Erreur lors de la déconnexion : " + ex.Message);
                deconnexion = false;
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

            return deconnexion;
        }

        private void m_MenuConnection_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            Connexion connection = new Connexion(this);
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

        private void m_MenuTransfert_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            Transfert transfert = new Transfert();
            transfert.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(transfert);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connexion connection = new Connexion(this);
            connection.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(connection);
        }
    }
}
