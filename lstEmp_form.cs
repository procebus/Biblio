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
    public partial class lstEmp_form : Form
    {

        SqlConnection sqlConnect;
        SqlCommand sqlListemprunts,sqlRelancer;
        SqlDataReader sqlRrd_Listemprunts;
        DateTime datedujour = DateTime.Now;
        
        public lstEmp_form()
        {
            InitializeComponent();
        }

        private void lstEmp_form_Load(object sender, EventArgs e)
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
                chargerlistEmp();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            } 


        }

        private void chargerlistEmp()
        {

            try
            {
               // string strSQL_afficherListEmp = "select * from listEmprunts";
                string strSQL_afficherListEmp = string.Format("select * from dbo.Vue_listedesempruntencours");
                sqlListemprunts = new SqlCommand(strSQL_afficherListEmp, sqlConnect);
                sqlRrd_Listemprunts = sqlListemprunts.ExecuteReader();
                string[] arr = new string[4];
                ListViewItem itm;
                while (sqlRrd_Listemprunts.Read())
                {
                    arr[0] = sqlRrd_Listemprunts["Code"].ToString();
                    arr[1] = sqlRrd_Listemprunts["prenomAbo"].ToString() + " " + sqlRrd_Listemprunts["nomAbo"].ToString();
                    arr[2] = sqlRrd_Listemprunts["dateEmp"].ToString();
                    arr[3] = sqlRrd_Listemprunts["titLiv"].ToString();
                    itm = new ListViewItem(arr);
                    listView_emp.Items.Add(itm);
                    
                }

                sqlRrd_Listemprunts.Close();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        
        
        
        
        }



        private void bt_quit_Click(object sender, EventArgs e)
        {
            
            espaceAdmin_form espaceAdm_feuille = new espaceAdmin_form();
            espaceAdm_feuille.MdiParent = this.ParentForm;
            espaceAdm_feuille.Show();
            this.Close();
        }

        newEmp_form nouvelEmp_feuille;
        private void bt_newEmp_Click(object sender, EventArgs e)
        {
            if (nouvelEmp_feuille == null || nouvelEmp_feuille.IsHandleCreated == false)
            {
                nouvelEmp_feuille = new newEmp_form();
                nouvelEmp_feuille.MdiParent = this.ParentForm;
                nouvelEmp_feuille.Show(); 
            }
        }

        rechEmp_form recherchEmp_feuille;
        private void bt_rechEmp_Click(object sender, EventArgs e)
        {
            if (recherchEmp_feuille == null || recherchEmp_feuille.IsHandleCreated == false)
            {
                recherchEmp_feuille = new rechEmp_form();
                recherchEmp_feuille.MdiParent = this.ParentForm;
                recherchEmp_feuille.Show(); 
            }
        }
        retourEmp_form enregRetour_feuille;
        private void bt_enregRetour_Click(object sender, EventArgs e)
        {
            if (enregRetour_feuille == null || enregRetour_feuille.IsHandleCreated == false)
            {
                enregRetour_feuille = new retourEmp_form();
                enregRetour_feuille.MdiParent = this.ParentForm;
                enregRetour_feuille.Show(); 
            }
        }

        private void bt_relAbo_Click(object sender, EventArgs e)
        {
            try
            {
                  //string str_relancerAbo = "update Relance set nbrRelance = (nbrRelance+1), DateRelance = '" + datedujour.ToString() + "'where Code = " + listView_emp.SelectedItems[0].Text + "  join emprunt on emprunt.idAbo= Relance.IdAbo ";
                    string str_relancerAbo = "update Relance set nbrRelance = (nbrRelance+1), DateRelance = CURRENT_TIMESTAMP where IdAbo = (select IdAbo from emprunt where Code = '" + listView_emp.SelectedItems[0].Text + "')";
                    sqlRelancer = new SqlCommand(str_relancerAbo, sqlConnect);
                    sqlRelancer.ExecuteNonQuery();
                    listView_emp.Items.Clear();
                    chargerlistEmp();
                    
                
            }
            catch (Exception EX)
            {
                
               MessageBox.Show(EX.Message);
            }
        }
        relances_form relances_feuille;
        private void bt_relances_Click(object sender, EventArgs e)
        {
            if (relances_feuille == null || relances_feuille.IsHandleCreated == false)
            {
                relances_feuille = new relances_form();
                relances_feuille.MdiParent = this.ParentForm;
                relances_feuille.Show(); 
            }
        }

        private void bt_recharger_Click(object sender, EventArgs e)
        {
            listView_emp.Items.Clear();
            chargerlistEmp();
        }

        private void bt_decnx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
