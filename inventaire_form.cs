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
    public partial class inventaire_form : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlListLivreByEtat, sqlListLivre,sqlRebus,sqlDispo,sqlAffinfo;
        SqlDataReader sqlRrd_ListLivreByEtat, sqlRrd_ListLivre,sqlRrd_affinfo;
        DateTime datedujour = DateTime.Now;
        
        public inventaire_form()
        {
            InitializeComponent();
           
        }

        private void inventaire_form_Load(object sender, EventArgs e)
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
                chargelistlivre();
                
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            } 

        }

        private void chargelistLivrebyEtat(string et)
        {
            try
            { 
                
                    string strSQl_afficheLivrebyEtat = "select * from livre where etatLiv like '"+et+"'";
                    sqlListLivreByEtat = new SqlCommand(strSQl_afficheLivrebyEtat, sqlConnect);
                    sqlRrd_ListLivreByEtat = sqlListLivreByEtat.ExecuteReader();
                    listbox_livres.Items.Clear();
                    listBox_idLivre.Items.Clear();
                    while (sqlRrd_ListLivreByEtat.Read())
                    {
                        listbox_livres.Items.Add(sqlRrd_ListLivreByEtat["titLiv"].ToString());
                        listBox_idLivre.Items.Add(sqlRrd_ListLivreByEtat["idLiv"].ToString());
                    }
                    sqlRrd_ListLivreByEtat.Close();

               
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        
        
        }
        private void chargelistlivre()
        {

            string strSQl_afficheLivre = "select * from livre";
            sqlListLivre = new SqlCommand(strSQl_afficheLivre, sqlConnect);
            sqlRrd_ListLivre = sqlListLivre.ExecuteReader();

            while (sqlRrd_ListLivre.Read())
            {
                listbox_livres.Items.Add(sqlRrd_ListLivre["titLiv"].ToString());
                listBox_idLivre.Items.Add(sqlRrd_ListLivre["idLiv"].ToString());
            }
            sqlRrd_ListLivre.Close();
        
        
        }


        private void rb_emprunt_CheckedChanged(object sender, EventArgs e)
        {
            string etat = "emprunt";
            chargelistLivrebyEtat(etat);
        }

        private void rd_dispo_CheckedChanged(object sender, EventArgs e)
        {
            string etat = "dispo";
            chargelistLivrebyEtat(etat);
        }

        private void bt_rebus_Click(object sender, EventArgs e)
        {
            try
            {
                if (listbox_livres.SelectedIndex != -1)
                {
                    string strSQL_Rebus = string.Format("insert into rebus(dateRebus,IDliv) values(CURRENT_TIMESTAMP,{0})",listBox_idLivre.Items[listbox_livres.SelectedIndex]);
                    sqlRebus = new SqlCommand(strSQL_Rebus, sqlConnect);
                    DialogResult confirm_diag = MessageBox.Show(
                                            "voulez-vous vraiment mettre au rebus le livre '" + listbox_livres.Items[listbox_livres.SelectedIndex].ToString() + "' ?",
                                            "Confirmation de la mise au rebus",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                    if (confirm_diag == DialogResult.Yes)
                    {

                        sqlRebus.ExecuteNonQuery();
                        string etat = "dispo";
                        chargelistLivrebyEtat(etat);

                    }

                }
            }
            catch (Exception EX)
            {
                
                 MessageBox.Show(EX.Message);
            }
           
        }

        private void rb_rebus_CheckedChanged(object sender, EventArgs e)
        {
            string etat = "rebus";
            chargelistLivrebyEtat(etat);
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_dispo_Click(object sender, EventArgs e)
        {
            try
            {
                if (listbox_livres.SelectedIndex != -1)
                {
                    string strSQL_Dispo = string.Format("delete from rebus where IDliv = {0}", listBox_idLivre.Items[listbox_livres.SelectedIndex]);
                    sqlDispo = new SqlCommand(strSQL_Dispo, sqlConnect);
                    sqlDispo.ExecuteNonQuery();
                    string etat = "rebus";
                    chargelistLivrebyEtat(etat);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void listbox_livres_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listbox_livres.SelectedIndex != -1)
                {
                    sqlAffinfo = new SqlCommand();
                    sqlAffinfo.Connection = sqlConnect;
                    sqlAffinfo.CommandType = CommandType.StoredProcedure;
                    sqlAffinfo.CommandText = "PS_InfoDateLivre";

                    SqlParameter idlivre = new SqlParameter("@idlivre", SqlDbType.Int);
                    idlivre.Value = listBox_idLivre.Items[listbox_livres.SelectedIndex];
                    sqlAffinfo.Parameters.Add(idlivre);

                    
                    
                    if (rb_emprunt.Checked == true)
                    {
                        viderchamps();
                        sqlRrd_affinfo = sqlAffinfo.ExecuteReader();
                        while (sqlRrd_affinfo.Read())
                        {
                            tb_AboEmp.Text = sqlRrd_affinfo["prenomAbo"].ToString() + " " + sqlRrd_affinfo["nomAbo"].ToString();
                            tb_DateEdition.Text = sqlRrd_affinfo["dateEditLiv"].ToString();
                            tb_DateEmp.Text = sqlRrd_affinfo["dateEmp"].ToString();
                            tb_DateEnreg.Text = sqlRrd_affinfo["dateEngLiv"].ToString();
                            tb_Edition.Text = sqlRrd_affinfo["nomEditeur"].ToString();
                        }
                        sqlRrd_affinfo.Close();
                    }
                    if (rd_dispo.Checked == true)
                    {
                        viderchamps();
                        sqlRrd_affinfo = sqlAffinfo.ExecuteReader();
                        while (sqlRrd_affinfo.Read())
                        {
                           
                            tb_DateEdition.Text = sqlRrd_affinfo["dateEditLiv"].ToString();
                            
                            tb_DateEnreg.Text = sqlRrd_affinfo["dateEngLiv"].ToString();
                            tb_Edition.Text = sqlRrd_affinfo["nomEditeur"].ToString();
                        }
                        sqlRrd_affinfo.Close();
                    }
                    
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }
        private void viderchamps()
        {

            tb_AboEmp.Text = "";
            tb_DateEdition.Text = "";
            tb_DateEmp.Text = "";
            tb_DateEnreg.Text = "";
            tb_Edition.Text = "";
            tb_DateRebus.Text = "";
        
        }

    }
}
