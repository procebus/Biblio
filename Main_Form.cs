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
    public partial class main_Form : Form
    {
        public main_Form()
        {
            InitializeComponent();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestion de la Bibliothèque \n Version 003 \n Philippe Fiévet");
        }

        private bool etatConnect = false;

        public bool EtatConnect
        {
            get { return etatConnect; }
            set { etatConnect = value; }
        }

        private string identifiant;

        public string Identifiant
        {
            get { return identifiant; }
            set { identifiant = value; }
        }

        private void Bibliotheque_Load(object sender, EventArgs e)
        {
            try
            {
                login_frm login = new login_frm();
                login.MdiParent = this;
                login.Show();


                /* test_form test = new test_form();
                 test.MdiParent = this;
                 test.Show(); */
            }
            catch (Exception EX)
            {
                
                MessageBox.Show(EX.Message);
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        login_frm login;
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == null || login.IsHandleCreated == false)
            {
                login = new login_frm();
                login.MdiParent = this;
                login.Show();
            }
        }

      
       
    }
}
