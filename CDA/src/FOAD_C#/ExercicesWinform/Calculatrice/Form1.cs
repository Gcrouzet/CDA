using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        private int somme = 0 ;

        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void button0_Click(object sender, EventArgs e)
        {
            this.somme += 0;
            this.textBoxAffichageCalcul.Text += "0+" ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.somme += 1;
            this.textBoxAffichageCalcul.Text += "1+";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.somme += 2;
            this.textBoxAffichageCalcul.Text += "2+";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.somme += 3;
            this.textBoxAffichageCalcul.Text += "3+";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.somme += 4;
            this.textBoxAffichageCalcul.Text += "4+";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.somme += 5;
            this.textBoxAffichageCalcul.Text += "5+";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.somme += 6;
            this.textBoxAffichageCalcul.Text += "6+";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.somme += 7;
            this.textBoxAffichageCalcul.Text += "7+";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.somme += 8;
            this.textBoxAffichageCalcul.Text += "8+";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.somme += 9;
            this.textBoxAffichageCalcul.Text += "9+";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            
            this.textBoxAffichageCalcul.Text = '='+this.somme.ToString()+'+' ;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Clear();
            this.somme = 0;
        }


    }
}
