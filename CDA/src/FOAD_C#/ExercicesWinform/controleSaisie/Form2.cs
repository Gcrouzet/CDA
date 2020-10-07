using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleSaisie
{
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
        }

        public Validation(string nom, string date, string montant, string cp)
        {
            InitializeComponent();
            InitializeComponent2(nom, date, montant, cp);
        }
        public void InitializeComponent2(string nom, string date, string montant, string cp)
        {
            this.label5.Text = nom;
            this.label6.Text = date;
            this.label7.Text = montant;
            this.label8.Text = cp;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FIN fin = new FIN();
            fin.Show();
        }
    }
}
