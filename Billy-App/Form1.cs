using System;
using System.Windows.Forms;

namespace Billy_App
{
    public partial class Form1 : Form
    {
        private Connexion connexion;
        private Données données;
        private Actions actions;
        private Modes modes;
        private Transfert transfert;

        public Form1()
        {
            InitializeComponent();

            connexion = new Connexion(this);
            données = new Données();
            actions = new Actions();
            modes = new Modes(this);
            transfert = new Transfert(this);

            this.m_ProgressBarConnexion.Value = 0;
            this.m_ProgressBarConnexion.Maximum = 100;

            m_TxtStatusConnection.Text = "Déconnecté";
            m_TxtStatusPort.Text = "Aucun port sélectionné";
            m_TxtStatusBauds.Text = "Aucun débit sélectionné";
            m_TxtStatusMode.Text = "Aucun mode sélectionné"; 
        }

        public bool ConnexionSerialPort(string portName, int baudRate)
        {
            bool ConnexionPort = false;
            try
            {
                m_TxtStatusPort.Text = portName;
                m_TxtStatusBauds.Text = baudRate.ToString();
                this.m_ProgressBarConnexion.Value = 30;


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
                this.m_ProgressBarConnexion.Value = 100;
            }
            return ConnexionPort;
        }

        public bool DeconnexionSerialPort()
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
                this.m_ProgressBarConnexion.Value = 0;
            }
            else
            {
                m_TxtStatusConnection.Text = "Echec de la déconnexion";
            }

            return deconnexion;
        }

        public bool ConnexionWifi(string ssid, string password)
        {
            return true;
        }

        public void SetMode(string mode)
        {
            m_TxtStatusMode.Text = mode;
        }

        public bool Transfert(string data)
        {
            if(m_SerialPort.IsOpen)
            {
                try
                {
                    m_SerialPort.WriteLine(data);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'envoi des données : " + ex.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Le port série n'est pas ouvert.");
                return  false;
            }
        }

        private void m_MenuConnection_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            connexion.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(connexion);
        }

        private void m_MenuDonnées_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            données.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(données);
        }

        private void m_MenuActions_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            actions.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(actions);
        }

        private void m_MenuModes_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            modes.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(modes);
        }

        private void m_MenuTransfert_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            transfert.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(transfert);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connexion.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(connexion);
        }
    }
}
