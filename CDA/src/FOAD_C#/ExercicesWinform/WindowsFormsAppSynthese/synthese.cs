using ClassLibraryVerification;
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
        private Pret pret = new Pret();
        public synthese()
        {
            InitializeComponent();

        }
        private void UpdateMonrantRembourser()
        {
            double remboursement = pret.Capital * (pret.Taux / (1 - (Math.Pow((1 + pret.Taux), -(pret.NbDeRemboursement)))));
            pret.MontantParRemboursement = remboursement;
            labelRemboursement.Text = Convert.ToString(Math.Round(remboursement, 2) + "€");
        }
        private void synthese_Load(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            listBox1.Items.Add("Mensuelle");
            listBox1.Items.Add("Bimestrielle");
            listBox1.Items.Add("Trimestrielle");
            listBox1.Items.Add("Semestrielle");
            listBox1.Items.Add("Annuelle");
            pret.Taux = pret.Taux = (7f / 12f) / 100f;
            pret.NbDeRemboursement = 1;

        }

        private void synthese_Shown(object sender, EventArgs e)
        {
            textBoxNom.Focus();
            listBox1.SetSelected(0, true);
        }

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (listBox1.SelectedIndex)
            {
                case 0:
                    hScrollBar1.Minimum = 1;
                    hScrollBar1.Maximum = 159;
                    hScrollBar1.SmallChange = 1;
                    hScrollBar1.LargeChange = 10;
                    labelNb.Text = "1";
                    pret.NbDeRemboursement = 1;
                    UpdateMonrantRembourser();
                    break;
                case 1:
                    hScrollBar1.Minimum = 2;
                    hScrollBar1.Maximum = 169;
                    hScrollBar1.SmallChange = 2;
                    hScrollBar1.LargeChange = 10;
                    labelNb.Text = "2";
                    pret.NbDeRemboursement = 1;
                    UpdateMonrantRembourser();
                    break;
                case 2:
                    hScrollBar1.Minimum = 3;
                    hScrollBar1.Maximum = 188;
                    hScrollBar1.SmallChange = 3;
                    hScrollBar1.LargeChange = 9;
                    labelNb.Text = "3";
                    pret.NbDeRemboursement = 1;
                    UpdateMonrantRembourser();
                    break;
                case 3:
                    hScrollBar1.Minimum = 6;
                    hScrollBar1.Maximum = 251;
                    hScrollBar1.SmallChange = 6;
                    hScrollBar1.LargeChange = 12;
                    labelNb.Text = "6";
                    pret.NbDeRemboursement = 1;
                    UpdateMonrantRembourser();
                    break;
                case 4:
                    hScrollBar1.Minimum = 12;
                    hScrollBar1.Maximum = 383;
                    hScrollBar1.SmallChange = 12;
                    hScrollBar1.LargeChange = 24;
                    labelNb.Text = "12";
                    pret.NbDeRemboursement = 1;
                    UpdateMonrantRembourser();
                    break;
            }
        }

        private void labelNb_TextChanged(object sender, EventArgs e)
        {
            hScrollBar1.Value = Convert.ToInt32(labelNb.Text);
        }

        private void textBoxCapitalEmprunte_TextChanged(object sender, EventArgs e)
        {

            bool capital = int.TryParse(textBoxCapitalEmprunte.Text, out int result);

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



        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                pret.Taux = (7f / 12f) / 100f;
                UpdateMonrantRembourser();
            }
            if (radioButton8.Checked)
            {
                pret.Taux = (8f / 12f) / 100f;
                UpdateMonrantRembourser();
            }
            if (radioButton9.Checked)
            {
                pret.Taux = (9f / 12f) / 100f;
                UpdateMonrantRembourser();
            }
        }

        private void labelNbDeRemboursement_TextChanged(object sender, EventArgs e)
        {
            pret.NbDeRemboursement = Convert.ToInt32(labelNbDeRemboursement.Text);
            UpdateMonrantRembourser();
        }

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
    }
}
