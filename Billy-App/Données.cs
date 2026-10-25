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
    public partial class Données : UserControl
    {
        public Données()
        {
            InitializeComponent();

            this.m_LblGyroModele.Text = "Modèle : SEN0142";
            this.m_LblPhotoConstructeur.Text = "Constructeur : DFROBOT";
            this.m_LblPhotoModele.Text = "Modèle : BPW34";
            this.m_LblPhotoConstructeur.Text = "Constructeur : Vishay Semiconductors";
        }
    }
}
