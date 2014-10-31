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
    public partial class espacePerso_form : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlnbrRelance,sqlNOM;
        SqlDataReader sqlRde_nbrRelance,sqlRde_NOM;
        DateTime datedujour = DateTime.Now;

        
        public espacePerso_form(int a, int b)
        {
            InitializeComponent();
            a = this.Location.X;
            b = this.Location.Y;
            
            
        }
        public espacePerso_form()
        {
            InitializeComponent();
           


        }
        empAbo_form mesemp_feuille;
        private void button2_Click(object sender, EventArgs e)
        {
            if (mesemp_feuille == null || mesemp_feuille.IsHandleCreated == false)
            {
                mesemp_feuille = new empAbo_form();
                mesemp_feuille.MdiParent = this.ParentForm;
                mesemp_feuille.Show(); 
            }
        }
        catalogue_form catalogue_feuille;
        private void button1_Click(object sender, EventArgs e)
        {
            if (catalogue_feuille == null || catalogue_feuille.IsHandleCreated == false)
            {
                catalogue_feuille = new catalogue_form();
                catalogue_feuille.MdiParent = this.ParentForm;
                catalogue_feuille.Show(); 
            }
           
        }

        private void espacePerso_form_Load(object sender, EventArgs e)
        {
            lb_id.Text = ((main_Form)MdiParent).Identifiant;

            try
            {
                sqlConnect = new SqlConnection();
                ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["bibliothèque001.Properties.Settings.bibliothequeConnectionString"];
                if (oConfig != null)
                {
                    sqlConnect.ConnectionString = oConfig.ConnectionString;
                    sqlConnect.Open();


                }
                string strSQL_affnbreRelance = string.Format(" select nbrRelance from Relance where idAbo = {0} ", lb_id.Text);
                sqlnbrRelance = new SqlCommand(strSQL_affnbreRelance, sqlConnect);
                sqlRde_nbrRelance = sqlnbrRelance.ExecuteReader();
                while (sqlRde_nbrRelance.Read())
                {
                    if (sqlRde_nbrRelance["nbrRelance"] != null)
                    {
                        lb_relances.Text = string.Format("Vous avez {0} relance(s)", sqlRde_nbrRelance["nbrRelance"].ToString());
                    }
                   
                }
                sqlRde_nbrRelance.Close();

                string strSQL_NOM = string.Format("select nomAbo,prenomAbo from abonne where idAbo={0}", lb_id.Text);
                sqlNOM = new SqlCommand(strSQL_NOM,sqlConnect);
                sqlRde_NOM = sqlNOM.ExecuteReader();
                while (sqlRde_NOM.Read())
                {
                    lb_abonne.Text = sqlRde_NOM["prenomAbo"].ToString() + " " + sqlRde_NOM["nomAbo"].ToString();
                }
                sqlRde_NOM.Close();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            } 
           
        }

        private void bt_decnx_Click(object sender, EventArgs e)
        {
            
            login_frm login_feuille = new login_frm();
            login_feuille.MdiParent = this.ParentForm;
            login_feuille.Show();
            this.Close();
        }

        private void bt_affRelance_Click(object sender, EventArgs e)
        {
            


        }

        private void lb_abonne_Click(object sender, EventArgs e)
        {

        }

    }
}
