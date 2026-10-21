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
        public Modes()
        {
            InitializeComponent();

            m_BoxModes.Items.Add("Manuel");
            m_BoxModes.Items.Add("Semi-Auto");
            m_BoxModes.Items.Add("Automatique");
        }

        private void m_BoxModes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
