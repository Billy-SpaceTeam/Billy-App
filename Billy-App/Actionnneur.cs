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
        public Actionnneur()
        {
            InitializeComponent();

            this.m_LblMoteurModele.Text = "Modèle : ";
            this.m_LblServoModele.Text = "Modèle : ";
            this.m_LblMoteurConstructeur.Text = "Constructeur : ";
            this.m_LblServoConstructeur.Text = "Constructeur : ";
        }

        private void m_TimerGraph_Tick(object sender, EventArgs e)
        {
            this.m_LblServo.Text = "Valeur : " + this.ServoMoteur;
            this.m_LblMoteur.Text = "Valeur : " + this.MoteurVitesse;

            x++;

            //Graph Moteur a reaction
            m_ChartMoteur.Series["Series1"].Points.AddXY(x, MoteurVitesse);//(X = secondes, Y = valeur)

            if (m_ChartMoteur.Series["Series1"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartMoteur.Series["Series1"].Points.RemoveAt(0);

                m_ChartMoteur.ChartAreas[0].AxisX.Minimum = x - 60;
                m_ChartMoteur.ChartAreas[0].AxisX.Maximum = x;
            }

            //Graph ServoMoteur
            m_ChartServo.Series["Series1"].Points.AddXY(x, ServoMoteur);//(X = secondes, Y = valeur)

            if (m_ChartServo.Series["Series1"].Points.Count > 60)//seulement les 60 dernières secondes
            {
                m_ChartServo.Series["Series1"].Points.RemoveAt(0);

                m_ChartServo.ChartAreas[0].AxisX.Minimum = x - 60;
                m_ChartServo.ChartAreas[0].AxisX.Maximum = x;
            }
        }

        private void m_BpExporterMoteur_Click(object sender, EventArgs e)
        {
            this.m_ChartMoteur.SaveImage(Properties.Settings.Default.CheminExp + "\\MoteurGraph.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
        }

        private void m_BpExporterServo_Click(object sender, EventArgs e)
        {
            this.m_ChartServo.SaveImage(Properties.Settings.Default.CheminExp + "\\ServoGraph.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
        }
    }
}
