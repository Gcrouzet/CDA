using ClassLibraryFacture;
using ClassLibraryVerification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleSaisie
{
    public partial class Controle : Form
    {


        public Controle()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Bouton pour clear les texts boxs et les icones d'erreurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Effacer_Click(object sender, EventArgs e)
        {
            textNom.Clear();
            textMontant.Clear();
            textDate.Clear();
            textCP.Clear();
            errorProvidertextbox.Clear();
        }
        /// <summary>
        /// Check pour rendre les champs obligatoires
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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



        /// <summary>
        ///  Check pour passer à la 2eme fenetre
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void Valider_Click(object sender, EventArgs e)
        {
            string textnom = textNom.Text;
            string textdate = textDate.Text;
            string textmontant = textMontant.Text;
            string textcp = textCP.Text;


            // bool pour tester les regex

            bool nomIsOk = Verification.ValidNom(textnom);
            bool montantIsOk = Verification.ValidMontant(textmontant);
            bool cpIsOk = Verification.ValidCP(textcp);
            bool dateIsOk = Verification.ValidDate(textdate);

            // reset bouton d'erreur en appuyant sur le bouton "valider"

            errorProvidertextbox.Clear();

            // check code postal
            if (cpIsOk == false)
            {
                errorProvidertextbox.SetError(textCP, "Ce n'est pas un" + textCP.Tag.ToString());
                Verification.ErreurSaisie(textCP);
            }


            //  check montant est un nombre
            if (montantIsOk == false)
            {
                errorProvidertextbox.SetError(textMontant, "Ce n'est pas un" + textMontant.Tag.ToString());
                Verification.ErreurSaisie(textMontant);
            }


            // check date anterieur à aujourd'hui
            if (dateIsOk == false)
            {
                errorProvidertextbox.SetError(textDate, "Ce n'est pas un" + textDate.Tag.ToString());
                Verification.ErreurSaisie(textDate);
            }
            else
            {
                var parseDate = DateTime.Parse(textdate);
                if (parseDate <= DateTime.Now)
                {
                    textDate.Focus();
                    errorProvidertextbox.SetError(textDate, "La date est antérieur à aujourd'hui");
                    SystemSounds.Exclamation.Play();
                    dateIsOk = false;
                }
            }

            string validOut = "Nom :  " + textnom + "\nDate :   " + textdate + "\nMontant :   " + textmontant.ToString() + "\nCP :   " + textcp.ToString();

            // check nom n'est compose que de lettre
            if (nomIsOk == false)
            {
                errorProvidertextbox.SetError(textNom, "Ce n'est pas un" + textNom.Tag.ToString());
                Verification.ErreurSaisie(textNom);
            }

            // Check tout est bon 
            if (nomIsOk & montantIsOk & dateIsOk & cpIsOk)
            {
                MessageBox.Show(validOut, "Validation éffectuée");
                DateTime date = DateTime.Parse(textdate);
                float montant = float.Parse(textmontant);
                Facture facture = new Facture(textnom, date, montant, textcp);
                facture.ToString();
            }


        }


        /// <summary>
        /// Boite dialogue Oui/Non pour fermer l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void textNom_Leave(object sender, EventArgs e)
        {
            bool nomIsOk = Verification.ValidNom(textNom.Text);
            if (nomIsOk == false)
            {
                errorProvidertextbox.SetError(textNom, "Ce n'est pas un" + textNom.Tag.ToString());
                Verification.ErreurSaisie(textNom);
            }
            else
            {
                errorProvidertextbox.Clear();
            }
        }

        private void textDate_Leave(object sender, EventArgs e)
        {
            bool dateIsOk = Verification.ValidDate(textDate.Text);
            if (dateIsOk == false)
            {
                errorProvidertextbox.SetError(textDate, "Ce n'est pas un" + textDate.Tag.ToString());
                Verification.ErreurSaisie(textDate);
            }
            else
            {
                errorProvidertextbox.Clear();
            }
        }

        private void textMontant_Leave(object sender, EventArgs e)
        {
            bool montantIsOk = Verification.ValidDate(textMontant.Text);
            if (montantIsOk == false)
            {
                errorProvidertextbox.SetError(textMontant, "Ce n'est pas un" + textMontant.Tag.ToString());
                Verification.ErreurSaisie(textMontant);
            }
            else
            {
                errorProvidertextbox.Clear();
            }
        }

        private void textCP_Leave(object sender, EventArgs e)
        {
            bool cpIsOk = Verification.ValidCP(textCP.Text);
            if (cpIsOk == false)
            {
                errorProvidertextbox.SetError(textCP, "Ce n'est pas un" + textCP.Tag.ToString());
                Verification.ErreurSaisie(textCP);
            }
            else
            {
                errorProvidertextbox.Clear();
            }
        }
    }
}

