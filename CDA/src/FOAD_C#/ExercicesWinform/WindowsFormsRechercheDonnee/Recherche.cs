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

namespace WindowsFormsRechercheDonnee
{
    public partial class Recherche : Form
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommande;
        private SqlDataReader sqlReader;
        public Recherche()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new SqlConnection();
                sqlConnect.ConnectionString = "Data Source=CGABI\\SQLEXPRESS;Initial Catalog=Papyrus;Integrated Security=True";
                sqlConnect.Open();
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;

                SqlParameter sqlCodeFournisseur = new SqlParameter("@codefournisseur", DbType.Int64);
                sqlCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);


                string strSql = "Select * from fournisseur where fournisseur_id =@codefournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.HasRows == false)
                {
                    MessageBox.Show("il n'y a pas autant de fournisseur");
                }

                while (sqlReader.Read())
                {
                    string nomFournisseur = sqlReader.GetString(1);
                    string adresseFournisseur = sqlReader.GetString(2);
                    string cpFournisseur = sqlReader.GetString(3);
                    string villeFournisseur = sqlReader.GetString(4);
                    string contactFournisseur = sqlReader.GetString(5);
                    byte satisfactionFournisseur = sqlReader.GetByte(6);
                    Affichage affichage = new Affichage(nomFournisseur, adresseFournisseur, cpFournisseur, villeFournisseur, contactFournisseur, satisfactionFournisseur);
                    affichage.ShowDialog();
                }
                sqlReader.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            sqlConnect.Close();
            this.Close();
        }

        private void Recherche_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
            ("Fin de l’application ?", "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
