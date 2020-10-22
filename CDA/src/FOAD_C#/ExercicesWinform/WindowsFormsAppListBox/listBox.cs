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
                textBoxAjout.Clear();
            }
            else if (pasDouble == true)
            {
                errorProviderAjout.SetError(textBoxAjout, "Doublon");
            }
            else
            {
                errorProviderAjout.SetError(textBoxAjout, "Veuillez entrer un prénom valide");
                textBoxAjout.Focus();

            }

            textBoxItemCount.Text = listBoxLstListe.Items.Count.ToString();
            buttonVider.Enabled = true;

        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            //clear de la listBox
            buttonSelectionner.Enabled = false;
            listBoxLstListe.Items.Clear();
            textBoxItemCount.Clear();
            textBoxSelectedIndex.Clear();
            textBoxText.Clear();
            buttonVider.Enabled = false;
            textBoxIndex.Clear();
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {

            // verification du chiffre à selectionner
            bool nombreIsOk = Verification.ValidNombre(textBoxIndex.Text);
            if (nombreIsOk == true)
            {

                int nombre = int.Parse(textBoxIndex.Text);
                // verif chiffre ne depasse pas le nombre d'item dans la listbox
                if (nombre > listBoxLstListe.Items.Count)
                {
                    errorProviderIndex.SetError(textBoxIndex, "Il n'y a pas autant d'élément dans le tableau");
                    textBoxIndex.Clear();
                }
                else if (nombre <= 0)
                {
                    errorProviderIndex.SetError(textBoxIndex, "Choissisez un chiffre/nombre");
                    textBoxIndex.Clear();
                }
                else
                {
                    errorProviderIndex.Clear();
                    listBoxLstListe.SetSelected(nombre - 1, true);
                    textBoxSelectedIndex.Text = Convert.ToString(nombre);
                    textBoxText.Text = listBoxLstListe.SelectedItem.ToString();
                }
            }
            else
            {
                errorProviderIndex.SetError(textBoxIndex, "Choissisez un chiffre/nombre");
                textBoxIndex.Clear();
            }
        }

        private void listBoxLstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text = Convert.ToString(listBoxLstListe.SelectedIndex + 1);
            textBoxText.Text = listBoxLstListe.SelectedItem.ToString();

        }

        private void textBoxAjout_Click(object sender, EventArgs e)
        {
            errorProviderAjout.Clear();
        }

        private void textBoxIndex_Click(object sender, EventArgs e)
        {
            errorProviderIndex.Clear();
        }

        private void textBoxAjout_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAjout.Text.Length > 0)
            {
                buttonAjout.Enabled = true;
            }
            else
            {
                buttonAjout.Enabled = false;
            }
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIndex.TextLength == 0)
            {
                buttonSelectionner.Enabled = false;
            }
            else if (listBoxLstListe.Items.Count == 0)
            {
                buttonSelectionner.Enabled = true;

            }
            else
            {
                buttonSelectionner.Enabled = true;
            }
        }
    }
}
