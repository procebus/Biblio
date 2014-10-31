using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliothèque001
{
    public partial class espaceAdmin_form : Form
    {
        public espaceAdmin_form()
        {
            InitializeComponent();
            lb_id.Text = "Administrateur";
        }

        private void espaceAdmin_form_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_decnx_Click(object sender, EventArgs e)
        {
            
            login_frm login_feuille = new login_frm();
            login_feuille.MdiParent = this.ParentForm;
            login_feuille.Show();
            this.Close();
        }
        catalogue_form catalogue_feuille;
        private void bt_catalogue_Click(object sender, EventArgs e)
        {
            if (catalogue_feuille == null || catalogue_feuille.IsHandleCreated == false)
            {
                catalogue_feuille = new catalogue_form();
                catalogue_feuille.MdiParent = this.ParentForm;
                catalogue_feuille.Show(); 
            }
          

        }
        
        private void bt_lstEmp_Click(object sender, EventArgs e)
        {
            lstEmp_form listEmp_feuille = new lstEmp_form();
            listEmp_feuille.MdiParent = this.ParentForm;
            listEmp_feuille.Show();
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
        retourEmp_form enregRetour_feuille;
        private void bt_retourEmp_Click(object sender, EventArgs e)
        {
            if (enregRetour_feuille == null || enregRetour_feuille.IsHandleCreated == false)
            {
                enregRetour_feuille = new retourEmp_form();
                enregRetour_feuille.MdiParent = this.ParentForm;
                enregRetour_feuille.Show(); 
            }
        }
        relances_form relances_feuille;
        private void bt_rel_Click(object sender, EventArgs e)
        {
            if (relances_feuille == null || relances_feuille.IsHandleCreated == false)
            {
                relances_feuille = new relances_form();
                relances_feuille.MdiParent = this.ParentForm;
                relances_feuille.Show(); 
            }
        }
        gestAbo_form gestionAbo_feuille;
        private void bt_gestAbo_Click(object sender, EventArgs e)
        {
            if (gestionAbo_feuille == null || gestionAbo_feuille.IsHandleCreated == false)
            {
                gestionAbo_feuille = new gestAbo_form();
                gestionAbo_feuille.MdiParent = this.ParentForm;
                gestionAbo_feuille.Show(); 
            }
        }
        ajoutAbo_form ajoutAbo_feuille;
        private void bt_newAbo_Click(object sender, EventArgs e)
        {
            if (ajoutAbo_feuille == null || ajoutAbo_feuille.IsHandleCreated == false)
            {
                ajoutAbo_feuille = new ajoutAbo_form();
                ajoutAbo_feuille.MdiParent = this.ParentForm;
                ajoutAbo_feuille.Show(); 
            }
        }
        refLiv_form referencerLivre_feuille;
        private void bt_refLiv_Click(object sender, EventArgs e)
        {
            if (referencerLivre_feuille == null || referencerLivre_feuille.IsHandleCreated == false)
            {
                referencerLivre_feuille = new refLiv_form();
                referencerLivre_feuille.MdiParent = this.ParentForm;
                referencerLivre_feuille.Show(); 
            }
        }
        statsEmp_form stats_feuille;
        private void bt_stats_Click(object sender, EventArgs e)
        {
            if (stats_feuille == null || stats_feuille.IsHandleCreated == false)
            {
                stats_feuille = new statsEmp_form();
                stats_feuille.MdiParent = this.ParentForm;
                stats_feuille.Show(); 
            }
        }

        inventaire_form inventaire_feuille;
        private void bt_inventaire_Click(object sender, EventArgs e)
        {
            if (inventaire_feuille == null || inventaire_feuille.IsHandleCreated == false)
            {
                inventaire_feuille = new inventaire_form();
                inventaire_feuille.MdiParent = this.ParentForm;
                inventaire_feuille.Show(); 
            }
            
        }
        commandLivre_form commanderlivre_feuille;
        private void bt_commande_Click(object sender, EventArgs e)
        {
            if (commanderlivre_feuille == null || commanderlivre_feuille.IsHandleCreated == false)
            {
                commanderlivre_feuille = new commandLivre_form();
                commanderlivre_feuille.MdiParent = this.ParentForm;
                commanderlivre_feuille.Show(); 
            }
        }
        gestUsers_form gestionUtilisateur_feuille;

        private void bt_users_Click(object sender, EventArgs e)
        {
            if (gestionUtilisateur_feuille == null || gestionUtilisateur_feuille.IsHandleCreated == false)
            {
                gestionUtilisateur_feuille = new gestUsers_form();
                gestionUtilisateur_feuille.MdiParent = this.ParentForm;
                gestionUtilisateur_feuille.Show(); 
            }


            
        }

        private void espaceAdmin_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((main_Form)MdiParent).LoginToolStripMenuItem.Enabled = true;
        }
    }
}
