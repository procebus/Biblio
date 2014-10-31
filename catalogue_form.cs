using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace bibliothèque001
{
    public partial class catalogue_form : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlListAuteur, sqlListEditeur, sqlListTheme, sql_affbyTheme, sql_affbyAuteur, sql_affbyEditeur;
        SqlDataReader sqlRdr_listAuteur, sqlRdr_listEditeur, sqlRdr_listtheme, sqlRdr_affbyTheme, sqlRdr_affbyAuteur, sqlRdr_affbyEditeur;
        DateTime datedujour = DateTime.Now;
        
        public catalogue_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            espacePerso_form monespace_feuille = new espacePerso_form();
            monespace_feuille.MdiParent = this.ParentForm;
            monespace_feuille.Show();
            this.Close();
        }

        private void catalogue_form_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new SqlConnection();
                ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["bibliothèque001.Properties.Settings.bibliothequeConnectionString"];
                if (oConfig != null)
                {
                    sqlConnect.ConnectionString = oConfig.ConnectionString;
                    sqlConnect.Open();


                }
                


            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            } 
        }

        private void chargelistAuteur()
        {
            try
            {

                string strSQL_chargelistAuteur = "select * from auteur";
                sqlListAuteur = new SqlCommand(strSQL_chargelistAuteur, sqlConnect);
                sqlRdr_listAuteur = sqlListAuteur.ExecuteReader();
                while (sqlRdr_listAuteur.Read())
                {
                    
                    cb_auteur.Items.Add(sqlRdr_listAuteur["prenomAuteur"].ToString() + " " + sqlRdr_listAuteur["nomAuteur"].ToString());
                    cb_idAut.Items.Add(sqlRdr_listAuteur["idAuteur"].ToString());
                }
                sqlRdr_listAuteur.Close();

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void chargelistEditeur()
        {

            try
            {
                string strSQL_chargelistEditeur = "select * from editeur";
                sqlListEditeur = new SqlCommand(strSQL_chargelistEditeur, sqlConnect);
                sqlRdr_listEditeur = sqlListEditeur.ExecuteReader();
                while (sqlRdr_listEditeur.Read())
                {
                    
                    cb_editeur.Items.Add(sqlRdr_listEditeur["nomEditeur"].ToString());
                    cb_idediteur.Items.Add(sqlRdr_listEditeur["idEditeur"].ToString());
                }
                sqlRdr_listEditeur.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }


        }

        private void chargelistTheme()
        {

            try
            {

                string strSQL_chargelistTheme = "select * from theme";
                sqlListTheme = new SqlCommand(strSQL_chargelistTheme, sqlConnect);
                sqlRdr_listtheme = sqlListTheme.ExecuteReader();
                while (sqlRdr_listtheme.Read())
                {
                    
                    cb_theme.Items.Add(sqlRdr_listtheme["nomTheme"].ToString());
                    cb_idtheme.Items.Add(sqlRdr_listtheme["idTheme"].ToString());

                }
                sqlRdr_listtheme.Close();


            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }


        }

        private void cb_theme_DropDown(object sender, EventArgs e)
        {
            if (cb_theme.Items.Count == 0)
            {
                chargelistTheme();
            }
        }

        private void cb_auteur_DropDown(object sender, EventArgs e)
        {
            if (cb_auteur.Items.Count == 0)
            {
                chargelistAuteur();
            }
        }

        private void cb_editeur_DropDown(object sender, EventArgs e)
        {
            if (cb_editeur.Items.Count == 0)
            {
                chargelistEditeur();
            }
        }

       

        private void cb_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_theme.SelectedIndex != -1)
                {
                    string strSQl_affbyTheme = string.Format("select titLiv from livre where IdTheme = {0}", cb_idtheme.Items[cb_theme.SelectedIndex]);
                    sql_affbyTheme = new SqlCommand(strSQl_affbyTheme, sqlConnect);
                    sqlRdr_affbyTheme = sql_affbyTheme.ExecuteReader();
                    listBoxlivres.Items.Clear();
                    while (sqlRdr_affbyTheme.Read())
                    {
                        listBoxlivres.Items.Add(sqlRdr_affbyTheme["titLiv"].ToString());
                    }
                    sqlRdr_affbyTheme.Close();

                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void cb_auteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_auteur.SelectedIndex != -1)
                {
                    string strSQl_affbyAuteur = string.Format("select titLiv from livre where Idauteur = {0}", cb_idAut.Items[cb_auteur.SelectedIndex]);
                    sql_affbyAuteur = new SqlCommand(strSQl_affbyAuteur, sqlConnect);
                    sqlRdr_affbyAuteur = sql_affbyAuteur.ExecuteReader();
                    listBoxlivres.Items.Clear();
                    while (sqlRdr_affbyAuteur.Read())
                    {
                        listBoxlivres.Items.Add(sqlRdr_affbyAuteur["titLiv"].ToString());
                    }
                    sqlRdr_affbyAuteur.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cb_editeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_editeur.SelectedIndex != -1)
                {
                    string strSQl_affbyEditeur = string.Format("select titLiv from livre where IdEditeur = {0}", cb_idediteur.Items[cb_editeur.SelectedIndex]);
                    sql_affbyEditeur = new SqlCommand(strSQl_affbyEditeur, sqlConnect);
                    sqlRdr_affbyEditeur = sql_affbyEditeur.ExecuteReader();
                    listBoxlivres.Items.Clear();
                    while (sqlRdr_affbyEditeur.Read())
                    {
                        listBoxlivres.Items.Add(sqlRdr_affbyEditeur["titLiv"].ToString());
                    }
                    sqlRdr_affbyEditeur.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
