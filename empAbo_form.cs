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
    public partial class empAbo_form : Form
    {
        
        SqlConnection sqlConnect;
        SqlCommand sqlmesEmp;
        SqlDataReader sqlRdr_mesEmp;
        DateTime date_jour = DateTime.Now;
        
        public empAbo_form()
        {
            InitializeComponent();
           
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empAbo_form_Load(object sender, EventArgs e)
        {
            lbId.Text = ((main_Form)MdiParent).Identifiant; 
            try
            {

                sqlConnect = new SqlConnection();
                ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["bibliothèque001.Properties.Settings.bibliothequeConnectionString"];
                if (oConfig != null)
                {
                    sqlConnect.ConnectionString = oConfig.ConnectionString;
                    sqlConnect.Open();

                }

                chargerListMesEmprunts();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        
        }
        private void chargerListMesEmprunts()
        {
            try
            {
                string strSQL_mesemprunts = string.Format("select titLiv,dateEmp,dateReEmp from emprunt E join livre L on l.idLiv=E.IdLiv where E.IdAbo={0}", lbId.Text);
                sqlmesEmp = new SqlCommand(strSQL_mesemprunts, sqlConnect);
                sqlRdr_mesEmp = sqlmesEmp.ExecuteReader();
                string[] arr = new string[3];
                ListViewItem itm;
                while (sqlRdr_mesEmp.Read())
                {

                    arr[0] = sqlRdr_mesEmp["titLiv"].ToString();
                    arr[1] = sqlRdr_mesEmp["dateEmp"].ToString();
                    if (sqlRdr_mesEmp["dateReEmp"] != null)
                    {
                        arr[2] = sqlRdr_mesEmp["dateReEmp"].ToString(); 
                    }
                    else
                    {
                        arr[2] = "";
                    }
                    
                    itm = new ListViewItem(arr);
                    listView_mesEmprunts.Items.Add(itm);
                }
                sqlRdr_mesEmp.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }


    }
}
