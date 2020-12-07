using ClassLibraryProduction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppToutEmbal
{
    public partial class Production : Form
    {
        private ProductionDeCaisses CaissesA;
        private ProductionDeCaisses CaissesB;
        private ProductionDeCaisses CaissesC;

        private delegate void DelegateMiseAJourIHM();
        private DelegateMiseAJourIHM majIHM;

        

        public Production()
        {
            InitializeComponent();
            CaissesA = new ProductionDeCaisses(10000, 1000);
            CaissesB = new ProductionDeCaisses(25000, 5000);
            CaissesC = new ProductionDeCaisses(120000, 10000);
            CaissesA.ChangementNbCaisses += CaissesA_ChangementNbCaisses;
            CaissesB.ChangementNbCaisses += CaissesB_ChangementNbCaisses;
            CaissesC.ChangementNbCaisses += CaissesC_ChangementNbCaisses;

            majIHM = new DelegateMiseAJourIHM(MajIHM);

            progressBarProdA.Maximum = 10000;
            progressBarProdB.Maximum = 25000;
            progressBarProdC.Maximum = 120000;
        }




        #region Maj de l'IHM
        private void MajIHM()
        {
            textBoxNbCaisseA.Text = CaissesA.NbCaissesDepuisDemarrage.ToString();
            //textBoxTauxDefaulHeureA.Text = CaissesA.CalculTauxDefautParHeure().ToString("N4");
            //textBoxTauxDepuisDemarrageA.Text = CaissesA.CalculBoiteDefaut().ToString();
            progressBarProdA.Value = CaissesA.NbCaissesDepuisDemarrage;

            textBoxNbCaisseB.Text = CaissesB.NbCaissesDepuisDemarrage.ToString();
            //textBoxTauxDefaulHeureB.Text = CaissesB.CalculTauxDefautParHeure().ToString("N4");
            //textBoxTauxDepuisDemarrageB.Text = CaissesB.CalculBoiteDefaut().ToString();
            progressBarProdB.Value = CaissesB.NbCaissesDepuisDemarrage;

            textBoxNbCaisseC.Text = CaissesC.NbCaissesDepuisDemarrage.ToString();
            //textBoxTauxDefaulHeureC.Text = CaissesC.CalculTauxDefautParHeure().ToString("N4");
            //textBoxTauxDepuisDemarrageC.Text = CaissesC.CalculBoiteDefaut().ToString();
            progressBarProdC.Value = CaissesC.NbCaissesDepuisDemarrage;
        }

        private void CaissesA_ChangementNbCaisses(ProductionDeCaisses production)
        {
            this.Invoke(majIHM);
        }
        private void CaissesB_ChangementNbCaisses(ProductionDeCaisses production)
        {
            this.Invoke(majIHM);
        }
        private void CaissesC_ChangementNbCaisses(ProductionDeCaisses production)
        {
            this.Invoke(majIHM);
        }

        #endregion
        #region Gestion de la production
        private void DemarrerA_Click(object sender, EventArgs e)
        {
            CaissesA.DemarrerProduction();
            DemarrerA.Enabled = false;
            ArreterA.Enabled = true;
        }

        private void DemarrerB_Click(object sender, EventArgs e)
        {
            CaissesB.DemarrerProduction();
            DemarrerB.Enabled = false;
            ArreterB.Enabled = true;
        }

        private void DemarrerC_Click(object sender, EventArgs e)
        {
            CaissesC.DemarrerProduction();
            DemarrerC.Enabled = false;
            ArreterC.Enabled = true;
        }

        private void ArreterA_Click(object sender, EventArgs e)
        {
            CaissesA.ArreterProduction();
            ArreterA.Enabled = false;
            ContinuerA.Enabled = true;
        }

        private void ArreterB_Click(object sender, EventArgs e)
        {
            CaissesB.ArreterProduction();
            ArreterB.Enabled = false;
            ContinuerB.Enabled = true;
        }

        private void ArreterC_Click(object sender, EventArgs e)
        {
            CaissesC.ArreterProduction();
            ArreterC.Enabled = false;
            ContinuerC.Enabled = true;
        }

        private void ContinuerA_Click(object sender, EventArgs e)
        {
            CaissesA.DemarrerProduction();
            ContinuerA.Enabled = false;
            ArreterA.Enabled = true;
        }

        private void ContinuerB_Click(object sender, EventArgs e)
        {
            CaissesB.DemarrerProduction();
            ContinuerB.Enabled = false;
            ArreterB.Enabled = true;
        }

        private void ContinuerC_Click(object sender, EventArgs e)
        {
            CaissesA.DemarrerProduction();
            ContinuerC.Enabled = false;
            ArreterC.Enabled = true;
        }

        #endregion
        #region Fermer
        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Production_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
          ("Fin de l’application", "Quitter",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
            #endregion
        }
    }
}
