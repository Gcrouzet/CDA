using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMDI
{
    public partial class FormSaisie : Form
    {
        private static int iSaisie;

        public delegate void DelegateSaisie(string texte, FormSaisie s);
        public event DelegateSaisie TexteSaisi;

        public FormSaisie()
        {
            InitializeComponent();
            iSaisie++;
            this.Text += " n° " + iSaisie.ToString();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (textBoxSaisie.Text.Length > 0)
            {
                TexteSaisi(textBoxSaisie.Text, this);
            }
            else
            {
                errorProviderSaisie.SetError(buttonValider, "Veuillez saisir un texte");
            }
        }

        private void textBoxVotreTexte_TextChanged(object sender, EventArgs e)
        {
            errorProviderSaisie.Clear();
        }
    }
}