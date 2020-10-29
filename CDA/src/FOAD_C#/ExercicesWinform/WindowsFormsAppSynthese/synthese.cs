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
        private Pret pret = new Pret();
        private int nbRemboursementAnnee = 12;
        public synthese()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Methode pour mettre à jour le remboursement
        /// </summary>
        private void UpdateMonrantRembourser()
        {
            if (radioButton7.Checked)
            {
                pret.Taux = (7f / nbRemboursementAnnee) / 100f;
            }
            if (radioButton8.Checked)
            {
                pret.Taux = (8f / nbRemboursementAnnee) / 100f;
            }
            if (radioButton9.Checked)
            {
                pret.Taux = (9f / nbRemboursementAnnee) / 100f;
            }
            double remboursement = pret.Capital * (pret.Taux / (1 - (Math.Pow((1 + pret.Taux), -(pret.NbDeRemboursement)))));
            pret.MontantParRemboursement = remboursement;
            labelRemboursement.Text = Convert.ToString(Math.Round(pret.MontantParRemboursement, 2) + "€");
        }
        /// <summary>
        /// Ajout des item à la listebox et charge le radioButton coché par default + nb de remboursement par default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void synthese_Load(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            listBox1.Items.Add("Mensuelle");
            listBox1.Items.Add("Bimestrielle");
            listBox1.Items.Add("Trimestrielle");
            listBox1.Items.Add("Semestrielle");
            listBox1.Items.Add("Annuelle");
            pret.Taux = pret.Taux = (7f / nbRemboursementAnnee) / 100f;
            pret.NbDeRemboursement = 1;

        }
        /// <summary>
        /// selectionne par défault le premier item de la liste et met le focus pour rentrer le nom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void synthese_Shown(object sender, EventArgs e)
        {
            textBoxNom.Focus();
            listBox1.SetSelected(0, true);
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
                    pret.NbDeRemboursement = 1;
                    nbRemboursementAnnee = 12;
                    labelNbDeRemboursement.Text = "1";
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 101;
                    hScrollBar1.SmallChange = 1;
                    hScrollBar1.LargeChange = 10;
                    UpdateMonrantRembourser();
                    break;
                case 1:
                    labelNb.Text = "2";
                    pret.NbDeRemboursement = 1;
                    nbRemboursementAnnee = 6;
                    labelNbDeRemboursement.Text = "1";
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 79;
                    hScrollBar1.SmallChange = 2;
                    hScrollBar1.LargeChange = 10;
                    UpdateMonrantRembourser();
                    break;
                case 2:
                    labelNb.Text = "3";
                    pret.NbDeRemboursement = 1;
                    nbRemboursementAnnee = 4;
                    labelNbDeRemboursement.Text = "1";
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 98;
                    hScrollBar1.SmallChange = 3;
                    hScrollBar1.LargeChange = 9;
                    UpdateMonrantRembourser();
                    break;
                case 3:
                    labelNb.Text = "6";
                    pret.NbDeRemboursement = 1;
                    nbRemboursementAnnee = 2;
                    labelNbDeRemboursement.Text = "1";
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 131;
                    hScrollBar1.SmallChange = 6;
                    hScrollBar1.LargeChange = 12;
                    UpdateMonrantRembourser();
                    break;
                case 4:
                    labelNb.Text = "12";
                    pret.NbDeRemboursement = 1;
                    nbRemboursementAnnee = 1;
                    labelNbDeRemboursement.Text = "1";
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 203;
                    hScrollBar1.SmallChange = 12;
                    hScrollBar1.LargeChange = 24;

                    UpdateMonrantRembourser();
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

                pret.Capital = Convert.ToInt32(textBoxCapitalEmprunte.Text);
                UpdateMonrantRembourser();
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
            // met à jour le cacul du taux en fonction du type de remboursement(annuel , mensuel etc...)
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    nbRemboursementAnnee = 12;
                    break;
                case 1:
                    nbRemboursementAnnee = 6;
                    break;
                case 2:
                    nbRemboursementAnnee = 4;
                    break;
                case 3:
                    nbRemboursementAnnee = 2;
                    break;
                case 4:
                    nbRemboursementAnnee = 1;
                    break;
            }
            if (radioButton7.Checked)
            {
                pret.Taux = (7f / nbRemboursementAnnee) / 100f;
                UpdateMonrantRembourser();
            }
            if (radioButton8.Checked)
            {
                pret.Taux = (8f / nbRemboursementAnnee) / 100f;
                UpdateMonrantRembourser();
            }
            if (radioButton9.Checked)
            {
                pret.Taux = (9f / nbRemboursementAnnee) / 100f;
                UpdateMonrantRembourser();
            }
        }
        /// <summary>
        /// Update du montant à rembourser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelNbDeRemboursement_TextChanged(object sender, EventArgs e)
        {
            pret.NbDeRemboursement = Convert.ToInt32(labelNbDeRemboursement.Text);
            UpdateMonrantRembourser();
        }
        /// <summary>
        /// Verif nom + capital  pour sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool nomIsOk = Verification.ValidNom(textBoxNom.Text);
            bool capitalIsOk = Verification.ValidMontant(textBoxCapitalEmprunte.Text);
            if (nomIsOk & capitalIsOk)
            {
                MessageBox.Show("Validation éffectuée");
            }
            else if (nomIsOk == false)
            {
                errorProvider1.SetError(textBoxNom, "Rentrez un nom commençant par une majuscule");
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
                errorProvider1.SetError(textBoxNom, "Entrez un nom commençant par une majuscule");
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
            var multiple2 = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 58, 60, 62, 64, 66, 68, 70 };
            var multiple4 = new List<int> { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90 };
            var multiple6 = new List<int> { 6, 12, 18, 24, 30, 36, 42, 48, 54, 60, 66, 72, 78, 84, 90, 96, 102, 108, 114, 120 };
            var multiple12 = new List<int> { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120, 132, 144, 156, 168, 180 };
            switch (listBox1.SelectedIndex)
            {
                case 1:
                    if (!(multiple2.Contains(hScrollBar1.Value)))
                    {
                        hScrollBar1.Value++;
                    }
                    break;
                case 2:
                    if (!(multiple4.Contains(hScrollBar1.Value)))
                    {
                        hScrollBar1.Value++;
                    }
                    break;
                case 3:
                    if (!(multiple6.Contains(hScrollBar1.Value)))
                    {
                        hScrollBar1.Value++;
                    }
                    break;
                case 4:
                    if (!(multiple12.Contains(hScrollBar1.Value)))
                    {
                        hScrollBar1.Value++;
                    }
                    break;

            }

        }
    }
}
