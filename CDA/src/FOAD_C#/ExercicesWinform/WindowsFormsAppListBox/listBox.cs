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

namespace WindowsFormsAppListBox
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }



        private void buttonAjout_Click(object sender, EventArgs e)
        {
            // Verification du prenom 
            bool prenomIsOk = Verification.ValidPrenom(textBoxAjout.Text);
            bool pasDouble = listBoxLstListe.Items.Contains(textBoxAjout.Text);

            if (prenomIsOk == true & pasDouble == false)
            {
                listBoxLstListe.Items.Add(textBoxAjout.Text);
                errorProviderAjout.Clear();
            }
            else
            {
                errorProviderAjout.SetError(textBoxAjout, "Veuillez entrer un prénom valide");
                textBoxAjout.Focus();
            }
            textBoxAjout.Clear();
            // calcul du nombre d'item dans la listbox
            int nbItem = listBoxLstListe.Items.Count;
            string nbItemConvert = Convert.ToString(nbItem);
            textBoxItemCount.Text = nbItemConvert;
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            //clear de la listBox
            listBoxLstListe.Items.Clear();
            textBoxItemCount.Clear();
            textBoxSelectedIndex.Clear();
            textBoxText.Clear();
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {

            // verification du chiffre à selectionner
            bool chiffreIsOk = Verification.ValidChiffre(textBoxIndex.Text);
            if (chiffreIsOk == true)
            {

                int chiffre = int.Parse(textBoxIndex.Text);
                // verif chiffre ne depasse pas le nombre d'item dans la listbox
                if (chiffre > listBoxLstListe.Items.Count)
                {
                    errorProviderIndex.SetError(textBoxIndex, "Il n'y a pas autant d'élément dans le tableau");
                    textBoxIndex.Clear();
                }
                else if (chiffre <= 0)
                {
                    errorProviderIndex.SetError(textBoxIndex, "Choissisez un chiffre entre 1 et 9");
                    textBoxIndex.Clear();
                }
                else
                {
                    errorProviderIndex.Clear();
                    listBoxLstListe.SetSelected(chiffre - 1, true);
                    textBoxSelectedIndex.Text = Convert.ToString(chiffre);
                    textBoxText.Text = listBoxLstListe.SelectedItem.ToString();
                }
            }
            else
            {
                errorProviderIndex.SetError(textBoxIndex, "Choissisez un chiffre entre 1 et 9");
                textBoxIndex.Clear();
            }
        }

        private void listBoxLstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text = Convert.ToString(listBoxLstListe.SelectedIndex + 1);
            textBoxText.Text = listBoxLstListe.SelectedItem.ToString();
        }
    }
}
