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
            errorProvidertextbox.SetError(textNom, null);
            errorProvidertextbox.SetError(textDate, null);
            errorProvidertextbox.SetError(textMontant, null);
            errorProvidertextbox.SetError(textCP, null);
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
        /// Validation de la date
        /// </summary>
        /// <returns></returns>
        private bool ValidDate()
        {
            bool dateIsOk = Regex.IsMatch(textDate.Text, @"^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)\d{4}$");
            if (dateIsOk)
            {
                var parseDate = DateTime.Parse(textDate.Text);
                if (parseDate > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    textDate.Focus();
                    errorProvidertextbox.SetError(textDate, "La date est antérieur à aujourd'hui");
                    SystemSounds.Exclamation.Play();
                    return false;
                }
            }
            else
            {
                textDate.Focus();
                errorProvidertextbox.SetError(textDate, "Ce n'est pas une date");
                SystemSounds.Exclamation.Play();
                return false;
            }

        }



        /// <summary>
        ///  Check pour passer à la 2eme fenetre
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void Valider_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text;
            string date = textDate.Text;
            string montant = textMontant.Text;
            string cp = textCP.Text;

            // bool pour tester les regex

            bool nomIsOk = Regex.IsMatch(textNom.Text, @"^[A-Za-z]+$");
            bool montantIsOk = Regex.IsMatch(textMontant.Text, @"^[0-9]+(\.[0-9]+)?$");
            bool cpIsOk = Regex.IsMatch(textCP.Text, @"^[0-9]{5}$");
            bool dateIsOk = this.ValidDate();


            // reset bouton d'erreur en appuyant sur le bouton "valider"

            errorProvidertextbox.SetError(textNom, null);
            errorProvidertextbox.SetError(textDate, null);
            errorProvidertextbox.SetError(textMontant, null);
            errorProvidertextbox.SetError(textCP, null);




            if (cpIsOk == false)
            {
                textCP.Focus();
                errorProvidertextbox.SetError(textCP, "Ce n'est pas un code postal");
                SystemSounds.Exclamation.Play();
            }

            //  check montant est un nombre
            if (montantIsOk == false)
            {
                textMontant.Focus();
                errorProvidertextbox.SetError(textMontant, "Ce n'est pas un montant");
                SystemSounds.Exclamation.Play();
            }


            // check nom n'est composé que de lettre
            if (nomIsOk == false)
            {
                textNom.Focus();
                errorProvidertextbox.SetError(textNom, "Ce n'est pas un nom");
                SystemSounds.Exclamation.Play();
            }

            // Check tout est bon 
            if (nomIsOk & montantIsOk & dateIsOk & cpIsOk)
            {
                Validation valide = new Validation(nom, date, montant, cp);
                valide.Show();
            }


        }

        //if (nomIsOk & cpIsOk & montantIsOk & dateIsOk)
        //{

        //    Validation valide = new Validation(nom, date, montant, cp);
        //    valide.Show();
        //}

        //}




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


    }
}

