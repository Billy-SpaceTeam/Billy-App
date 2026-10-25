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
        private int x_Photo;
        private int Y_Photo = 0;
        public Données()
        {
            InitializeComponent();

            this.m_LblGyroModele.Text = "Modèle : SEN0142";
            this.m_LblGyroConstructeur.Text = "Constructeur : DFROBOT";
            this.m_LblPhotoModele.Text = "Modèle : BPW34";
            this.m_LblPhotoConstructeur.Text = "Constructeur : Vishay Semiconductors";

            // Data arrays - Graph 1
            string[] seriesArray = { "Cats", "Dogs" };
            int[] pointsArray = { 1, 2 };
            // Set palette.
            this.m_ChartGyroscope.Palette = ChartColorPalette.SeaGreen;
            // Set title.
            this.m_ChartGyroscope.Titles.Add("Pets");
            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.m_ChartGyroscope.Series.Add(seriesArray[i]);
                // Add point.
                series.Points.Add(pointsArray[i]);
            }
        }

        private void m_ChartPhotodiode_Load(object sender, EventArgs e)
        {
            this.m_ChartPhotodiode.Series.Add("Photodiode");
            this.m_ChartPhotodiode.Series["Photodiode"].ChartType = SeriesChartType.Line;
            this.m_ChartPhotodiode.Series["Photodiode"].Color = Color.Blue;
            this.m_ChartPhotodiode.ChartAreas[0].AxisX.Title = "Temps (s)";
            this.m_ChartPhotodiode.ChartAreas[0].AxisY.Title = "Tension (V)";
        }

        //données.m_TimerSecondes_Tick(int x);

        private void m_BpDonneesChartGyro_Click(object sender, EventArgs e)
        {
            m_ChartGyroscope.SaveImage(Properties.Settings.Default.CheminExp + "\\GyroscopeGraph.png", ChartImageFormat.Png);
        }

        private void m_BpDonneesChartPhoto_Click(object sender, EventArgs e)
        {
            m_ChartPhotodiode.SaveImage(Properties.Settings.Default.CheminExp + "\\PhotodiodeGraph.png", ChartImageFormat.Png);
        }

        private void m_TimerGraph_Tick(object sender, EventArgs e)
        {
            x_Photo++;
            double nouvelleValeur = ObtenirNouvelleValeur();
            m_ChartPhotodiode.Series["Series1"].Points.AddXY(x_Photo, nouvelleValeur);//(X = secondes, Y = valeur)

            if (m_ChartPhotodiode.Series["Series1"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartPhotodiode.Series["Series1"].Points.RemoveAt(0);

                m_ChartPhotodiode.ChartAreas[0].AxisX.Minimum = x_Photo - 60;
                m_ChartPhotodiode.ChartAreas[0].AxisX.Maximum = x_Photo;
            }
        }

        private double ObtenirNouvelleValeur()
        {
            // Lecture valeur capteur serial
            return 0;
        }

        public void DemarrerTrace()
        {
            x_Photo = 0; // Réinitialiser l'incrément si nécessaire
            m_ChartPhotodiode.Series["Series1"].Points.Clear();
            m_TimerGraph.Start();
        }

        public void ArreterTrace()
        {
            m_TimerGraph.Stop();
        }
    }
}
