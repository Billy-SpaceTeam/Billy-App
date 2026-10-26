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
    public partial class Actionnneur : UserControl
    {
        private bool ServoMoteur = false;
        private int MoteurVitesse = 0;
        private int x = 0;
        private bool Play = false;
        public Actionnneur()
        {
            InitializeComponent();

            this.m_LblMoteurModele.Text = "Modèle : ";
            this.m_LblServoModele.Text = "Modèle : ";
            this.m_LblMoteurConstructeur.Text = "Constructeur : ";
            this.m_LblServoConstructeur.Text = "Constructeur : ";

            this.m_ChartMoteur.ChartAreas[0].AxisX.Title = "Temps (s)";
            this.m_ChartServo.ChartAreas[0].AxisX.Title = "Temps (s)";
            this.m_ChartServo.ChartAreas[0].AxisY.Title = "Tension (V)";
            this.m_ChartMoteur.ChartAreas[0].AxisY.Title = "Tension (V)";
        }

        private void m_TimerGraph_Tick(object sender, EventArgs e)
        {
            this.m_LblServo.Text = "Valeur : " + this.ServoMoteur;
            this.m_LblMoteur.Text = "Valeur : " + this.MoteurVitesse;

            x++;

            //Graph Moteur a reaction
            m_ChartMoteur.Series["Series1"].Points.AddXY((x/10), MoteurVitesse);//(X = secondes, Y = valeur)

            if (m_ChartMoteur.Series["Series1"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartMoteur.Series["Series1"].Points.RemoveAt(0);

                m_ChartMoteur.ChartAreas[0].AxisX.Minimum = (x/10) - 6;
                m_ChartMoteur.ChartAreas[0].AxisX.Maximum = (x/10);
            }

            //Graph ServoMoteur
            m_ChartServo.Series["Series1"].Points.AddXY((x/10), ServoMoteur);//(X = secondes, Y = valeur)

            if (m_ChartServo.Series["Series1"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartServo.Series["Series1"].Points.RemoveAt(0);

                m_ChartServo.ChartAreas[0].AxisX.Minimum = (x/10) - 6;
                m_ChartServo.ChartAreas[0].AxisX.Maximum = (x/10);
            }
        }

        private void m_BpExporterMoteur_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_ChartMoteur.SaveImage(Properties.Settings.Default.CheminExp + "\\MoteurGraph.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation du graphique du moteur : " + ex.Message + "Erreur");
            }
        }

        private void m_BpExporterServo_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_ChartServo.SaveImage(Properties.Settings.Default.CheminExp + "\\ServoGraph.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation du graphique du servo : " + ex.Message + "Erreur");
            }
        }

        private void m_BpActionneurPlay_Click(object sender, EventArgs e)
        {
            if (Play)
            {
                Play = false;
                this.m_BpActionneurPlay.Text = "Pause";
                m_TimerGraph.Start();
                x = 0;
                m_ChartMoteur.Series["Series1"].Points.Clear();
                m_ChartServo.Series["Series1"].Points.Clear();
            }
            else
            {
                Play = true;
                this.m_BpActionneurPlay.Text = "Play";
                m_TimerGraph.Stop();
            }
        }
    }
}
