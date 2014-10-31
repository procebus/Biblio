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
    public partial class gestUsers_form : Form
    {
        public gestUsers_form()
        {
            InitializeComponent();
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestUsers_form_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.utilisateurs'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.utilisateursTableAdapter.Fill(this.dataSet1.utilisateurs);

        }
    }
}
