namespace bibliothèque001
{
    partial class catalogue_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxlivres = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_idLiv = new System.Windows.Forms.ComboBox();
            this.cb_idediteur = new System.Windows.Forms.ComboBox();
            this.cb_idAut = new System.Windows.Forms.ComboBox();
            this.cb_idtheme = new System.Windows.Forms.ComboBox();
            this.cb_dateEdit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_theme = new System.Windows.Forms.ComboBox();
            this.cb_editeur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_editeur = new System.Windows.Forms.Label();
            this.cb_auteur = new System.Windows.Forms.ComboBox();
            this.bt_fermer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxlivres
            // 
            this.listBoxlivres.FormattingEnabled = true;
            this.listBoxlivres.Location = new System.Drawing.Point(362, 57);
            this.listBoxlivres.Name = "listBoxlivres";
            this.listBoxlivres.Size = new System.Drawing.Size(271, 264);
            this.listBoxlivres.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Liste des livres";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_idLiv);
            this.groupBox1.Controls.Add(this.cb_idediteur);
            this.groupBox1.Controls.Add(this.cb_idAut);
            this.groupBox1.Controls.Add(this.cb_idtheme);
            this.groupBox1.Controls.Add(this.cb_dateEdit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_theme);
            this.groupBox1.Controls.Add(this.cb_editeur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_editeur);
            this.groupBox1.Controls.Add(this.cb_auteur);
            this.groupBox1.Location = new System.Drawing.Point(28, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 253);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Critères de recherche";
            // 
            // cb_idLiv
            // 
            this.cb_idLiv.Enabled = false;
            this.cb_idLiv.FormattingEnabled = true;
            this.cb_idLiv.Location = new System.Drawing.Point(272, 194);
            this.cb_idLiv.Name = "cb_idLiv";
            this.cb_idLiv.Size = new System.Drawing.Size(25, 21);
            this.cb_idLiv.TabIndex = 27;
            this.cb_idLiv.Visible = false;
            // 
            // cb_idediteur
            // 
            this.cb_idediteur.FormattingEnabled = true;
            this.cb_idediteur.Location = new System.Drawing.Point(272, 140);
            this.cb_idediteur.Name = "cb_idediteur";
            this.cb_idediteur.Size = new System.Drawing.Size(25, 21);
            this.cb_idediteur.TabIndex = 26;
            this.cb_idediteur.Visible = false;
            // 
            // cb_idAut
            // 
            this.cb_idAut.FormattingEnabled = true;
            this.cb_idAut.Location = new System.Drawing.Point(272, 83);
            this.cb_idAut.Name = "cb_idAut";
            this.cb_idAut.Size = new System.Drawing.Size(25, 21);
            this.cb_idAut.TabIndex = 25;
            this.cb_idAut.Visible = false;
            // 
            // cb_idtheme
            // 
            this.cb_idtheme.FormattingEnabled = true;
            this.cb_idtheme.Location = new System.Drawing.Point(272, 33);
            this.cb_idtheme.Name = "cb_idtheme";
            this.cb_idtheme.Size = new System.Drawing.Size(25, 21);
            this.cb_idtheme.TabIndex = 24;
            this.cb_idtheme.Visible = false;
            // 
            // cb_dateEdit
            // 
            this.cb_dateEdit.Enabled = false;
            this.cb_dateEdit.FormattingEnabled = true;
            this.cb_dateEdit.Location = new System.Drawing.Point(102, 194);
            this.cb_dateEdit.Name = "cb_dateEdit";
            this.cb_dateEdit.Size = new System.Drawing.Size(164, 21);
            this.cb_dateEdit.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thème";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(17, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date d\'édition";
            // 
            // cb_theme
            // 
            this.cb_theme.FormattingEnabled = true;
            this.cb_theme.Location = new System.Drawing.Point(102, 34);
            this.cb_theme.Name = "cb_theme";
            this.cb_theme.Size = new System.Drawing.Size(164, 21);
            this.cb_theme.TabIndex = 17;
            this.cb_theme.DropDown += new System.EventHandler(this.cb_theme_DropDown);
            this.cb_theme.SelectedIndexChanged += new System.EventHandler(this.cb_theme_SelectedIndexChanged);
            // 
            // cb_editeur
            // 
            this.cb_editeur.FormattingEnabled = true;
            this.cb_editeur.Location = new System.Drawing.Point(102, 140);
            this.cb_editeur.Name = "cb_editeur";
            this.cb_editeur.Size = new System.Drawing.Size(164, 21);
            this.cb_editeur.TabIndex = 21;
            this.cb_editeur.DropDown += new System.EventHandler(this.cb_editeur_DropDown);
            this.cb_editeur.SelectedIndexChanged += new System.EventHandler(this.cb_editeur_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Auteur";
            // 
            // lb_editeur
            // 
            this.lb_editeur.AutoSize = true;
            this.lb_editeur.Location = new System.Drawing.Point(17, 140);
            this.lb_editeur.Name = "lb_editeur";
            this.lb_editeur.Size = new System.Drawing.Size(40, 13);
            this.lb_editeur.TabIndex = 20;
            this.lb_editeur.Text = "Editeur";
            // 
            // cb_auteur
            // 
            this.cb_auteur.FormattingEnabled = true;
            this.cb_auteur.Location = new System.Drawing.Point(102, 83);
            this.cb_auteur.Name = "cb_auteur";
            this.cb_auteur.Size = new System.Drawing.Size(164, 21);
            this.cb_auteur.TabIndex = 19;
            this.cb_auteur.DropDown += new System.EventHandler(this.cb_auteur_DropDown);
            this.cb_auteur.SelectedIndexChanged += new System.EventHandler(this.cb_auteur_SelectedIndexChanged);
            // 
            // bt_fermer
            // 
            this.bt_fermer.Location = new System.Drawing.Point(285, 353);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_fermer.TabIndex = 16;
            this.bt_fermer.Text = "Fermer";
            this.bt_fermer.UseVisualStyleBackColor = true;
            this.bt_fermer.Click += new System.EventHandler(this.bt_fermer_Click);
            // 
            // catalogue_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 401);
            this.Controls.Add(this.bt_fermer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxlivres);
            this.Name = "catalogue_form";
            this.Text = "Bibliothèque - Catalogue";
            this.Load += new System.EventHandler(this.catalogue_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxlivres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_dateEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_theme;
        private System.Windows.Forms.ComboBox cb_editeur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_editeur;
        private System.Windows.Forms.ComboBox cb_auteur;
        private System.Windows.Forms.ComboBox cb_idLiv;
        private System.Windows.Forms.ComboBox cb_idediteur;
        private System.Windows.Forms.ComboBox cb_idAut;
        private System.Windows.Forms.ComboBox cb_idtheme;
        private System.Windows.Forms.Button bt_fermer;
    }
}