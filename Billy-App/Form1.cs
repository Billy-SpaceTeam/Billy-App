using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Billy_App
{
    public partial class Form1 : Form
    {
        private Connexion connexion;
        private Données données;
        private Actions actions;
        private Modes modes;
        private Transfert transfert;
        private Parametres parametres;

        public Form1()
        {
            InitializeComponent();

            connexion = new Connexion(this);
            données = new Données();
            actions = new Actions();
            modes = new Modes(this);
            transfert = new Transfert(this);
            parametres = new Parametres(this);

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
                this.m_LblStatusPort.Text = "Port :";
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
            try
            {
                this.m_ProgressBarConnexion.Value = 30;
                this.m_LblStatusPort.Text = "IP :";
                this.m_TxtStatusPort.Text = ssid;
                //this.m_TxtStatusBauds.Text = password;
                //code de connexion wifi
                this.m_ProgressBarConnexion.Value = 100;
                this.m_TxtStatusConnection.Text = "Connecté";
                return true;
            }
            catch(Exception ex)
            {
                m_TxtStatusConnection.Text = "Echec de la connexion";
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message);
                return false;
            }
        }

        public bool DeconnexionWifi()
        {
            try
            {
                //code deconnexion wifi
                this.m_ProgressBarConnexion.Value = 0;
                this.m_TxtStatusConnection.Text = "Déconnecté";
                this.m_TxtStatusPort.Text = "Aucun port sélectionné";
                this.m_TxtStatusBauds.Text = "Aucun débit sélectionné";
                return true;
            }
            catch (Exception ex)
            {
                m_TxtStatusConnection.Text = "Echec de la déconnexion";
                MessageBox.Show("Erreur lors de la déconnexion : " + ex.Message);
                return false;
            }
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

        public void AppliquerTheme(bool sombre)
        {
            //Définition des couleurs selon le mode choisi
            Color couleurFond = sombre ? Color.FromArgb(32, 32, 32) : Color.FromKnownColor(KnownColor.Control);
            Color couleurTexte = sombre ? Color.White : Color.Black;
            Color couleurChamps = sombre ? Color.FromArgb(45, 45, 48) : Color.White;
            Color couleurBoutons = sombre ? Color.FromArgb(60, 60, 60) : Color.FromKnownColor(KnownColor.ControlLight);

            //Application au Form principal
            this.BackColor = couleurFond;
            this.ForeColor = couleurTexte;

            //Application récursive à tous les contrôles (incluant le UserControl)
            AppliquerCouleursRecursif(this.Controls, couleurFond, couleurTexte, couleurChamps, couleurBoutons);
        }


        private void AppliquerCouleursRecursif(Control.ControlCollection controles, Color fond, Color texte, Color champs, Color boutons)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = boutons;
                    ctrl.ForeColor = texte;
                }
                else if (ctrl is TextBox || ctrl is ComboBox || ctrl is ListBox)
                {
                    ctrl.BackColor = champs;
                    ctrl.ForeColor = texte;
                }
                else if (ctrl is Panel || ctrl is GroupBox || ctrl is UserControl)
                {
                    ctrl.BackColor = fond;
                    ctrl.ForeColor = texte;

                    // Relance la recherche sur les contrôles situés à l'intérieur du UserControl ou Panel
                    if (ctrl.HasChildren)
                    {
                        AppliquerCouleursRecursif(ctrl.Controls, fond, texte, champs, boutons);
                    }
                }
                else
                {
                    ctrl.BackColor = fond;
                    ctrl.ForeColor = texte;
                }
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

        private void m_MenuParametre_Click(object sender, EventArgs e)
        {
            m_PanelMenu.Controls.Clear();
            parametres.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(parametres);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connexion.Dock = DockStyle.Fill;
            m_PanelMenu.Controls.Add(connexion);

            bool themeSombre = false;
            themeSombre = Properties.Settings.Default.ThemeSombre;
            AppliquerTheme(themeSombre);
        }
    }
}
