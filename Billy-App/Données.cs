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
        private int Photodiode = 1;
        private int x_Gyro = 1;
        private int y_Gyro = 2;
        private int z_Gyro = 3;
        private int x_Accel = 1;
        private int y_Accel = 2;
        private int z_Accel = 3;
        private bool Play = false;
        private readonly string SiteGyro = "https://www.farnell.com/datasheets/4376716.pdf?_gl=1*3s1c18*_gcl_au*NjMyNTc4NzM1LjE3OTMxOTE0ODc.";
        private readonly string SitePhotoDiode = "https://www.vishay.com/docs/81521/bpw34.pdf";
        public Données()
        {
            InitializeComponent();

            this.m_LblGyroModele.Text = "Modèle : SEN0142";
            this.m_LblGyroConstructeur.Text = "Constructeur : DFROBOT";
            this.m_LblPhotoModele.Text = "Modèle : BPW34";
            this.m_LblPhotoConstructeur.Text = "Constructeur : Vishay Semiconductors";

            //Photodiode
            this.m_ChartPhotodiode.Series.Add("Photodiode");
            this.m_ChartPhotodiode.Series["Photodiode"].ChartType = SeriesChartType.Line;
            this.m_ChartPhotodiode.Series["Photodiode"].Color = Color.Blue;
            this.m_ChartPhotodiode.ChartAreas[0].AxisX.Title = "Temps (s)";
            this.m_ChartPhotodiode.ChartAreas[0].AxisY.Title = "Tension (V)";

            //Gyroscope
            this.m_ChartGyroscope.Series.Add("Gyroscope_x");
            this.m_ChartGyroscope.Series["Gyroscope_x"].ChartType = SeriesChartType.Line;
            this.m_ChartGyroscope.Series["Gyroscope_x"].Color = Color.Blue;

            this.m_ChartGyroscope.Series.Add("Gyroscope_y");
            this.m_ChartGyroscope.Series["Gyroscope_y"].ChartType = SeriesChartType.Line;
            this.m_ChartGyroscope.Series["Gyroscope_y"].Color = Color.Green;

            this.m_ChartGyroscope.Series.Add("Gyroscope_z");
            this.m_ChartGyroscope.Series["Gyroscope_z"].ChartType = SeriesChartType.Line;
            this.m_ChartGyroscope.Series["Gyroscope_z"].Color = Color.Red;

            //Accelerometre
            this.m_ChartGyroscope.Series.Add("Accelerometre_x");
            this.m_ChartGyroscope.Series["Accelerometre_x"].ChartType = SeriesChartType.Line;
            this.m_ChartGyroscope.Series["Accelerometre_x"].Color = Color.Blue;

            this.m_ChartGyroscope.Series.Add("Accelerometre_y");
            this.m_ChartGyroscope.Series["Accelerometre_y"].ChartType = SeriesChartType.Line;
            this.m_ChartGyroscope.Series["Accelerometre_y"].Color = Color.Green;

            this.m_ChartGyroscope.Series.Add("Accelerometre_z");
            this.m_ChartGyroscope.Series["Accelerometre_z"].ChartType = SeriesChartType.Line;
            this.m_ChartGyroscope.Series["Accelerometre_z"].Color = Color.Red;

            this.m_ChartGyroscope.ChartAreas[0].AxisX.Title = "Temps (s)";
            this.m_ChartGyroscope.ChartAreas[0].AxisY.Title = "Tension (V)";
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
            //Gyro
            this.m_LblGyro_x.Text = "x : " + x_Gyro.ToString();
            this.m_LblGyro_y.Text = "y : " + y_Gyro.ToString();
            this.m_LblGyro_z.Text = "z : " + z_Gyro.ToString();
            //Accel
            this.m_LblAccel_x.Text = "x : " + x_Accel.ToString();
            this.m_LblAccel_y.Text = "y : " + y_Accel.ToString();
            this.m_LblAccel_z.Text = "z : " + z_Accel.ToString();

            this.m_LblPhoto.Text = "Valeur : " + Photodiode.ToString();
            x++;
            //Graph Gyroscope
            m_ChartGyroscope.Series["Gyroscope_x"].Points.AddXY((x/10), x_Gyro);//(X = secondes, Y = valeur)
            m_ChartGyroscope.Series["Gyroscope_y"].Points.AddXY((x / 10), y_Gyro);
            m_ChartGyroscope.Series["Gyroscope_z"].Points.AddXY((x / 10), z_Gyro);
            //Graph Accelerometer
            m_ChartGyroscope.Series["Accelerometre_x"].Points.AddXY((x / 10), x_Accel);
            m_ChartGyroscope.Series["Accelerometre_y"].Points.AddXY((x / 10), y_Accel);
            m_ChartGyroscope.Series["Accelerometre_z"].Points.AddXY((x / 10), z_Accel);

            if (m_ChartGyroscope.Series["Gyroscope_x"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartGyroscope.Series["Gyroscope_x"].Points.RemoveAt(0);

                m_ChartGyroscope.ChartAreas[0].AxisX.Minimum = (x/10) - 6;
                m_ChartGyroscope.ChartAreas[0].AxisX.Maximum = (x/10);
            }

            //Graph PhotoDiode
            m_ChartPhotodiode.Series["Photodiode"].Points.AddXY((x/10), Photodiode);//(X = secondes, Y = valeur)

            if (m_ChartPhotodiode.Series["Photodiode"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartPhotodiode.Series["Photodiode"].Points.RemoveAt(0);

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

        private void m_BpPlay_Click(object sender, EventArgs e)
        {
            if(Play)
            {
                Play = false;
                this.m_BpDonneesPlay.Text = "Pause";
                m_TimerGraph.Start();
                x = 0;
                m_ChartPhotodiode.Series["Photodiode"].Points.Clear();

                m_ChartGyroscope.Series["Gyroscope_x"].Points.Clear();
                m_ChartGyroscope.Series["Gyroscope_y"].Points.Clear();
                m_ChartGyroscope.Series["Gyroscope_z"].Points.Clear();
            }
            else
            {
                Play = true;
                this.m_BpDonneesPlay.Text = "Play";
                m_TimerGraph.Stop();
            }
        }

        private void m_LblGyroModele_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(SiteGyro);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void m_LblPhotoModele_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(SitePhotoDiode);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void m_CheckGyro_x_CheckedChanged(object sender, EventArgs e)
        {
            if (this.m_CheckGyro_x.Checked)
            {
                this.m_ChartGyroscope.Series["Gyroscope_x"].Enabled = true;
            }
            else
            {
                this.m_ChartGyroscope.Series["Gyroscope_x"].Enabled = false;
            }
        }

        private void m_CheckGyro_y_CheckedChanged(object sender, EventArgs e)
        {
            if (this.m_CheckGyro_y.Checked)
            {
                this.m_ChartGyroscope.Series["Gyroscope_y"].Enabled = true;
            }
            else
            {
                this.m_ChartGyroscope.Series["Gyroscope_y"].Enabled = false;
            }
        }

        private void m_CheckGyro_z_CheckedChanged(object sender, EventArgs e)
        {
            if (this.m_CheckGyro_z.Checked)
            {
                this.m_ChartGyroscope.Series["Gyroscope_z"].Enabled = true;
            }
            else
            {
                this.m_ChartGyroscope.Series["Gyroscope_z"].Enabled = false;
            }
        }

        private void m_CheckAcc_x_CheckedChanged(object sender, EventArgs e)
        {
            if (this.m_CheckAcc_x.Checked)
            {
                this.m_ChartGyroscope.Series["Accelerometre_x"].Enabled = true;
            }
            else
            {
                this.m_ChartGyroscope.Series["Accelerometre_x"].Enabled = false;
            }
        }

        private void m_CheckAcc_y_CheckedChanged(object sender, EventArgs e)
        {
            if (this.m_CheckAcc_y.Checked)
            {
                this.m_ChartGyroscope.Series["Accelerometre_y"].Enabled = true;
            }
            else
            {
                this.m_ChartGyroscope.Series["Accelerometre_y"].Enabled = false;
            }
        }

        private void m_CheckAcc_z_CheckedChanged(object sender, EventArgs e)
        {
            if (this.m_CheckAcc_z.Checked)
            {
                this.m_ChartGyroscope.Series["Accelerometre_z"].Enabled = true;
            }
            else
            {
                this.m_ChartGyroscope.Series["Accelerometre_z"].Enabled = false;
            }
        }
    }
}
