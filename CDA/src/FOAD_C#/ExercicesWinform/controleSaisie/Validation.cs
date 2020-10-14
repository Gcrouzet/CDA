using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleSaisie
{
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// transfere les données de la premiere form dans la deuxieme
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="date"></param>
        /// <param name="montant"></param>
        /// <param name="cp"></param>
        public Validation(string nom, string date, string montant, string cp)
        {
            InitializeComponent();
            InitializeComponent2(nom, date, montant, cp);
        }
        /// <summary>
        /// Rentre les données de la premiere form dans la deuxieme
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="date"></param>
        /// <param name="montant"></param>
        /// <param name="cp"></param>
        public void InitializeComponent2(string nom, string date, string montant, string cp)
        {
            this.labeltextNom.Text = nom;
            this.labeltextDate.Text = date;
            this.labeltextMontant.Text = montant;
            this.labeltextCP.Text = cp;

        }
        /// <summary>
        /// Bouton pour demander si Oui/Non il faut fermer l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
