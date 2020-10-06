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
            textDate.Clear();
            textMontant.Clear();
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
            if (Regex.IsMatch(textNom.Text, @"/ ^[AZa - z] +$/"))
            {
                textNom.Clear();

            }

        }
    }
}
