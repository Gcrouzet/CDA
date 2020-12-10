using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsConnexionALaBase
{
    public partial class Connexion : Form
    {
        private SqlConnection sqlConnect;
        private const string Serveur = "CGABI\\SQLEXPRESS";
        private const string Bdd = "papyrus";


        public Connexion()
        {
            InitializeComponent();
        }




        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            sqlConnect.Close();
            labelClosed_Open.Text = sqlConnect.State.ToString();
            buttonDeconnexion.Enabled = false;
            buttonConnexion.Enabled = true;
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string nomServeur = textBoxServeur.Text ;
            string bDD =textBoxBDD.Text ;
            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = "Data Source = "+nomServeur+"; Initial Catalog = "+bDD+"; Integrated Security = True";
            try
            {
                sqlConnect.Open();
                labelClosed_Open.Text = sqlConnect.State.ToString();
                buttonDeconnexion.Enabled = true;
                buttonConnexion.Enabled = false;
                textBoxErreur.Clear();
            }
            catch (SqlException ex)
            {
                textBoxErreur.Text = ex.Message ;
            }
           
        }

        #region Close
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Connexion_FormClosing(object sender, FormClosingEventArgs e)
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
           
        }
        #endregion
    }
}
