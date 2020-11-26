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
        /// <summary>
        /// incrémentation des forms
        /// </summary>
        private int iAddiotionneur = 1 ;
        private int iControle = 1 ;
        private int iListboxCombobox = 1 ;
        private int iDefilement = 1 ;
        private int iSynthese = 1 ;
        private int iOpListBox = 1 ;
        private int iCheckBoxRadio = 1 ;
       
      
        public frmMenu()
        {
            InitializeComponent();
            toolStripStatusLabelDate.Text = DateTime.Now.ToString("d");
            menuStripMain.MdiWindowListItem = fenetres;
        }
        /// <summary>
        /// Quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
           {
            DialogResult dr = MessageBox.Show
            ("Fin de l’application ?", "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            { 
              this.Close();
            }
                
        }
        /// <summary>
        /// Deverouillage des boutons de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sidentifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDerniereOperation.Text = "S'identifier";
            FormLogin login = new FormLogin();
            login.ShowDialog();

            if (login.LoginIsOk)
            {
                MessageBox.Show("Bienvenue");
                toolStripButtonSIdentifier.Enabled = false;
                sidentifierToolStripMenuItem1.Enabled = false;
                phase1.Enabled = true;
                phase2.Enabled = true;
                phase3.Enabled = true;
                fenetres.Enabled = true;
                toolStripSplitButtonPhase3.Enabled = true;

            }

        }

        #region Form
        /// <summary>
        /// form Additionneur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Additionneur addi = new Additionneur();
            addi.Text += " N° " + iAddiotionneur++;
            addi.MdiParent = this;
            addi.Show();
            toolStripStatusLabelDerniereOperation.Text = "Additionneur";
        }
        /// <summary>
        /// form Controle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Text += " N° " + iControle++;
            controle.MdiParent = this;
            controle.Show();
            toolStripStatusLabelDerniereOperation.Text = "Controle";
        }
        /// <summary>
        /// form ListboxCombobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBox_open();
        }
        private void comboBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ComboBox_open();
        }
        private void ComboBox_open()
        {
            ListboxCombobox combo = new ListboxCombobox();
            combo.Text += " N° " + iListboxCombobox++;
            combo.MdiParent = this;
            combo.Show();
            toolStripStatusLabelDerniereOperation.Text = "ComboBox";
        }

        /// <summary>
        /// form Defilement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Defilement_open();
        }
        private void defilementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Defilement_open();
        }
        private void Defilement_open()
        {
            Defilement defilement = new Defilement();
            defilement.Text += " N° " + iDefilement++;
            defilement.MdiParent = this;
            defilement.Show();
            toolStripStatusLabelDerniereOperation.Text = "Défilement";
        }

        /// <summary>
        /// form Synthese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void synthèseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Synthese_open();

        }
        private void synthèseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Synthese_open();
        }
        private void Synthese_open()
        {
            Synthese synthese = new Synthese();
            synthese.Text += " N° " + iSynthese++;
            synthese.MdiParent = this;
            synthese.Show();
            toolStripStatusLabelDerniereOperation.Text = "Synthèse";
        }

        /// <summary>
        /// form OpListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox_open();
        }
        private void listBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListBox_open();
        }

        private void ListBox_open()
        {
            OpListBox list = new OpListBox();
            list.Text += " N° " + iOpListBox++;
            list.MdiParent = this;
            list.Show();
            toolStripStatusLabelDerniereOperation.Text = "ListBox";
        }

        /// <summary>
        /// form CheckBoxRadio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void casesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cases_open();
        }
        private void casesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cases_open();
        }

        private void Cases_open()
        {
            toolStripStatusLabelDerniereOperation.Text = "Cases";
            FormSaisie formSaisie = new FormSaisie();
            formSaisie.MdiParent = this;
            formSaisie.TexteSaisi += FormSaisie_TexteSaisi;
            formSaisie.Show();
        }

        private void FormSaisie_TexteSaisi(string texte, FormSaisie s)
        {
            s.Close();
            CheckBoxRadio check = new CheckBoxRadio(texte);
            check.Text += " N° " + iCheckBoxRadio++;
            check.MdiParent = this;
            check.Show();
        }
        #endregion

        #region Positionnement

        /// <summary>
        /// positionnement en cascade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        /// <summary>
        /// positionnement en horizontal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           LayoutMdi(MdiLayout.TileHorizontal);
        }
        /// <summary>
        /// positionnement en vertical
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion

    }
}
