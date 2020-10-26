using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryVerification
{
    public static class Verification
    {
        // regex en constante de nom et code postal
        private const string regexNom = @"^[A-Z][a-z]*$";
        private const string regexCp = @"^(?:[0-8]\d|9[0-8])\d{3}$";
        private const string regexPrenom = @"^[a-z]+[ \-']?[a-z]+$";
        private const string regexNombre = @"^[1-9]*[0-9]*$"

;


        /// <summary>
        /// Valide la date
        /// </summary>
        /// <returns></returns>
        public static bool ValidDate(string _date)
        {
            return DateTime.TryParse(_date, out DateTime result);

        }
        /// <summary>
        /// Valide le nom
        /// </summary>
        /// <param name="_nom"></param>
        /// <returns></returns>
        public static bool ValidNom(string _nom)
        {
            return Regex.IsMatch(_nom, regexNom);

        }
        /// <summary>
        /// Valide le montant
        /// </summary>
        /// <param name="_montant"></param>
        /// <returns></returns>
        public static bool ValidMontant(string _montant)
        {
            return float.TryParse(_montant, out float number) && number > 0;
        }

        /// <summary>
        /// Valide un nombre
        /// </summary>
        /// <param name="_nombre"></param>
        /// <returns></returns>
        public static bool ValidNombre(string _nombre)
        {
            return int.TryParse(_nombre, out int result) && Regex.IsMatch(_nombre, regexNombre);
        }
        /// <summary>
        ///  Valide le code postal
        /// </summary>
        /// <param name="_cp"></param>
        /// <returns></returns>
        public static bool ValidCP(string _cp)
        {
            return Regex.IsMatch(_cp, regexCp);

        }
        /// <summary>
        /// Erreur : icone + son + focus sur l'erruer
        /// </summary>
        /// <param name="textbox"></param>
        /// <param name="erreur"></param>
        public static void ErreurSaisie(TextBox textbox)
        {
            textbox.Focus();
            SystemSounds.Exclamation.Play();
        }
        /// <summary>
        /// Valide le prenom
        /// </summary>
        /// <param name="_nom"></param>
        /// <returns></returns>
        public static bool ValidPrenom(string _prenom)
        {
            return Regex.IsMatch(_prenom, regexPrenom);

        }
    }

}