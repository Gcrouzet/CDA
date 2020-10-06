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
            bool nomIsOk = Regex.IsMatch(textNom.Text, @"^[A-Za-z]+$");
            bool montantIsOk = Regex.IsMatch(textMontant.Text, @"^[0-9].?[0-9][^-]*$");
            bool dateIsOk = Regex.IsMatch(textDate.Text, @"^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)\d{4}$");
            // TODO date supérieur à now .
            bool cpIsOk = Regex.IsMatch(textCP.Text, @"^[0-9]{5}$");


            if (nomIsOk & cpIsOk & montantIsOk & dateIsOk)
            {
                Validation valide = new Validation();
                valide.Show();
            }

        }
    }
}
