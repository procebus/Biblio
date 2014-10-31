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
    public partial class login_frm : Form
    {

        SqlConnection sqlConnect;
        SqlCommand sqlVerifLogin;
        //SqlDataReader a;
        DateTime datedujour = DateTime.Now;

        public login_frm()
        {
            InitializeComponent();
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            try
            {
                sqlVerifLogin = new SqlCommand();
                sqlVerifLogin.Connection = sqlConnect;
                sqlVerifLogin.CommandType = CommandType.StoredProcedure;
                sqlVerifLogin.CommandText = "VerifLogin";

                SqlParameter loginsaisi = new SqlParameter("@login", SqlDbType.VarChar);
                loginsaisi.Value = tbidentifiant.Text;
                sqlVerifLogin.Parameters.Add(loginsaisi);

                SqlParameter pwdsaisi = new SqlParameter("@password", SqlDbType.VarChar);
                pwdsaisi.Value = tbPwd.Text;
                sqlVerifLogin.Parameters.Add(pwdsaisi);

                SqlParameter result = new SqlParameter("@n", SqlDbType.Int);
                result.Direction = ParameterDirection.Output;
                sqlVerifLogin.Parameters.Add(result);

                SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
                id.Direction = ParameterDirection.Output;
                sqlVerifLogin.Parameters.Add(id);



                sqlVerifLogin.ExecuteNonQuery();
                int n = (int)sqlVerifLogin.Parameters["@n"].Value;

               // MessageBox.Show(n.ToString());



                if (n == 1)
                {
                    if (tbidentifiant.Text == "admin")
                    {
                        espaceAdmin_form espaceAdm_feuille = new espaceAdmin_form();
                        espaceAdm_feuille.MdiParent = this.ParentForm;
                        espaceAdm_feuille.Show();
                        this.Close();
                       
                    }
                    else
                    {
                        ((main_Form)MdiParent).Identifiant = sqlVerifLogin.Parameters["@id"].Value.ToString(); ;
                       
                        espacePerso_form espacePerso = new espacePerso_form();
                        espacePerso.MdiParent = this.ParentForm;
                        espacePerso.Show();
                        this.Close();

                    }


                }


                else
                {
                    errorProvider1.SetError(tbPwd, "Mot de passe Incorrecte");
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void login_frm_Load(object sender, EventArgs e)
        {
            ((main_Form)MdiParent).LoginToolStripMenuItem.Enabled = false;
            
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

        private void login_frm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        //private void login_frm_Load(object sender, EventArgs e)
        //{
        //    tbidentifiant.Focus();
        //    ((main_Form)MdiParent).EtatConnect = true;

        //}

        //private void login_frm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    ((main_Form)MdiParent).EtatConnect = false;
        //}

    }
}
