﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDefilement
{
    public partial class Defilement : Form
    {
        private Color couleurFinale;
        public Defilement()
        {
            InitializeComponent();
            couleurFinale = Color.FromArgb(0, 0, 0);
        }
        /// <summary>
        /// Update la couleur du textBoxEtiquette
        /// </summary>
        private void UpdateCouleurFinale()
        {
            textBoxEtiquette.BackColor = couleurFinale;
        }
        /// <summary>
        /// Chargement des couleurs dans les textboxs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defilement_Load(object sender, EventArgs e)
        {
            textBoxBleu.BackColor = System.Drawing.Color.Blue;
            textBoxRouge.BackColor = System.Drawing.Color.Red;
            textBoxVert.BackColor = System.Drawing.Color.Green;
            textBoxEtiquette.BackColor = couleurFinale;
        }
        /// <summary>
        /// associe la scrollbar rouge au numerique rouge et change la couleur de l'etiquette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownRouge_ValueChanged(object sender, EventArgs e)
        {

            hScrollBarRouge.Value = (int)numericUpDownRouge.Value;
            couleurFinale = Color.FromArgb((int)numericUpDownRouge.Value, couleurFinale.G, couleurFinale.B);
            UpdateCouleurFinale();
        }
        /// <summary>
        /// associe la scrollbar vert au numerique vert et change la couleur de l'etiquette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarVert.Value = (int)numericUpDownVert.Value;
            couleurFinale = Color.FromArgb(couleurFinale.R, (int)numericUpDownVert.Value, couleurFinale.B);
            UpdateCouleurFinale();
        }

        /// <summary>
        /// associe la scrollbar bleu au numerique bleu et change la couleur de l'etiquette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarBleu.Value = (int)numericUpDownBleu.Value;
            couleurFinale = Color.FromArgb(couleurFinale.R, couleurFinale.G, (int)numericUpDownBleu.Value);
            UpdateCouleurFinale();
        }
        /// <summary>
        /// associe la scrollbar rouge au numerique rouge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarRouge_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownRouge.Value = hScrollBarRouge.Value;
        }
        /// <summary>
        /// associe la scrollbar vert au numerique vert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarVert_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownVert.Value = hScrollBarVert.Value;
        }
        /// <summary>
        /// associe la scrollbar bleu au numerique bleu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarBleu_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownBleu.Value = hScrollBarBleu.Value;
        }

    }
}
