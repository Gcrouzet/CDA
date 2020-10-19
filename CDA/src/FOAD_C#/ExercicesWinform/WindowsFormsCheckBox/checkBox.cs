using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsCheckBox
{
    public partial class checkBox : Form
    {
        public checkBox()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                groupBoxChoix.Enabled = true;
            }
            else
            {
                groupBoxChoix.Enabled = false;
            }
            labelDouble.Text = textBox.Text;
        }

        private void checkBoxCouleurDeFond_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCouleurDeFond.Checked == true)
            {
                groupBoxFond.Visible = true;
            }
            else
            {
                groupBoxFond.Visible = false;
            }
        }

        private void checkBoxCouleurDesCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCouleurDesCaracteres.Checked == true)
            {
                groupBoxCaracteres.Visible = true;
            }
            else
            {
                groupBoxCaracteres.Visible = false;
            }
        }

        private void checkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCasse.Checked == true)
            {
                groupBoxCasse.Visible = true;
            }
            else
            {
                groupBoxCasse.Visible = false;
            }
        }

        private void radioButtonRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRouge.Checked == true)
            {
                labelDouble.BackColor = System.Drawing.Color.Red;
            }

        }
        private void radioButtonVert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVert.Checked == true)
            {
                labelDouble.BackColor = System.Drawing.Color.Green;
            }

        }

        private void radioButtonBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBleu.Checked == true)
            {
                labelDouble.BackColor = System.Drawing.Color.Blue;
            }

        }

        private void radioButtonRougeCaractere_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRougeCaractere.Checked == true)
            {
                labelDouble.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void radioButtonBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlanc.Checked == true)
            {
                labelDouble.ForeColor = System.Drawing.Color.White;
            }

        }

        private void radioButtonNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNoir.Checked == true)
            {
                labelDouble.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void radioButtonMinuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuscules.Checked == true)
            {

                labelDouble.Text = labelDouble.Text.ToLower();
            }
        }

        private void radioButtonMajuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMajuscules.Checked == true)
            {
                labelDouble.Text = labelDouble.Text.ToUpper();
            }
        }
    }
}
