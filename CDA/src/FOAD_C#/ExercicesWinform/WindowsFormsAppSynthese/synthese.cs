using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSynthese
{
    public partial class synthese : Form
    {
        public synthese()
        {
            InitializeComponent();
        }

        private void synthese_Load(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            listBox1.Items.Add("Mensuelle");
            listBox1.Items.Add("Bimestrielle");
            listBox1.Items.Add("Trimestrielle");
            listBox1.Items.Add("Semestrielle");
            listBox1.Items.Add("Annuelle");
        }

        private void synthese_Shown(object sender, EventArgs e)
        {
            textBoxNom.Focus();
            listBox1.SetSelected(0, true);
        }
    }
}
