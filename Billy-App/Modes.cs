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
    public partial class Modes : UserControl
    {
        Form1 form;
        public Modes(Form1 parent)
        {
            InitializeComponent();
            form = parent;

            m_BoxModes.Items.Add("Manuel");
            m_BoxModes.Items.Add("Semi-Auto");
            m_BoxModes.Items.Add("Automatique");

            //m_BoxModes.Items = "Manuel";
        }

        private void m_BoxModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            form.SetMode(m_BoxModes.SelectedItem.ToString());
        }
    }
}
