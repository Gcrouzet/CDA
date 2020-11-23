using Calculatrice;
using controleSaisie;
using System;
using System.Windows.Forms;
using WindowsFormsAppDefilement;
using WindowsFormsAppListBox;
using WindowsFormsAppListBoxComboBox;
using WindowsFormsAppSynthese;
using WindowsFormsCheckBox;

namespace WindowsFormsAppMDI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            toolStripStatusLabelDate.Text = DateTime.Now.ToString("d");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show
            ("Fin de l’application ?", "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }

        private void sidentifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue");
            phase1.Enabled = true;
            phase2.Enabled = true;
            phase3.Enabled = true;
            fenetres.Enabled = true;
            toolStripSplitButtonPhase3.Enabled = true;
            toolStripStatusLabelDerniereOperation.Text = "S'identifier";
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additionneur addi = new Additionneur();
            addi.Show();
            toolStripStatusLabelDerniereOperation.Text = "Additionneur";
        }

        private void controleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Show();
            toolStripStatusLabelDerniereOperation.Text = "Controle";
        }

        private void comboboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListboxCombobox combo = new ListboxCombobox();
            combo.Show();
            toolStripStatusLabelDerniereOperation.Text = "ComboBox";
        }

        private void défilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Defilement defilement = new Defilement();
            defilement.Show();
            toolStripStatusLabelDerniereOperation.Text = "Défilement";
        }

        private void synthèseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Synthese synthese = new Synthese();
            synthese.Show();
            toolStripStatusLabelDerniereOperation.Text = "Synthèse";
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpListBox list = new OpListBox();
            list.Show();
            toolStripStatusLabelDerniereOperation.Text = "ListBox";
        }

        private void casesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBoxRadio check = new CheckBoxRadio();
            check.Show();
            toolStripStatusLabelDerniereOperation.Text = "Cases";
        }

    }
}
