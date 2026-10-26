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
    public partial class Données : UserControl
    {
        private int x = 0;
        private int y_Photo = 1;
        private int y_Gyro = 1;
        private bool Play = false;
        public Données()
        {
            InitializeComponent();

            this.m_LblGyroModele.Text = "Modèle : SEN0142";
            this.m_LblGyroConstructeur.Text = "Constructeur : DFROBOT";
            this.m_LblPhotoModele.Text = "Modèle : BPW34";
            this.m_LblPhotoConstructeur.Text = "Constructeur : Vishay Semiconductors";

            this.m_ChartPhotodiode.Series.Add("Photodiode");
            this.m_ChartPhotodiode.Series["Photodiode"].ChartType = SeriesChartType.Line;
            this.m_ChartPhotodiode.Series["Photodiode"].Color = Color.Blue;
            this.m_ChartPhotodiode.ChartAreas[0].AxisX.Title = "Temps (s)";
            this.m_ChartGyroscope.ChartAreas[0].AxisX.Title = "Temps (s)";
            this.m_ChartGyroscope.ChartAreas[0].AxisY.Title = "Tension (V)";
            this.m_ChartPhotodiode.ChartAreas[0].AxisY.Title = "Tension (V)";
        }

        //données.m_TimerSecondes_Tick(int x);

        private void m_BpDonneesChartGyro_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_ChartGyroscope.SaveImage(Properties.Settings.Default.CheminExp + "\\GyroscopeGraph.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation du graphique du gyroscope : " + ex.Message + "Erreur");
            }
        }

        private void m_BpDonneesChartPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_ChartPhotodiode.SaveImage(Properties.Settings.Default.CheminExp + "\\PhotodiodeGraph.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation du graphique du photodiode : " + ex.Message + "Erreur");
            }
        }

        private void m_TimerGraph_Tick(object sender, EventArgs e)
        {
            this.m_LblGyro.Text = "Valeur : " + y_Gyro.ToString();
            this.m_LblPhoto.Text = "Valeur : " + y_Photo.ToString();
            x++;
            //Graph Gyroscope
            m_ChartGyroscope.Series["Series1"].Points.AddXY((x/10), y_Gyro);//(X = secondes, Y = valeur)

            if (m_ChartGyroscope.Series["Series1"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartGyroscope.Series["Series1"].Points.RemoveAt(0);

                m_ChartGyroscope.ChartAreas[0].AxisX.Minimum = (x/10) - 6;
                m_ChartGyroscope.ChartAreas[0].AxisX.Maximum = (x/10);
            }

            //Graph PhotoDiode
            m_ChartPhotodiode.Series["Series1"].Points.AddXY((x/10), y_Photo);//(X = secondes, Y = valeur)

            if (m_ChartPhotodiode.Series["Series1"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartPhotodiode.Series["Series1"].Points.RemoveAt(0);

                m_ChartPhotodiode.ChartAreas[0].AxisX.Minimum = (x/10) - 6;
                m_ChartPhotodiode.ChartAreas[0].AxisX.Maximum = (x/10);
            }
        }
        /*
        private double ObtenirNouvelleValeur()
        {
            // Lecture valeur capteur serial
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            if(Play)
            {
                Play = false;
                this.m_BpDonneesPlay.Text = "Pause";
                m_TimerGraph.Start();
                x = 0;
                m_ChartPhotodiode.Series["Series1"].Points.Clear();
                m_ChartGyroscope.Series["Series1"].Points.Clear();
            }
            else
            {
                Play = true;
                this.m_BpDonneesPlay.Text = "Play";
                m_TimerGraph.Stop();
            }
        }
    }
}
