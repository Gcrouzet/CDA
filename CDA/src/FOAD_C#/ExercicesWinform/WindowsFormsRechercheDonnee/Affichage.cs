﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsRechercheDonnee
{
    public partial class Affichage : Form
    {
        public Affichage()
        {
            InitializeComponent();
        }
        public Affichage(string nom,string adresse,string cp, string ville,string contact,int satisfaction)
        {
            InitializeComponent();
            textBoxNom.Text = nom;
            textBoxAdresse.Text = adresse;
            textBoxCP.Text = cp;
            textBoxVille.Text = ville;
            textBoxContact.Text = contact;
            textBoxSatisfaction.Text = satisfaction.ToString();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
