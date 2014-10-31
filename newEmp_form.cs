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
    public partial class newEmp_form : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlListAbo, sqlChargeInfoAbo, sqlListLivre, sqlChargeInfolivre,sqlInsertEmp;
        SqlDataReader sqlRrd_listAbo, sqlRdr_ChargeInfoAbo, sqlRdr_listLivre, sqlRdr_ChargeInfolivre;
        DateTime datedujour = DateTime.Now;


        public newEmp_form()
        {
            InitializeComponent();
            tb_DateEmp.Text = datedujour.ToString();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newEmp_form_Load(object sender, EventArgs e)
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
                chargelistAbo();
                chargelistLivre();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            } 
        }

        //selection de l'abonné

        private void chargelistAbo()
        {
            try
            {

                string strSQL_chargelistAbo = "select idAbo,nomAbo,prenomAbo from dbo.Vue_listedesempruntencours ";
                sqlListAbo = new SqlCommand(strSQL_chargelistAbo, sqlConnect);
                sqlRrd_listAbo = sqlListAbo.ExecuteReader();
                while (sqlRrd_listAbo.Read())
                {
                    cb_abo.Items.Add(sqlRrd_listAbo["prenomAbo"].ToString() + " " + sqlRrd_listAbo["nomAbo"].ToString());
                    comboBox_idAbo.Items.Add(sqlRrd_listAbo["idAbo"].ToString());
                }
                sqlRrd_listAbo.Close();

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void cb_abo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_abo.SelectedIndex != -1)
                {

                    string strSQL_ChargeInfoAbo = "select * from abonne where idAbo = " + comboBox_idAbo.Items[cb_abo.SelectedIndex] + "";
                    sqlChargeInfoAbo = new SqlCommand(strSQL_ChargeInfoAbo, sqlConnect);
                    sqlRdr_ChargeInfoAbo = sqlChargeInfoAbo.ExecuteReader();
                    while (sqlRdr_ChargeInfoAbo.Read())
                    {
                        tb_idAbo.Text = sqlRdr_ChargeInfoAbo["idAbo"].ToString();
                    }
                    sqlRdr_ChargeInfoAbo.Close();
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        //selection du livre

        private void chargelistLivre()
        {
            try
            {

                string strSQL_chargelistLivre = "select * from livre where etatLiv ='dispo'";
                sqlListLivre = new SqlCommand(strSQL_chargelistLivre, sqlConnect);
                sqlRdr_listLivre = sqlListLivre.ExecuteReader();
                while (sqlRdr_listLivre.Read())
                {
                    comboBox_livre.Items.Add(sqlRdr_listLivre["titliv"].ToString());
                    comboBox_idlivre.Items.Add(sqlRdr_listLivre["idLiv"].ToString());
                }
                sqlRdr_listLivre.Close();

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void comboBox_livre_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (comboBox_livre.SelectedIndex != -1)
                {

                    string strSQL_ChargeInfoLivre = "select * from livre where idLiv = " + comboBox_idlivre.Items[comboBox_livre.SelectedIndex] + "";
                    sqlChargeInfolivre = new SqlCommand(strSQL_ChargeInfoLivre, sqlConnect);
                    sqlRdr_ChargeInfolivre = sqlChargeInfolivre.ExecuteReader();
                    while (sqlRdr_ChargeInfolivre.Read())
                    {
                        tb_etatLiv.Text = sqlRdr_ChargeInfolivre["etatLiv"].ToString();
                        tb_idLiv.Text = sqlRdr_ChargeInfolivre["idLiv"].ToString();
                    }
                    sqlRdr_ChargeInfolivre.Close();
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        //ajout de l'emprunt



        private void bt_Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_livre.Text != "")
                {
                    if (cb_abo.Text != "")
                    {
                        if (tb_codeEmp.Text != "")
                        {
                            string strSQL_ajoutEmp = "insert into emprunt (dateEmp,IdAbo,IdLiv,Code) values (CURRENT_TIMESTAMP,"+tb_idAbo.Text+","+tb_idLiv.Text+",'"+tb_codeEmp.Text+"')";
                            sqlInsertEmp = new SqlCommand(strSQL_ajoutEmp, sqlConnect);

                            DialogResult confirm_diag = MessageBox.Show(
                                        "Confirmer l'emprunt de " + comboBox_livre.Text +" par "+ cb_abo.Text +"?",
                                        "Confirmation de l'emprunt",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2);
                            if (confirm_diag == DialogResult.Yes)
                            {
                                sqlInsertEmp.ExecuteNonQuery();
                                tb_codeEmp.Text = "";
                                tb_DateEmp.Text = datedujour.ToString();
                                cb_abo.Text = "";
                                comboBox_livre.Text = "";
                                tb_etatLiv.Text = "";
                            }
                           
                        }
                        else
                        {
                            errorProvider1.SetError(tb_codeEmp, "Attribuez un Code");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(cb_abo, "Sélectionnez un abonné");
                    }
                }
                else
                {
                    errorProvider1.SetError(comboBox_livre,"Sélectionnez un livre");
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }




    }
}
