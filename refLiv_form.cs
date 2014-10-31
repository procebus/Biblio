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
    public partial class refLiv_form : Form
    {
        SqlConnection sqlConnect;
        SqlCommand sqlAddAuteur, sqlListAuteur, sqlAddEditeur, sqlListEditeur, sqlremplirCaseEditeur, sqlREmplircaseAuteur, sqlListTheme, sqlRemplirCasesTheme, sqlAddTheme,sqlAjoutLivre;
        SqlDataReader sqlRdr_listAuteur, sqlRdr_listEditeur, sqlRdr_remplirCasesEditeur, sqlRdr_REmplircaseAuteur, sqlRdr_listtheme, sqlRdr_RemplirCasesTheme;
        DateTime datedujour = DateTime.Now;
        
        
        public refLiv_form()
        {
            InitializeComponent();
            groupBox_auteur.Visible = false;
            groupBox_editeur.Visible = false;
            groupBox_AjoutTheme.Visible = false;
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //connection Sql au chargement de la feuille

        private void refLiv_form_Load(object sender, EventArgs e)
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
            catch (Exception EX )
            {

                MessageBox.Show(EX.Message);
            } 
        }


        //partie Auteur 
        private void bt_ajoutAuteur_Click(object sender, EventArgs e)
        {
            tb_nomauteur.Text = "";
            tb_prenomAuteur.Text = "";
            label_ajoutAuteur.Visible = false;
            groupBox_auteur.Visible = true;
            

        }

        private void bt_validAjoutAut_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_nomauteur.Text != "" && tb_prenomAuteur.Text != "")
                {
                    string strSQL_addAuteur = "insert into auteur(nomAuteur,prenomAuteur) values('" + tb_nomauteur.Text + "','" + tb_prenomAuteur.Text + "')";
                    sqlAddAuteur = new SqlCommand(strSQL_addAuteur, sqlConnect);
                    sqlAddAuteur.ExecuteNonQuery();
                    tb_nomauteur.Text = "";
                    tb_prenomAuteur.Text = "";
                    groupBox_auteur.Visible = false;
                    label_ajoutAuteur.Visible = true;
                    combobox_auteur.Items.Clear();
                    comboBox_idAuteur.Items.Clear();
                    combobox_auteur.Text = "";
                    errorProvider1.SetError(tb_nomauteur, "");

                    chargelistAuteur();
                }
                else
                {
                    errorProvider1.SetError(tb_nomauteur, "les champs ne peuvent etre vides");

                }
            }
            catch (Exception Ex)
            {
                
                //throw;
                MessageBox.Show(Ex.Message);
            }
           
        }

        private void chargelistAuteur()
        {
            try
            {

                string strSQL_chargelistAuteur = "select * from auteur";
                sqlListAuteur = new SqlCommand(strSQL_chargelistAuteur, sqlConnect);
                sqlRdr_listAuteur = sqlListAuteur.ExecuteReader();
                while (sqlRdr_listAuteur.Read())
                {
                    combobox_auteur.Items.Add(sqlRdr_listAuteur["prenomAuteur"].ToString() + " " + sqlRdr_listAuteur["nomAuteur"].ToString());
                    comboBox_idAuteur.Items.Add(sqlRdr_listAuteur["idAuteur"].ToString());
                }
                sqlRdr_listAuteur.Close();

            }
            catch (Exception Ex)
            {
                
                MessageBox.Show(Ex.Message);
            }
        }

        private void combobox_auteur_DropDown(object sender, EventArgs e)
        {
            if (combobox_auteur.Items.Count  == 0)
            {
                chargelistAuteur();
            }
            
            
        }

        private void combobox_auteur_SelectedIndexChanged(object sender, EventArgs e)
        {
           try 
	        {	        
		         if (combobox_auteur.SelectedIndex != -1)
                    {
               
                        string strSQL_remplirCaseAuteur = "select * from auteur where idAuteur = "+ comboBox_idAuteur.Items[combobox_auteur.SelectedIndex]+ "";
                        sqlREmplircaseAuteur = new SqlCommand(strSQL_remplirCaseAuteur, sqlConnect);
                        sqlRdr_REmplircaseAuteur = sqlREmplircaseAuteur.ExecuteReader();
                        while (sqlRdr_REmplircaseAuteur.Read())
                        {
                           tb_nomauteur.Text = sqlRdr_REmplircaseAuteur["nomAuteur"].ToString();
                           tb_prenomAuteur.Text = sqlRdr_REmplircaseAuteur["prenomAuteur"].ToString();
                           tb_idAuteur.Text = sqlRdr_REmplircaseAuteur["idAuteur"].ToString();
                        }
                        sqlRdr_REmplircaseAuteur.Close();
                    }

	        }
	        catch (Exception Ex)
	        {
		
		        MessageBox.Show(Ex.Message);
	        }


           
        }

        // partie Editeur
        private void bt_ajoutEditeur_Click(object sender, EventArgs e)
        {
            
            tb_editeur.Text = "";
            groupBox_editeur.Visible = true;
            Label_ajoutEditeur.Visible = false;
        }

        private void bt_validAjourEditeur_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_editeur.Text != "")
                {
                    string strSQL_addEditeur = "insert into editeur(nomEditeur) values('" + tb_editeur.Text + "')";
                    sqlAddEditeur = new SqlCommand(strSQL_addEditeur, sqlConnect);
                    sqlAddEditeur.ExecuteNonQuery();
                    comboBox_editeur.Items.Clear();
                    comboBox_idEditeur.Items.Clear();
                    groupBox_editeur.Visible = false;
                    Label_ajoutEditeur.Visible = true;
                    tb_editeur.Text = "";
                    tb_idEditeur.Text = "";
                    comboBox_editeur.Text = "";
                    errorProvider1.SetError(tb_editeur, "");
                    chargelistEditeur();
                }
                else
                {
                    errorProvider1.SetError(tb_editeur, "le champ ne peut etre nul");
                }


            }
            catch (Exception Ex)
            {
                
                MessageBox.Show(Ex.Message);
            }
        }

        private void chargelistEditeur()
        {

            try
            {
                string strSQL_chargelistEditeur = "select * from editeur";
                sqlListEditeur = new SqlCommand(strSQL_chargelistEditeur, sqlConnect);
                sqlRdr_listEditeur = sqlListEditeur.ExecuteReader();
                while (sqlRdr_listEditeur.Read())
                {

                    comboBox_editeur.Items.Add(sqlRdr_listEditeur["nomEditeur"].ToString());
                    comboBox_idEditeur.Items.Add(sqlRdr_listEditeur["idEditeur"].ToString());
                }
                sqlRdr_listEditeur.Close();
            }
            catch (Exception Ex)
            {
                
                MessageBox.Show(Ex.Message);
            }
            
        
        }

        private void comboBox_editeur_DropDown(object sender, EventArgs e)
        {
            if (comboBox_editeur.Items.Count == 0)
            {
                chargelistEditeur();
            }
            
            
        }

        private void comboBox_editeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_editeur.SelectedIndex != -1)
                {

                    string strSQL_remplirCaseEditeur = "select * from editeur where idEditeur = " + comboBox_idEditeur.Items[comboBox_editeur.SelectedIndex] + "";
                    sqlremplirCaseEditeur = new SqlCommand(strSQL_remplirCaseEditeur, sqlConnect);
                    sqlRdr_remplirCasesEditeur = sqlremplirCaseEditeur.ExecuteReader();
                    while (sqlRdr_remplirCasesEditeur.Read())
                    {
                        tb_editeur.Text = sqlRdr_remplirCasesEditeur["nomEditeur"].ToString();
                        tb_idEditeur.Text = sqlRdr_remplirCasesEditeur["idEditeur"].ToString();
                    }

                    sqlRdr_remplirCasesEditeur.Close();

                }
            }
            catch (Exception Ex)
            {
                
               MessageBox.Show(Ex.Message);
            }
        }

       // partie Theme

        private void chargelistTheme()
        {

            try
            {

                string strSQL_chargelistTheme = "select * from theme";
                sqlListTheme = new SqlCommand(strSQL_chargelistTheme, sqlConnect);
                sqlRdr_listtheme = sqlListTheme.ExecuteReader();
                while (sqlRdr_listtheme.Read())
                {
                    comboBox_theme.Items.Add(sqlRdr_listtheme["nomTheme"].ToString());
                    comboBox_idTheme.Items.Add(sqlRdr_listtheme["idTheme"].ToString());

                }
                sqlRdr_listtheme.Close();


            }
            catch (Exception Ex)
            {
                
                MessageBox.Show(Ex.Message);
            }
            

        }

        private void comboBox_theme_DropDown(object sender, EventArgs e)
        {
            if (comboBox_theme.Items.Count == 0)
            {
                chargelistTheme();
            }
        }

        private void comboBox_theme_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string strSQL_remplirCasesTheme = "select * from theme where idTheme = " + comboBox_idTheme.Items[comboBox_theme.SelectedIndex] + "";
                sqlRemplirCasesTheme = new SqlCommand(strSQL_remplirCasesTheme, sqlConnect);
                sqlRdr_RemplirCasesTheme = sqlRemplirCasesTheme.ExecuteReader();
                while (sqlRdr_RemplirCasesTheme.Read())
                {
                    tb_theme.Text = sqlRdr_RemplirCasesTheme["nomTheme"].ToString();
                    tb_idTheme.Text = sqlRdr_RemplirCasesTheme["idTheme"].ToString();
                }
                sqlRdr_RemplirCasesTheme.Close();
            }
            catch (Exception Ex)
            {
                
                MessageBox.Show(Ex.Message);
            }
           
        }

        private void bt_ajoutTheme_Click(object sender, EventArgs e)
        {
            tb_idTheme.Text = "";
            tb_theme.Text = "";
            groupBox_AjoutTheme.Visible = true;

        }

        private bool findElement(string elementsaisi)
        {

            bool Trouve = false;
            int R = comboBox_theme.FindStringExact(elementsaisi);


            if (R != comboBox_theme.Items.IndexOf(comboBox_theme))
            {
                Trouve = true;
            }
            

            return Trouve;
        }
        
        private void bt_ValidAjoutTheme_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_theme.Text != "")
                {
                    if (findElement(tb_theme.Text) == false)
                    {
                        string strSQL_addTheme = "insert into theme values('" + tb_theme.Text + "')";
                        sqlAddTheme = new SqlCommand(strSQL_addTheme, sqlConnect);
                        sqlAddTheme.ExecuteNonQuery();
                        comboBox_idTheme.Items.Clear();
                        comboBox_theme.Items.Clear();
                        groupBox_AjoutTheme.Visible = false;
                        tb_idTheme.Text = "";
                        tb_theme.Text = "";
                        comboBox_theme.Text = "";
                        chargelistTheme();
                    }
                    else
                    {
                        errorProvider1.SetError(tb_theme,"le thème existe déjà");
                    }
                }
                else
                {
                    errorProvider1.SetError(tb_theme,"le champ doit etre rempli");
                }

                
            }
            catch (Exception Ex)
            {
                
               MessageBox.Show(Ex.Message);
            }
        }

        // partie date d'enregistrement
        private void tb_dateEdit_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Match date = Regex.Match(tb_dateEdit.Text, @"^[0-9][0-9]?\/[0-9][0-9]?\/[0-9][0-9][0-9][0-9]+$");
                tb_dateEdit.Text = date.Value;
                if (tb_dateEdit.Text == "")
                {
                    errorProvider1.SetError(tb_dateEdit, "Vous devez renseigner la date d'édition du livre");
                }
                else
                {
                    errorProvider1.SetError(tb_dateEdit, "");
                }
            }
            catch (Exception Ex)
            {
               errorProvider1.SetError(tb_dateEdit, "ce n'est pas une date Valide; le format doit être de type jj/mm/aaaa"); 
               MessageBox.Show(Ex.Message);
            }
        }
       

        // partie finale d'enregistrement du livre
        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_titre.Text != "")
                {
                    if (combobox_auteur.Text != "")
                    {
                        if (comboBox_editeur.Text != "")
                        {
                            if (comboBox_theme.Text != "")
                            {
                                if (tb_dateEdit.Text != "")
                                {
                                    sqlAjoutLivre = new SqlCommand();
                                    sqlAjoutLivre.Connection = sqlConnect;
                                    sqlAjoutLivre.CommandType = CommandType.StoredProcedure;
                                    sqlAjoutLivre.CommandText = "PS_insertLivre";
                                    SqlParameter newtitre = new SqlParameter("@newTitre", SqlDbType.VarChar);
                                    newtitre.Value = tb_titre.Text;
                                    sqlAjoutLivre.Parameters.Add(newtitre);
                                    SqlParameter idAuteur = new SqlParameter("@idAuteur",SqlDbType.Int);
                                    idAuteur.Value = tb_idAuteur.Text;
                                    sqlAjoutLivre.Parameters.Add(idAuteur);
                                    SqlParameter idtheme = new SqlParameter("@idTheme", SqlDbType.Int);
                                    idtheme.Value = tb_idTheme.Text;
                                    sqlAjoutLivre.Parameters.Add(idtheme);
                                    SqlParameter idediteur = new SqlParameter("@idEditeur", SqlDbType.Int);
                                    idediteur.Value = tb_idEditeur.Text;
                                    sqlAjoutLivre.Parameters.Add(idediteur);
                                    SqlParameter dateEdition = new SqlParameter("@dateEdition", SqlDbType.VarChar);
                                    dateEdition.Value = tb_dateEdit.Text;
                                    sqlAjoutLivre.Parameters.Add(dateEdition);

                                    DialogResult confirm_diag = MessageBox.Show(
                                        "Confirmer l'ajout du livre " + tb_titre.Text + "?",
                                        "Confirmation de création",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2);
                                    if (confirm_diag == DialogResult.Yes)
                                    {
                                        sqlAjoutLivre.ExecuteNonQuery();
                                        tb_titre.Text = "";
                                        tb_dateEdit.Text = "";
                                        combobox_auteur.Text = "";
                                        comboBox_editeur.Text = "";
                                        comboBox_theme.Text = "";

                                    }
                                    


                                   


                                }
                                else
                                {
                                    errorProvider1.SetError(tb_dateEdit, "vous devez indiquer la date d'édition");
                                }

                            }
                            else
                            {
                                errorProvider1.SetError(comboBox_theme, "vous devez sélectionner un éditeur");
                            }
                                      
                        }
                        else
                        {
                            errorProvider1.SetError(comboBox_editeur, "vous devez sélectionner un éditeur");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(combobox_auteur, "vous devez sélectionner un auteur");
                    }
                }
                else
                {
                    errorProvider1.SetError(tb_titre, "le champ ne peut être vide");
                }
            }
            catch (Exception Ex)
            {
                
                MessageBox.Show(Ex.Message);
            }
        }





        



        



    }
}
