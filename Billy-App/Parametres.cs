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
    public partial class Parametres : UserControl
    {
        Form1 form;
        private bool themeSombre = false;
        public Parametres(Form1 parent)
        {
            InitializeComponent();
            this.form = parent;
        }

        private void m_BpThemes_Click(object sender, EventArgs e)
        {
            this.themeSombre = !this.themeSombre;
            if (this.themeSombre)
            {
                m_BpThemes.Text = "Thème Clair";
            }
            else
            {
                m_BpThemes.Text = "Thème Sombre";
            }
            form.AppliquerTheme(themeSombre);
        }
    }
}
