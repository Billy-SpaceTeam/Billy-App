using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Billy_App
{
    public partial class Actionnneur : UserControl
    {
        private bool ServoMoteur = true;
        private int Moteur_x = 1;
        private int Moteur_y = 2;
        private int Moteur_z = 3;
        private int x = 0;
        private bool Play = false;
        public Actionnneur()
        {
            InitializeComponent();

            this.m_LblMoteurModele.Text = "Modèle : non disponible";
            this.m_LblServoModele.Text = "Modèle : non disponible";
            this.m_LblMoteurConstructeur.Text = "Constructeur : non disponible";
            this.m_LblServoConstructeur.Text = "Constructeur : non disponible";

            //ServoMoteur
            this.m_ChartServo.Series.Add("ServoMoteur");
            this.m_ChartServo.Series["ServoMoteur"].ChartType = SeriesChartType.Line;
            this.m_ChartServo.Series["ServoMoteur"].Color = Color.Blue;
            this.m_ChartMoteur.ChartAreas[0].AxisX.Title = "Temps (s)";
            this.m_ChartServo.ChartAreas[0].AxisX.Title = "Temps (s)";
            this.m_ChartServo.ChartAreas[0].AxisY.Title = "Tension (V)";
            this.m_ChartMoteur.ChartAreas[0].AxisY.Title = "Tension (V)";

            //Moteur a reaction
            this.m_ChartMoteur.Series.Add("Moteur_x");
            this.m_ChartMoteur.Series["Moteur_x"].ChartType = SeriesChartType.Line;
            this.m_ChartMoteur.Series["Moteur_x"].Color = Color.Blue;

            this.m_ChartMoteur.Series.Add("Moteur_y");
            this.m_ChartMoteur.Series["Moteur_y"].ChartType = SeriesChartType.Line;
            this.m_ChartMoteur.Series["Moteur_y"].Color = Color.Green;

            this.m_ChartMoteur.Series.Add("Moteur_z");
            this.m_ChartMoteur.Series["Moteur_z"].ChartType = SeriesChartType.Line;
            this.m_ChartMoteur.Series["Moteur_z"].Color = Color.Red;
        }

        private void m_TimerGraph_Tick(object sender, EventArgs e)
        {
            this.m_LblServo.Text = "Valeur : " + this.ServoMoteur;
            this.m_LblMoteur_x.Text = "x : " + this.Moteur_x;
            this.m_LblMoteur_y.Text = "y : " + this.Moteur_y;
            this.m_LblMoteur_z.Text = "z : " + this.Moteur_z;

            x++;

            //Graph Moteur a reaction
            m_ChartMoteur.Series["Moteur_x"].Points.AddXY((x/10), Moteur_x);//(X = secondes, Y = valeur)
            m_ChartMoteur.Series["Moteur_y"].Points.AddXY((x/10), Moteur_y);//(X = secondes, Y = valeur)
            m_ChartMoteur.Series["Moteur_z"].Points.AddXY((x/10), Moteur_z);//(X = secondes, Y = valeur)

            if (m_ChartMoteur.Series["Moteur_x"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartMoteur.Series["Moteur_x"].Points.RemoveAt(0);

                m_ChartMoteur.ChartAreas[0].AxisX.Minimum = (x/10) - 6;
                m_ChartMoteur.ChartAreas[0].AxisX.Maximum = (x/10);
            }

            //Graph ServoMoteur
            m_ChartServo.Series["ServoMoteur"].Points.AddXY((x/10), ServoMoteur);//(X = secondes, Y = valeur)

            if (m_ChartServo.Series["ServoMoteur"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartServo.Series["ServoMoteur"].Points.RemoveAt(0);

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
                m_ChartMoteur.Series["Moteur_x"].Points.Clear();
                m_ChartMoteur.Series["Moteur_y"].Points.Clear();
                m_ChartMoteur.Series["Moteur_z"].Points.Clear();
                m_ChartServo.Series["ServoMoteur"].Points.Clear();
            }
            else
            {
                Play = true;
                this.m_BpActionneurPlay.Text = "Play";
                m_TimerGraph.Stop();
            }
        }

        private void m_CheckMoteur_x_CheckedChanged(object sender, EventArgs e)
        {
            if(this.m_CheckMoteur_x.Checked)
            {
                this.m_ChartMoteur.Series["Moteur_x"].Enabled = true;
            }
            else
            {
                this.m_ChartMoteur.Series["Moteur_x"].Enabled = false;
            }
        }

        private void m_CheckMoteur_y_CheckedChanged(object sender, EventArgs e)
        {
            if (this.m_CheckMoteur_y.Checked)
            {
                this.m_ChartMoteur.Series["Moteur_y"].Enabled = true;
            }
            else
            {
                this.m_ChartMoteur.Series["Moteur_y"].Enabled = false;
            }
        }

        private void m_CheckMoteur_z_CheckedChanged(object sender, EventArgs e)
        {
            if (this.m_CheckMoteur_z.Checked)
            {
                this.m_ChartMoteur.Series["Moteur_z"].Enabled = true;
            }
            else
            {
                this.m_ChartMoteur.Series["Moteur_z"].Enabled = false;
            }
        }
    }
}
