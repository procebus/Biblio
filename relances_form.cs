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
    public partial class relances_form : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlListAboRelance, sqlRelancer,sqlCompleteChamp,sqlResilierAbo;
        SqlDataReader sqlRrd_ListAboRelance, sqlRdr_CompleteChamp;
        DateTime datedujour = DateTime.Now;
     
        
        public relances_form()
        {
            InitializeComponent();
        }

        private void bt_relancer_Click(object sender, EventArgs e)
        {
            try
            {
                string str_relancerAbo = "update Relance set nbrRelance = (nbrRelance+1), DateRelance = CURRENT_TIMESTAMP where IdAbo = '"+ tb_idAbo.Text + "'";
                sqlRelancer = new SqlCommand(str_relancerAbo, sqlConnect);
                sqlRelancer.ExecuteNonQuery();
                listBox_Code.Items.Clear();
                lb_abo.Items.Clear();

            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void relances_form_Load(object sender, EventArgs e)
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

        private void chargerlistAboRelance(int nbre)
        {
            try
            {
                sqlListAboRelance = new SqlCommand();
                sqlListAboRelance.Connection = sqlConnect;
                sqlListAboRelance.CommandType = CommandType.StoredProcedure;
                sqlListAboRelance.CommandText = "listAboREl";
                SqlParameter nbre_rel = new SqlParameter("@nbre", SqlDbType.Int);
                nbre_rel.Value = nbre;
                sqlListAboRelance.Parameters.Add(nbre_rel);
                sqlRrd_ListAboRelance = sqlListAboRelance.ExecuteReader();
                while (sqlRrd_ListAboRelance.Read())
                {
                    lb_abo.Items.Add(sqlRrd_ListAboRelance["prenomAbo"].ToString() + " " + sqlRrd_ListAboRelance["nomAbo"].ToString());
                    listBox_Code.Items.Add(sqlRrd_ListAboRelance["Code"].ToString());
                }
                sqlRrd_ListAboRelance.Close();
               


            }
            catch (Exception EX)
            {
                
                MessageBox.Show(EX.Message);
            }
        
        }

        private void cb_relances_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_relances.SelectedIndex != -1)
                {
                    if ((string)cb_relances.Items[cb_relances.SelectedIndex] == "1")
                    {
                        listBox_Code.Items.Clear();
                        lb_abo.Items.Clear();
                        chargerlistAboRelance(1);

                    }
                    if ((string)cb_relances.Items[cb_relances.SelectedIndex] == "2")
                    {
                        listBox_Code.Items.Clear();
                        lb_abo.Items.Clear();
                        chargerlistAboRelance(2);
                    }
                    if ((string)cb_relances.Items[cb_relances.SelectedIndex] == "3")
                    {
                        listBox_Code.Items.Clear();
                        lb_abo.Items.Clear();
                        chargerlistAboRelance(3);
                    }
                }
            }
            catch (Exception EX)
            {
                
                MessageBox.Show(EX.Message);
            }
        }

        private void lb_abo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlCompleteChamp = new SqlCommand();
                sqlCompleteChamp.Connection = sqlConnect;
                sqlCompleteChamp.CommandType = CommandType.StoredProcedure;
                sqlCompleteChamp.CommandText = "AffEmpruntbyCode";
                SqlParameter code_rel = new SqlParameter("@code", SqlDbType.VarChar);
                code_rel.Value = listBox_Code.Items[lb_abo.SelectedIndex].ToString();                
                sqlCompleteChamp.Parameters.Add(code_rel);
                sqlRdr_CompleteChamp = sqlCompleteChamp.ExecuteReader();
                while (sqlRdr_CompleteChamp.Read())
                {
                    tb_dateEmp.Text = sqlRdr_CompleteChamp["dateEmp"].ToString();
                    tb_livreEmp.Text = sqlRdr_CompleteChamp["titLiv"].ToString();
                    tb_idAbo.Text = sqlRdr_CompleteChamp["idAbo"].ToString();
                    
                }
                sqlRdr_CompleteChamp.Close();



            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void bt_resiliation_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL_resilierAbo = "delete from abonne where idAbo = " + tb_idAbo.Text + "";
                sqlResilierAbo = new SqlCommand(strSQL_resilierAbo, sqlConnect);


                DialogResult confirm_diag = MessageBox.Show(
                                            "voulez-vous vraiment résilier l'abonné ?",
                                            "Confirmation de création",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                if (confirm_diag == DialogResult.Yes)
                {
                    sqlResilierAbo.ExecuteNonQuery();
                    listBox_Code.Items.Clear();
                    lb_abo.Items.Clear();

                }
            }
            catch (Exception Ex)
            {
                
                MessageBox.Show(Ex.Message);
            }
            
        }
    }
}
