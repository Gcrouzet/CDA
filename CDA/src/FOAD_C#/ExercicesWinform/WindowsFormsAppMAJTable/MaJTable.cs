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

namespace WindowsFormsAppMAJTable
{

    public partial class MaJTable : Form
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommande;
        private SqlDataReader sqlReader;
        public MaJTable()
        {
            InitializeComponent();
        }
        private void MaJComboBoxListeFournisseur()
        {
            comboBoxListeFournisseur.Items.Clear();
            sqlCommande = new SqlCommand();
            sqlCommande.Connection = sqlConnect;
            String strSql = "select fournisseur_nom from fournisseur";
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

        #region bouton
        private void buttonRechercher_Click(object sender, EventArgs e)
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


                SqlParameter sqlCodeFournisseur = new SqlParameter("@nomFournisseur", DbType.Int32);
                sqlCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);
                string strSql = "select * from fournisseur where fournisseur_id =@nomFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        textBoxNom.Text = sqlReader.GetString(1);
                        textBoxAdresse.Text = sqlReader.GetString(2);
                        textBoxCP.Text = sqlReader.GetString(3);
                        textBoxVille.Text = sqlReader.GetString(4);
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


        private void buttonSupprimer_Click(object sender, EventArgs e)
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
                SqlParameter sqlcodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int32);
                sqlcodeFournisseur.Value = textBoxCodeFournisseur.Text;
                sqlCommande.Parameters.Add(sqlcodeFournisseur);
                string strSql = "DELETE FROM fournisseur WHERE fournisseur_id=@codeFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();
                if(sqlReader.RecordsAffected > 0)
                {
                    MessageBox.Show("Le fournisseur avec l'id " + textBoxCodeFournisseur.Text + " a été supprimé");
                }
                else
                {
                    MessageBox.Show("Il n'y a rien à supprimer");
                }


                // Clear textBox
                textBoxNom.Clear();
                textBoxAdresse.Clear();
                textBoxCP.Clear();
                textBoxVille.Clear();
                textBoxCodeFournisseur.Clear();

                sqlReader.Close();

                MaJComboBoxListeFournisseur();
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

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            textBoxNom.ReadOnly = false;
            textBoxNom.Clear();
            textBoxAdresse.ReadOnly = false;
            textBoxAdresse.Clear();
            textBoxCP.ReadOnly = false;
            textBoxCP.Clear();
            textBoxVille.ReadOnly = false;
            textBoxVille.Clear();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
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


                SqlParameter sqlnomFournisseur = new SqlParameter("@nomFournisseur", DbType.String);
                sqlnomFournisseur.Value = textBoxNom.Text;

                SqlParameter sqladresseFournisseur = new SqlParameter("@adresseFournisseur", DbType.String);
                sqladresseFournisseur.Value = textBoxAdresse.Text;

                SqlParameter sqlcpFournisseur = new SqlParameter("@cpFournisseur", DbType.String);
                sqlcpFournisseur.Value = textBoxCP.Text;

                SqlParameter sqlvilleFournisseur = new SqlParameter("@villeFournisseur", DbType.String);
                sqlvilleFournisseur.Value = textBoxVille.Text;

                sqlCommande.Parameters.Add(sqlnomFournisseur);
                sqlCommande.Parameters.Add(sqladresseFournisseur);
                sqlCommande.Parameters.Add(sqlcpFournisseur);
                sqlCommande.Parameters.Add(sqlvilleFournisseur);

                string strSql = "Insert into fournisseur(fournisseur_nom,fournisseur_adresse,fournisseur_cp,fournisseur_ville) VALUES(@nomFournisseur,@adresseFournisseur,@cpFournisseur,@villeFournisseur)";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                MessageBox.Show("Vous avez ajouté un fournisseur, Bien joué");
         
                sqlReader.Close();
                MaJComboBoxListeFournisseur();
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

        




        #endregion

        private void textBoxCodeFournisseur_TextChanged(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxAdresse.Clear();
            textBoxCP.Clear();
            textBoxVille.Clear();
        }

        private void MaJTable_Load(object sender, EventArgs e)
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
                MaJComboBoxListeFournisseur();
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
                string strSql = "select * from fournisseur where fournisseur_nom=@nomFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        textBoxCodeFournisseur.Text = sqlReader.GetInt32(0).ToString();
                        textBoxNom.Text = sqlReader.GetString(1);
                        textBoxAdresse.Text = sqlReader.GetString(2);
                        textBoxCP.Text = sqlReader.GetString(3);
                        textBoxVille.Text = sqlReader.GetString(4);
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

}