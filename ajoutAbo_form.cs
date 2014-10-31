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
    public partial class ajoutAbo_form : Form
    {

        SqlConnection sqlConnect;
        SqlCommand sqlAjoutAbo;
        
        public ajoutAbo_form()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajoutAbo_form_Load(object sender, EventArgs e)
        {
            try
            {

                DateTime date_jour = DateTime.Now;
                tb_date.Text = date_jour.ToString();


                
                sqlConnect = new SqlConnection();
                ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["bibliothèque001.Properties.Settings.bibliothequeConnectionString"];
                if (oConfig != null)
                {
                    sqlConnect.ConnectionString = oConfig.ConnectionString;
                    sqlConnect.Open();

                }
            }
            catch (Exception)
            {
                
                //throw;
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                string strSqlAjoutAbo = string.Format("insert into dbo.abonne(nomAbo,prenomAbo,dateArrAbo,telAbo) values('{0}','{1}',CURRENT_TIMESTAMP,{2})",tb_nom.Text, tb_prenom.Text,tb_tel.Text);
                sqlAjoutAbo = new SqlCommand(strSqlAjoutAbo, sqlConnect);
                int n = sqlAjoutAbo.ExecuteNonQuery();
                MessageBox.Show(n.ToString());
                if (n == 1)
                {
                    MessageBox.Show("ajout de l'abonné effectué");
                    
                }
                tb_tel.Text = "";
                tb_nom.Text = "";
                tb_prenom.Text = "";
                
                
            }
            catch (Exception M)
            {

                MessageBox.Show(M.Message);
            }

        }

        private void tb_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
                errorProvider1.SetError(tb_nom, "Vous ne devez utiliser que des caractères alphabétiques");
                //Console.Beep();
                
            }
            else
            {
                errorProvider1.SetError(tb_nom, "");
                
            }
        }

        private void tb_prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
                errorProvider1.SetError(tb_prenom, "Vous ne devez utiliser que des caractères alphabétiques");
                //Console.Beep();

            }
            else
            {
                errorProvider1.SetError(tb_prenom, "");

            }
        }

        private void tb_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(tb_tel, "Vous devez indiquez un téléphone composé uniquement de chiffres");
               
            }
            else
            {
                errorProvider1.SetError(tb_tel, "");
               
            }
        }

        private void tb_tel_Validating(object sender, CancelEventArgs e)
        {
            if (tb_tel.Text.Length != 10)
            {
                errorProvider1.SetError(tb_tel, "Vous devez indiquer un téléphone composé de 10 chiffres");
            }
            else
            {
                errorProvider1.SetError(tb_tel, "");
                
            }
        }
    }
}
