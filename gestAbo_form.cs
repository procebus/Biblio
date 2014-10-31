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

namespace bibliothèque001
{
    public partial class gestAbo_form : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlAffAbo,sqlSuppAbo,sqlRemplirCases,sqlModifAbo;
        SqlDataReader sqlRdr_affAbo,sqlRdr_remplirCases;
        DateTime date_jour = DateTime.Now;
        


        public gestAbo_form()
        {
            InitializeComponent();
        }

        private void gestAbo_form_Load(object sender, EventArgs e)
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

                chargerList();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_resiliation_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQLSuppAbo = "delete from abonne where idAbo = '" + tb_codeAbo.Text + "'";
                sqlSuppAbo = new SqlCommand(strSQLSuppAbo, sqlConnect);
                DialogResult confirm_diag = MessageBox.Show(
                                            "voulez-vous vraiment supprimer l'abonné " + tb_prenom.Text + " " + tb_nom.Text + "?",
                                            "Confirmation de suppression",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                if (confirm_diag == DialogResult.Yes)
                {
                    sqlSuppAbo.ExecuteNonQuery();
                    listView_abo.Items.Clear();
                    chargerList();

                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private void lb_abo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView_abo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void listView_abo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {

                string strSQLRemplirCases = "select * from abonne where idAbo ='" + listView_abo.SelectedItems[0].Text + "'";
                sqlRemplirCases = new SqlCommand(strSQLRemplirCases, sqlConnect);
                sqlRdr_remplirCases = sqlRemplirCases.ExecuteReader();
                if (listView_abo.SelectedItems.Count > 0)
                {
                    while (sqlRdr_remplirCases.Read())
                    {
                        tb_codeAbo.Text = sqlRdr_remplirCases["idAbo"].ToString();
                        tb_nom.Text = sqlRdr_remplirCases["nomAbo"].ToString();
                        tb_prenom.Text = sqlRdr_remplirCases["prenomAbo"].ToString();
                        tb_tel.Text = sqlRdr_remplirCases["telAbo"].ToString();
                        tb_date.Text = sqlRdr_remplirCases["dateArrAbo"].ToString();
                    }
                    sqlRdr_remplirCases.Close(); 
                }


            }
            catch (Exception Ex)
            {

                //throw;
                MessageBox.Show(Ex.Message);
            }
        }

        private void chargerList()
        {
            try
            {
                string strSQLAffAbos = "select * from abonne";
                sqlAffAbo = new SqlCommand(strSQLAffAbos, sqlConnect);
                sqlRdr_affAbo = sqlAffAbo.ExecuteReader();
                string[] arr = new string[2];
                ListViewItem itm;
                while (sqlRdr_affAbo.Read())
                {

                    arr[0] = sqlRdr_affAbo["idAbo"].ToString();
                    arr[1] = sqlRdr_affAbo["prenomAbo"].ToString() + " " + sqlRdr_affAbo["nomAbo"].ToString();
                    itm = new ListViewItem(arr);
                    listView_abo.Items.Add(itm);
                }
                sqlRdr_affAbo.Close();
            }
            catch (Exception Ex)
            {
                
                 MessageBox.Show(Ex.Message);
            }
        
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL_modifAbo = string.Format("update abonne set telAbo ={0} where idAbo = {1}", tb_tel.Text, tb_codeAbo.Text);
                sqlModifAbo = new SqlCommand(strSQL_modifAbo, sqlConnect);

                DialogResult confirm_diag = MessageBox.Show(
                                            "voulez-vous vraiment modifier les information sur l'abonné " + tb_prenom.Text + " " + tb_nom.Text + "?",
                                            "Confirmation de modification",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                if (confirm_diag == DialogResult.Yes)
                {
                    sqlModifAbo.ExecuteNonQuery();
                    listView_abo.Items.Clear();
                    chargerList();

                }
            }
            catch (Exception Ex)
            {
                
                MessageBox.Show(Ex.Message);
            }
           

        }
    }
}
