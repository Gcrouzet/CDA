using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleSaisie
{
    public partial class controle : Form
    {

        public controle()
        {
            InitializeComponent();
        }

        private void Effacer_Click(object sender, EventArgs e)
        {
            textNom.Clear();
            textMontant.Clear();
            textDate.Clear();
            textCP.Clear();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textNom.Text.Length > 0 & textDate.Text.Length > 0 & textMontant.Text.Length > 0 & textCP.Text.Length > 0)
            {
                Valider.Enabled = true;
            }
            else
            {
                Valider.Enabled = false;
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text;
            string date = textDate.Text;
            string montant = textMontant.Text;
            string cp = textCP.Text;
            var parseDate = DateTime.Parse(textDate.Text);
            // il faut parse apres

            bool nomIsOk = Regex.IsMatch(textNom.Text, @"^[A-Za-z]+$");
            bool montantIsOk = Regex.IsMatch(textMontant.Text, @"^[0-9]*.?[0-9][^-]*$");
            bool dateIsOk = Regex.IsMatch(textDate.Text, @"^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)\d{4}$") & parseDate > DateTime.Now;
            bool cpIsOk = Regex.IsMatch(textCP.Text, @"^[0-9]{5}$");



            if (nomIsOk & cpIsOk & montantIsOk & dateIsOk)
            {

                Validation valide2 = new Validation(nom, date, montant, cp);
                valide2.Show();
            }

        }

        private void controle_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
            ("Fin de l’application ?", "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }


    }
}
