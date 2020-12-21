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
            comboBoxListeFournisseur.DisplayMember = "Value";
            comboBoxListeFournisseur.ValueMember = "Key";
            Dictionary<int, string> listeFournisseurs = new Dictionary<int, string>();

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
                string strSql = "select fournisseur_id ,fournisseur_nom  from fournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        listeFournisseurs.Add(sqlReader.GetInt32(0), sqlReader.GetString(1));
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
            this.comboBoxListeFournisseur.DataSource = new BindingSource(listeFournisseurs, null);
            this.comboBoxListeFournisseur.SelectedIndex = -1;
        }

        private void comboBoxListeFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCommandes.Items.Clear();
            if (this.comboBoxListeFournisseur.SelectedIndex >= 0)
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

                    SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int32);
                    sqlCodeFournisseur.Value = comboBoxListeFournisseur.SelectedValue;
                    sqlCommande.Parameters.Add(sqlCodeFournisseur);

                    sqlCommande.CommandType = CommandType.StoredProcedure;
                    sqlCommande.CommandText = "GetCommandesParFournisseur";
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
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}