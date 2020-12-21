using ClassLibraryVerification;
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
            
            comboBoxListeFournisseur.DisplayMember = "Value";
            comboBoxListeFournisseur.ValueMember = "Key";
            Dictionary<int, string> listeFournisseurs = new Dictionary<int, string>();

            sqlCommande = new SqlCommand();
            sqlCommande.Connection = sqlConnect;
            String strSql = "select fournisseur_id ,fournisseur_nom from fournisseur";
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
            comboBoxListeFournisseur.DataSource = new BindingSource(listeFournisseurs, null);
            textBoxNom.Clear();
            textBoxAdresse.Clear();
            textBoxVille.Clear();
            textBoxCP.Clear();
            textBoxCodeFournisseur.Clear();
            comboBoxListeFournisseur.SelectedIndex = -1;
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


                SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int32);
                sqlCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);
                string strSql = "select * from fournisseur where fournisseur_id =@codeFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    buttonSupprimer.Enabled = true;
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
                if (sqlReader.RecordsAffected > 0)
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
            buttonSupprimer.Enabled = false;
            buttonModifier.Enabled = false;
            comboBoxListeFournisseur.SelectedIndex = -1;
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

                    SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.String);
                    sqlCodeFournisseur.Value = comboBoxListeFournisseur.SelectedValue;
                    sqlCommande.Parameters.Add(sqlCodeFournisseur);
                    string strSql = "select * from fournisseur where fournisseur_id=@codeFournisseur";
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
                    buttonSupprimer.Enabled = true;
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

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> listeFournisseur = new Dictionary<int, string>();
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
                sqlCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                SqlParameter sqlNomFournisseur = new SqlParameter("@nomFournisseur", DbType.String);
                sqlNomFournisseur.Value = textBoxNom.Text;
                SqlParameter sqlAdresseFournisseur = new SqlParameter("@adresseFournisseur", DbType.String);
                sqlAdresseFournisseur.Value = textBoxAdresse.Text;
                SqlParameter sqlCpFournisseur = new SqlParameter("@cpFournisseur", DbType.String);
                sqlCpFournisseur.Value = textBoxCP.Text;
                SqlParameter sqlVilleFournisseur = new SqlParameter("@villeFournisseur", DbType.String);
                sqlVilleFournisseur.Value = textBoxVille.Text;

                SqlParameter[] sqlParams = new SqlParameter[] { sqlCodeFournisseur, sqlNomFournisseur, sqlAdresseFournisseur,
            sqlCpFournisseur, sqlVilleFournisseur };

                sqlCommande.Parameters.AddRange(sqlParams);
                string strSql = "UPDATE fournisseur " +
                                "SET fournisseur_nom =@nomFournisseur, fournisseur_adresse=@adresseFournisseur, fournisseur_cp=@cpFournisseur, fournisseur_ville=@villeFournisseur "+
                                "WHERE fournisseur_id =@codeFournisseur ";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                int sqlNbLignesAffectees = sqlCommande.ExecuteNonQuery();

                if (sqlNbLignesAffectees == 1)
                {
                    MessageBox.Show("Modification effectuée");
      

                    foreach (KeyValuePair<int, string> item in listeFournisseur)
                    {
                        if (item.Key == Int32.Parse(sqlCodeFournisseur.Value.ToString()))
                        {
                            comboBoxListeFournisseur.SelectedItem = item;
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("Modification impossible");
                MessageBox.Show(se.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            bool nomIsOk = Verification.ValidNom(textBoxNom.Text);
            bool villeIsok = Verification.ValidNom(textBoxVille.Text);
            bool cpIsOk = Verification.ValidCP(textBoxCP.Text);


            if (textBoxNom.TextLength>0 && textBoxAdresse.TextLength > 0 && textBoxCP.TextLength > 0 && textBoxVille.TextLength > 0 && nomIsOk && villeIsok && cpIsOk)
            {
                buttonAjouter.Enabled = true;
            }
            else
            {
                buttonAjouter.Enabled = false;
            }
        }
    }

}