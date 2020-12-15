using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppRechercheLigne
{
    public partial class ListeCommande : Form
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommande;
        private SqlDataReader sqlReader;
        public ListeCommande()
        {
            InitializeComponent();
        }

        private void ListeCommande_Load(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection();
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["Papyrus"];
            if (oConfig != null)
            {
                sqlConnect.ConnectionString = oConfig.ConnectionString;
            }
            try
            {
                sqlConnect.Open();
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;
                string strSql = "select fournisseur_nom from fournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        this.comboBoxListeFournisseur.Items.Add(sqlReader.GetString(0));
                    }
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

        private void comboBoxListeFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCommandes.Items.Clear();
            sqlConnect = new SqlConnection();
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["Papyrus"];
            if (oConfig != null)
            {
                sqlConnect.ConnectionString = oConfig.ConnectionString;
            }

            try
            {
                sqlConnect.Open();
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;

                SqlParameter sqlCodeFournisseur = new SqlParameter("@nomFournisseur", DbType.String);
                sqlCodeFournisseur.Value = comboBoxListeFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);
                string strSql = "select * from commande  " +
                    "inner join ordre_commande  " +
                    "on commande.commande_id = ordre_commande.commande_id " +
                    "inner join produits  " +
                    "on ordre_commande.produits_id = produits.produits_id " +
                    "inner join fournisseur " +
                    "on produits.fournisseur_id = fournisseur.fournisseur_id " +
                    "where fournisseur_nom =@nomFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        string numCommande = sqlReader.GetInt32(0).ToString();
                        string dateCommande = sqlReader.GetDateTime(1).ToString("d");
                        string commentaireCommande = sqlReader.GetString(2);
                        listBoxCommandes.Items.Add(numCommande);
                        listBoxCommandes.Items.Add(dateCommande);
                        listBoxCommandes.Items.Add(commentaireCommande);
                    }
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
            Close();
        }
    }
}