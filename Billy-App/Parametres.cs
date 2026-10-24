using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Billy_App
{
    public partial class Parametres : UserControl
    {
        Form1 form;
        private bool themeSombre = false;
        private string SiteProjet = "https://github.com/Billy-SpaceTeam";
        public Parametres(Form1 parent)
        {
            InitializeComponent();
            this.form = parent;

            this.m_TxtBoxRaccourciIp.Text = Properties.Settings.Default.Ip;
            this.m_TxtBoxRaccourciMdp.Text = Properties.Settings.Default.MotDePasse;
            this.m_TxtBoxStockTrans.Text = Properties.Settings.Default.CheminTransfert;
            this.m_TxtBoxStockDonnees.Text = Properties.Settings.Default.CheminDonnees;
            this.m_TxtBoxStockExp.Text = Properties.Settings.Default.CheminExp;
        }

        private void m_BpThemes_Click(object sender, EventArgs e)
        {
            form.ThemeSombre = !form.ThemeSombre;
            Properties.Settings.Default.ThemeSombre = form.ThemeSombre;
            Properties.Settings.Default.Save();

            if (form.ThemeSombre)
            {
                m_BpThemes.Text = "Thème Clair";
            }
            else
            {
                m_BpThemes.Text = "Thème Sombre";
            }
            form.AppliquerTheme();
        }

        private void m_TxtBoxRaccourciIp_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ip = m_TxtBoxRaccourciIp.Text;
            Properties.Settings.Default.Save();
        }

        private void m_TxtBoxRaccourciMdp_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MotDePasse = m_TxtBoxRaccourciMdp.Text;
            Properties.Settings.Default.Save();
        }

        private void m_TxtBoxStockTrans_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheminTransfert = m_TxtBoxStockTrans.Text;
            Properties.Settings.Default.Save();
        }

        private void m_TxtBoxStockDonnees_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheminDonnees = m_TxtBoxStockDonnees.Text;
            Properties.Settings.Default.Save();
        }

        private void m_TxtBoxStockExp_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheminExp = m_TxtBoxStockExp.Text;
            Properties.Settings.Default.Save();
        }

        private void m_BpLienGithub_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(SiteProjet);
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
    }
}
