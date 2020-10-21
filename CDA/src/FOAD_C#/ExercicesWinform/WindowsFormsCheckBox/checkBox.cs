using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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
            labelDouble.Text = textBox.Text;

            if (radioButtonMajuscules.Checked)
            {
                labelDouble.Text = textBox.Text.ToUpper();
            }
            else if (radioButtonMinuscules.Checked)
            {
                labelDouble.Text = textBox.Text.ToLower();
            }
            else
            {
                labelDouble.Text = textBox.Text;
            }


            if (textBox.Text.Length > 0)
            {
                groupBoxChoix.Enabled = true;
            }
            else if (textBox.Text.Length == 0)
            {
                checkBoxCasse.Checked = false;
                checkBoxCouleurDeFond.Checked = false;
                checkBoxCouleurDesCaracteres.Checked = false;
                groupBoxChoix.Enabled = false;
            }
            else
            {
                groupBoxChoix.Enabled = false;
            }

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
                radioButtonVert.Checked = false;
                radioButtonRouge.Checked = false;
                radioButtonBleu.Checked = false;
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
                radioButtonNoir.Checked = false;
                radioButtonBlanc.Checked = false;
                radioButtonRougeCaractere.Checked = false;
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
                radioButtonMinuscules.Checked = false;
                radioButtonMajuscules.Checked = false;

            }
        }

        private void radioButtonRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRouge.Checked == true)
            {
                labelDouble.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                labelDouble.BackColor = SystemColors.Control;
            }

        }
        private void radioButtonVert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVert.Checked == true)
            {
                labelDouble.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                labelDouble.BackColor = SystemColors.Control;
            }
        }

        private void radioButtonBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBleu.Checked == true)
            {
                labelDouble.BackColor = System.Drawing.Color.Blue;
            }
            else
            {
                labelDouble.BackColor = SystemColors.Control;
            }
        }

        private void radioButtonRougeCaractere_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRougeCaractere.Checked == true)
            {
                labelDouble.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                labelDouble.ForeColor = SystemColors.ControlText;
            }
        }

        private void radioButtonBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlanc.Checked == true)
            {
                labelDouble.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                labelDouble.ForeColor = SystemColors.ControlText;
            }
        }

        private void radioButtonNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNoir.Checked == true)
            {
                labelDouble.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                labelDouble.ForeColor = SystemColors.ControlText;
            }
        }

        private void radioButtonMinuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuscules.Checked == true)
            {

                labelDouble.Text = labelDouble.Text.ToLower();
            }
            else
            {
                labelDouble.Text = textBox.Text;
            }
        }

        private void radioButtonMajuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMajuscules.Checked == true)
            {
                labelDouble.Text = labelDouble.Text.ToUpper();
            }
            else
            {
                labelDouble.Text = textBox.Text;
            }
        }
    }
}
