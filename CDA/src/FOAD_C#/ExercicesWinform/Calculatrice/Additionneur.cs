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
    public partial class Additionneur : Form
    {
        private int somme = 0;

        public Additionneur()
        {
            InitializeComponent();
        }




        private void button0_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;


            switch (b.Name)
            {
                case "button0":
                    this.somme += 0;
                    this.textBoxAffichageCalcul.Text += "0+";
                    break;
                case "button1":
                    this.somme += 1;
                    this.textBoxAffichageCalcul.Text += "1+";
                    break;
                case "button2":
                    this.somme += 2;
                    this.textBoxAffichageCalcul.Text += "2+";
                    break;
                case "button3":
                    this.somme += 3;
                    this.textBoxAffichageCalcul.Text += "3+";
                    break;
                case "button4":
                    this.somme += 4;
                    this.textBoxAffichageCalcul.Text += "4+";
                    break;
                case "button5":
                    this.somme += 5;
                    this.textBoxAffichageCalcul.Text += "5+";
                    break;
                case "button6":
                    this.somme += 6;
                    this.textBoxAffichageCalcul.Text += "6+";
                    break;
                case "button7":
                    this.somme += 7;
                    this.textBoxAffichageCalcul.Text += "7+";
                    break;
                case "button8":
                    this.somme += 8;
                    this.textBoxAffichageCalcul.Text += "8+";
                    break;
                case "button9":
                    this.somme += 9;
                    this.textBoxAffichageCalcul.Text += "9+";
                    break;
                case "vider":
                    this.textBoxAffichageCalcul.Clear();
                    this.somme = 0;
                    break;
                case "Calculer":
                    this.textBoxAffichageCalcul.Text += '=' + this.somme.ToString() + '+';
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
