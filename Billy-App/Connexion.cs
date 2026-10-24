using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Sockets.TcpClient;

namespace Billy_App
{
    public partial class Connexion : UserControl
    {
        Form1 form;
        TcpClient tcpclient;

        private bool isConnectedSerialPort = false;
        private bool isConnectedWifi = false;
        //private Int32 PortWifi = 8080;
        public Connexion(Form1 parent)
        {
            InitializeComponent();

            form = parent;
            tcpclient = new TcpClient();

            this.m_BoxPorts.Text = "Port COM";
            this.m_BoxBauds.Text = "Débit";
            //this.m_TxtBoxConnecterIp.
            //this.m_TxtBoxConnecterMdp.Text = "Mot de passe";

            this.m_BoxBauds.Items.Add("2400");
            this.m_BoxBauds.Items.Add("9600");
            this.m_BoxBauds.Items.Add("19200");

            this.m_TxtBoxConnecterIp.Text = Properties.Settings.Default.Ip;
            this.m_TxtBoxConnecterMdp.Text = Properties.Settings.Default.MotDePasse;
        }

        private void m_BpDetecter_Click(object sender, EventArgs e)
        {
            this.m_BoxPorts.Items.Clear();
            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            string message = $"[{horodatage}]";
            this.m_TxtBoxConnection.AppendText(message + "Détection des ports série..." + Environment.NewLine);

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                m_BoxPorts.Items.Add(port);
            }

            if (ports.Length == 0)
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
            if (!isConnectedSerialPort)
            {
                string horodatage = DateTime.Now.ToString("HH:mm:ss");
                m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Connecting..." + Environment.NewLine);

                if (m_BoxPorts.SelectedItem == null)
                {
                    m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Erreur lors de la connexion : Veuillez choisir un port série" + Environment.NewLine);
                    MessageBox.Show("Erreur lors de la connexion : Aucun port série détecté");
                    return;

                }
                else if (m_BoxBauds.SelectedItem == null)
                {
                    m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Erreur lors de la connexion : Veuillez choisir un débit" + Environment.NewLine);
                    MessageBox.Show("Erreur lors de la connexion : Aucun port bauds séléctionné");
                    return;
                }

                isConnectedSerialPort = form.ConnexionSerialPort(m_BoxPorts.SelectedItem.ToString(), int.Parse(m_BoxBauds.SelectedItem.ToString()));

                if (isConnectedSerialPort)
                {
                    m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Connecté au port série " + m_BoxPorts.SelectedItem.ToString() + " avec un débit de " + m_BoxBauds.SelectedItem.ToString() + "." + Environment.NewLine);
                    m_BpConnecterSerialPort.Text = "Déconnecter";
                }
                else
                {
                    m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Echec de la connexion au port série " + m_BoxPorts.SelectedItem.ToString() + "." + Environment.NewLine);
                    MessageBox.Show("Erreur lors de la connexion : Echec de la connexion");
                }
            }
            else
            {
                string horodatage = DateTime.Now.ToString("HH:mm:ss");

                bool deconnexion = form.DeconnexionSerialPort();
                if (deconnexion)
                {
                    isConnectedSerialPort = false;
                    m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Déconnecté du port série" + Environment.NewLine);
                    m_BpConnecterSerialPort.Text = "Connecter";
                }
                else
                {
                    m_TxtBoxConnection.AppendText("[" + horodatage + "] " + "Echec de la déconnexion du port série" + Environment.NewLine);
                }
            }

        }

        private void m_BpDetecterWifi_Click(object sender, EventArgs e)
        {
            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            string message = $"[{horodatage}]";
            this.m_TxtBoxConnection.AppendText(message + "Recherche des appareils Wi-Fi..." + Environment.NewLine);

           
        }

        private void m_BpConnecterWifi_Click(object sender, EventArgs e)
        {
            string horodatage = DateTime.Now.ToString("HH:mm:ss");
            string message = $"[{horodatage}]";
            if (!isConnectedWifi)
            {
                this.m_TxtBoxConnection.AppendText(message + "Début de la connexion Wi-Fi..." + Environment.NewLine);

                if (this.m_TxtBoxConnecterIp.Text == "")
                {
                    this.m_TxtBoxConnection.AppendText(message + "Erreur : Adresse IP non renseignée" + Environment.NewLine);
                    MessageBox.Show("Erreur lors de la connexion : Adresse IP non renseignée");
                    return;
                }
                else if (this.m_TxtBoxConnecterMdp.Text == "")
                {
                    this.m_TxtBoxConnection.AppendText(message + "Erreur : Mot de passe non renseigné" + Environment.NewLine);
                    MessageBox.Show("Erreur lors de la connexion : Mot de passe non renseigné");
                    return;
                }

                bool connexion = form.ConnexionWifi(this.m_TxtBoxConnecterIp.Text, this.m_TxtBoxConnecterMdp.Text);

                if (connexion)
                {
                    this.m_TxtBoxConnection.AppendText(message + "Connexion Wi-Fi réussie" + Environment.NewLine);
                    this.isConnectedWifi = true;
                    this.m_BpConnecterWifi.Text = "Déconnecter";
                }
                else
                {
                    this.m_TxtBoxConnection.AppendText(message + "Connexion Wi-Fi échouée" + Environment.NewLine);
                }
            }
            else
            {
                this.m_TxtBoxConnection.AppendText(message + "Déconnection du Wifi..." + Environment.NewLine);
                bool connexion = form.DeconnexionWifi();
                if(connexion)
                {
                    this.m_TxtBoxConnection.AppendText(message + "Déconnexion Wi-Fi réussie" + Environment.NewLine);
                    this.m_BpConnecterWifi.Text = "Se Connecter";
                    this.isConnectedWifi = false;
                }
                else
                {
                    this.m_TxtBoxConnection.AppendText(message + "Déconnexion Wi-Fi échouée" + Environment.NewLine);
                }
            }
        }
    }   
}
