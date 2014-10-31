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
    public partial class retourEmp_form : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlEmprunteurs,sqlLivreempruntesByAbo,sqlRetourEmp,sqlRetourLivre;
        SqlDataReader sqlRrd_Emprunteurs, sqlRrd_LivreempruntesByAbo;
        DateTime datedujour = DateTime.Now;
        
        public retourEmp_form()
        {
            InitializeComponent();
            tb_dateRetour.Text = datedujour.ToString();
        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void retourEmp_form_Load(object sender, EventArgs e)
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

        private void cb_abo_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (cb_abo.Items.Count == 0)
                {
                    string strSQL_emprunteurs = "select distinct A.idAbo,nomAbo,prenomAbo from abonne A join emprunt E on A.idAbo = E.IdAbo join livre L on L.idLiv = E.IdLiv where etatLiv = 'emprunt'";
                    sqlEmprunteurs = new SqlCommand(strSQL_emprunteurs, sqlConnect);
                    sqlRrd_Emprunteurs = sqlEmprunteurs.ExecuteReader();
                    while (sqlRrd_Emprunteurs.Read())
                    {
                        cb_abo.Items.Add(sqlRrd_Emprunteurs["prenomAbo"].ToString() + " " + sqlRrd_Emprunteurs["nomAbo"].ToString());
                        comboBox_idAo.Items.Add(sqlRrd_Emprunteurs["idAbo"].ToString());
                    }
                    sqlRrd_Emprunteurs.Close();
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            } 
        }

        private void cb_abo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_abo.SelectedIndex != -1)
                {
                    string strSQL_LivresempruntesByAbo = string.Format("select L.idLiv,titLiv from livre L join emprunt E on L.idLiv = E.IdLiv where E.IdAbo = {0} and etatLiv = 'emprunt'", comboBox_idAo.Items[cb_abo.SelectedIndex]);
                    sqlLivreempruntesByAbo = new SqlCommand(strSQL_LivresempruntesByAbo, sqlConnect);
                    sqlRrd_LivreempruntesByAbo = sqlLivreempruntesByAbo.ExecuteReader();
                    combobox_livres.Items.Clear();
                    combobox_idlivre.Items.Clear();
                    while (sqlRrd_LivreempruntesByAbo.Read())
                    {
                        combobox_idlivre.Items.Add(sqlRrd_LivreempruntesByAbo["idLiv"].ToString());
                        combobox_livres.Items.Add(sqlRrd_LivreempruntesByAbo["titLiv"].ToString());
                    }
                    sqlRrd_LivreempruntesByAbo.Close();
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            } 
        }

        private void bt_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL_retourEmp = string.Format("update emprunt set dateReEmp = CURRENT_TIMESTAMP where IdAbo={0} and IdLiv={1}",comboBox_idAo.Items[cb_abo.SelectedIndex],combobox_idlivre.Items[combobox_livres.SelectedIndex]);
                sqlRetourEmp = new SqlCommand(strSQL_retourEmp,sqlConnect);
                sqlRetourEmp.ExecuteNonQuery();
                string strSQL_retourLivre = string.Format("update livre set etatLiv = 'dispo' where idLiv = {0}", combobox_idlivre.Items[combobox_livres.SelectedIndex]);
                sqlRetourLivre = new SqlCommand(strSQL_retourLivre, sqlConnect);
                sqlRetourLivre.ExecuteNonQuery();
                cb_abo.Items.Clear();
                comboBox_idAo.Items.Clear();
                combobox_livres.Items.Clear();
                combobox_idlivre.Items.Clear();
    
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            } 
        }
    }
}
