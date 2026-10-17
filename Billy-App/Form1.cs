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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m_MenuConnection_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Dock = DockStyle.Fill;
            this.Controls.Add(connection);
        }

        private void m_MenuDonnées_Click(object sender, EventArgs e)
        {
            Données données = new Données();
            données.Dock = DockStyle.Fill;
            this.Controls.Add(données);
        }

        private void m_MenuActions_Click(object sender, EventArgs e)
        {
            Actions actions = new Actions();
            actions.Dock = DockStyle.Fill;
            this.Controls.Add(actions);
        }

        private void m_MenuModes_Click(object sender, EventArgs e)
        {
            Modes modes = new Modes();
            modes.Dock = DockStyle.Fill;
            this.Controls.Add(modes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Dock = DockStyle.Fill;
            this.Controls.Add(connection);
        }
    }
}
