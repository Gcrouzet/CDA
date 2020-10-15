﻿using System;
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
        private const string regexNom = @"^[A-Za-z]+$";
        private const string regexCp = @"^(?:[0-8]\d|9[0-8])\d{3}$";


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

            return float.TryParse(_montant, out float result);


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
    }

}