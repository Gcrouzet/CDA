using ClassLibraryPret;
using ClassLibraryVerification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSynthese
{
    public partial class synthese : Form
    {
        private Pret pret;

        public synthese()
        {
            InitializeComponent();
            listBox1.Items.Add("Mensuelle");
            listBox1.Items.Add("Bimestrielle");
            listBox1.Items.Add("Trimestrielle");
            listBox1.Items.Add("Semestrielle");
            listBox1.Items.Add("Annuelle");
            pret = new Pret();
            hScrollBar1.Value = 1;
            listBox1.SetSelected(0, true);
            radioButton7.Checked = true;
        }
        /// <summary>
        /// Methode pour mettre à jour le remboursement
        /// </summary>
        private void UpdateMontantRembourser()
        {
            if (radioButton7.Checked)
            {
                pret.TauxEnPourcentage = 7;
            }
            if (radioButton8.Checked)
            {
                pret.TauxEnPourcentage = 8;
            }
            if (radioButton9.Checked)
            {
                pret.TauxEnPourcentage = 9;
            }
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    pret.Periodicite = Periodicite.Mensuelle;
                    break;
                case 1:
                    pret.Periodicite = Periodicite.Bimestrielle;
                    break;
                case 2:
                    pret.Periodicite = Periodicite.Trimestrielle;
                    break;
                case 3:
                    pret.Periodicite = Periodicite.Semestrielle;
                    break;
                case 4:
                    pret.Periodicite = Periodicite.Annuelle;
                    break;
            }

            labelNbDeRemboursement.Text = pret.CalculNombreDeRemboursement().ToString();
            labelRemboursement.Text = Math.Round(pret.CalculMontantEcheance(), 2).ToString() + " €";
        }
        /// <summary>
        /// Calcul le nombre de remboursement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            labelNb.Text = Convert.ToString(hScrollBar1.Value);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    labelNbDeRemboursement.Text = Convert.ToString(hScrollBar1.Value / 1);
                    break;
                case 1:
                    labelNbDeRemboursement.Text = Convert.ToString(hScrollBar1.Value / 2);
                    break;
                case 2:
                    labelNbDeRemboursement.Text = Convert.ToString(hScrollBar1.Value / 3);
                    break;
                case 3:
                    labelNbDeRemboursement.Text = Convert.ToString(hScrollBar1.Value / 6);
                    break;
                case 4:
                    labelNbDeRemboursement.Text = Convert.ToString(hScrollBar1.Value / 12);
                    break;
            }

        }
        /// <summary>
        /// Met à jour la scrollbar en fonction du SelectedItem de la liste (mensuel,annuel etc) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    labelNb.Text = "1";
                    labelNbDeRemboursement.Text = "1";
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 101;
                    hScrollBar1.SmallChange = 1;
                    hScrollBar1.LargeChange = 10;
                    UpdateMontantRembourser();
                    break;
                case 1:
                    labelNb.Text = "2";
                    labelNbDeRemboursement.Text = "1";
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 79;
                    hScrollBar1.SmallChange = 2;
                    hScrollBar1.LargeChange = 10;
                    UpdateMontantRembourser();
                    break;
                case 2:
                    labelNb.Text = "3";
                    labelNbDeRemboursement.Text = "1";
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 128;
                    hScrollBar1.SmallChange = 3;
                    hScrollBar1.LargeChange = 9;
                    UpdateMontantRembourser();
                    break;
                case 3:
                    labelNb.Text = "6";
                    labelNbDeRemboursement.Text = "1";
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 131;
                    hScrollBar1.SmallChange = 6;
                    hScrollBar1.LargeChange = 12;
                    UpdateMontantRembourser();
                    break;
                case 4:
                    labelNb.Text = "12";
                    labelNbDeRemboursement.Text = "1";
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 203;
                    hScrollBar1.SmallChange = 12;
                    hScrollBar1.LargeChange = 12;
                    UpdateMontantRembourser();
                    break;
            }
        }
        /// <summary>
        /// Associe la scrollbar au nombre label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelNb_TextChanged(object sender, EventArgs e)
        {
            hScrollBar1.Value = Convert.ToInt32(labelNb.Text);
        }
        /// <summary>
        /// Verif capital et nom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCapitalEmprunte_TextChanged(object sender, EventArgs e)
        {
            bool capital = int.TryParse(textBoxCapitalEmprunte.Text, out int result);
            bool nomIsOk = Verification.ValidNom(textBoxNom.Text);

            if (textBoxNom.TextLength > 0 & textBoxCapitalEmprunte.TextLength > 0 & capital & nomIsOk)
            {
                buttonOk.Enabled = true;
            }
            else
            {
                buttonOk.Enabled = false;
            }

            if (capital == true)
            {

                pret.CapitalEmprunt = Convert.ToInt32(textBoxCapitalEmprunte.Text);
                UpdateMontantRembourser();
            }
            else
            {
                errorProvider1.SetError(textBoxCapitalEmprunte, "Entrez un nombre à emprunter");
            }

            if (textBoxCapitalEmprunte.Text.Length == 0)
            {
                errorProvider1.Clear();
            }

        }


        /// <summary>
        /// Gere le changement des radiobuttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMontantRembourser();
        }

        /// <summary>
        /// Verif nom + capital  pour sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool nomIsOk = Verification.ValidNom(Convert.ToString(textBoxNom.Text));
            bool capitalIsOk = Verification.ValidMontant(textBoxCapitalEmprunte.Text);
            if (nomIsOk & capitalIsOk)
            {
                MessageBox.Show("Validation éffectuée");
            }
            else if (nomIsOk == false)
            {
                errorProvider1.SetError(textBoxNom, "Rentrez un nom(alphabétique) commençant par une majuscule et sans espace");
            }
            else
            {
                errorProvider1.SetError(textBoxCapitalEmprunte, "Rentrez un nombre");

            }

        }
        /// <summary>
        /// Fin du programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void synthese_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
            ("Fin de l’application ?", "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }
        /// <summary>
        /// verif nom + active/desactive Bouton Sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            bool nomIsOk = Verification.ValidNom(textBoxNom.Text);
            bool capital = int.TryParse(textBoxCapitalEmprunte.Text, out int result);

            if (nomIsOk == false)
            {
                errorProvider1.SetError(textBoxNom, "Rentrez un nom(alphabétique) commençant par une majuscule et sans espace");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (textBoxNom.TextLength > 0 & textBoxCapitalEmprunte.TextLength > 0 & nomIsOk & capital)
            {
                buttonOk.Enabled = true;
            }
            else
            {
                buttonOk.Enabled = false;
            }
        }
        /// <summary>
        /// Gere la barre manuelle de la scrollbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int periodicite = Convert.ToInt32(pret.Periodicite);

            if (hScrollBar1.Value % periodicite == 0)
            {
                labelNb.Text = hScrollBar1.Value.ToString();
                pret.DureeRemboursementEnMois = hScrollBar1.Value;
            }
            else
            {
                hScrollBar1.Value = hScrollBar1.Value + 1;
            }
            UpdateMontantRembourser();

        }


    }
}
