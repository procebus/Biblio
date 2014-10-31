namespace bibliothèque001
{
    partial class refLiv_form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.tb_titre = new System.Windows.Forms.TextBox();
            this.tb_nomauteur = new System.Windows.Forms.TextBox();
            this.tb_editeur = new System.Windows.Forms.TextBox();
            this.tb_dateEdit = new System.Windows.Forms.TextBox();
            this.comboBox_editeur = new System.Windows.Forms.ComboBox();
            this.combobox_auteur = new System.Windows.Forms.ComboBox();
            this.bt_ajoutAuteur = new System.Windows.Forms.Button();
            this.bt_ajoutEditeur = new System.Windows.Forms.Button();
            this.tb_prenomAuteur = new System.Windows.Forms.TextBox();
            this.tb_idAuteur = new System.Windows.Forms.TextBox();
            this.tb_idEditeur = new System.Windows.Forms.TextBox();
            this.lb_nomAut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_auteur = new System.Windows.Forms.GroupBox();
            this.comboBox_idAuteur = new System.Windows.Forms.ComboBox();
            this.comboBox_idEditeur = new System.Windows.Forms.ComboBox();
            this.bt_validAjoutAut = new System.Windows.Forms.Button();
            this.bt_validAjourEditeur = new System.Windows.Forms.Button();
            this.groupBox_editeur = new System.Windows.Forms.GroupBox();
            this.label_ajoutAuteur = new System.Windows.Forms.Label();
            this.Label_ajoutEditeur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_theme = new System.Windows.Forms.ComboBox();
            this.comboBox_idTheme = new System.Windows.Forms.ComboBox();
            this.bt_ajoutTheme = new System.Windows.Forms.Button();
            this.groupBox_AjoutTheme = new System.Windows.Forms.GroupBox();
            this.tb_theme = new System.Windows.Forms.TextBox();
            this.tb_idTheme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_ValidAjoutTheme = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_auteur.SuspendLayout();
            this.groupBox_editeur.SuspendLayout();
            this.groupBox_AjoutTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editeur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date d\'édition";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(164, 609);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "Enregistrer";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(273, 609);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 23);
            this.bt_Close.TabIndex = 5;
            this.bt_Close.Text = "Fermer";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // tb_titre
            // 
            this.tb_titre.Location = new System.Drawing.Point(123, 39);
            this.tb_titre.Name = "tb_titre";
            this.tb_titre.Size = new System.Drawing.Size(264, 20);
            this.tb_titre.TabIndex = 6;
            // 
            // tb_nomauteur
            // 
            this.tb_nomauteur.Location = new System.Drawing.Point(83, 25);
            this.tb_nomauteur.Name = "tb_nomauteur";
            this.tb_nomauteur.Size = new System.Drawing.Size(142, 20);
            this.tb_nomauteur.TabIndex = 7;
            // 
            // tb_editeur
            // 
            this.tb_editeur.Location = new System.Drawing.Point(65, 37);
            this.tb_editeur.Name = "tb_editeur";
            this.tb_editeur.Size = new System.Drawing.Size(174, 20);
            this.tb_editeur.TabIndex = 8;
            // 
            // tb_dateEdit
            // 
            this.tb_dateEdit.Location = new System.Drawing.Point(149, 429);
            this.tb_dateEdit.Name = "tb_dateEdit";
            this.tb_dateEdit.Size = new System.Drawing.Size(224, 20);
            this.tb_dateEdit.TabIndex = 9;
            this.tb_dateEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tb_dateEdit_Validating);
            // 
            // comboBox_editeur
            // 
            this.comboBox_editeur.FormattingEnabled = true;
            this.comboBox_editeur.Location = new System.Drawing.Point(109, 284);
            this.comboBox_editeur.Name = "comboBox_editeur";
            this.comboBox_editeur.Size = new System.Drawing.Size(264, 21);
            this.comboBox_editeur.TabIndex = 10;
            this.comboBox_editeur.DropDown += new System.EventHandler(this.comboBox_editeur_DropDown);
            this.comboBox_editeur.SelectedIndexChanged += new System.EventHandler(this.comboBox_editeur_SelectedIndexChanged);
            // 
            // combobox_auteur
            // 
            this.combobox_auteur.FormattingEnabled = true;
            this.combobox_auteur.Location = new System.Drawing.Point(123, 89);
            this.combobox_auteur.Name = "combobox_auteur";
            this.combobox_auteur.Size = new System.Drawing.Size(264, 21);
            this.combobox_auteur.TabIndex = 11;
            this.combobox_auteur.DropDown += new System.EventHandler(this.combobox_auteur_DropDown);
            this.combobox_auteur.SelectedIndexChanged += new System.EventHandler(this.combobox_auteur_SelectedIndexChanged);
            // 
            // bt_ajoutAuteur
            // 
            this.bt_ajoutAuteur.Location = new System.Drawing.Point(393, 89);
            this.bt_ajoutAuteur.Name = "bt_ajoutAuteur";
            this.bt_ajoutAuteur.Size = new System.Drawing.Size(43, 21);
            this.bt_ajoutAuteur.TabIndex = 12;
            this.bt_ajoutAuteur.Text = "+";
            this.bt_ajoutAuteur.UseVisualStyleBackColor = true;
            this.bt_ajoutAuteur.Click += new System.EventHandler(this.bt_ajoutAuteur_Click);
            // 
            // bt_ajoutEditeur
            // 
            this.bt_ajoutEditeur.Location = new System.Drawing.Point(392, 284);
            this.bt_ajoutEditeur.Name = "bt_ajoutEditeur";
            this.bt_ajoutEditeur.Size = new System.Drawing.Size(43, 21);
            this.bt_ajoutEditeur.TabIndex = 13;
            this.bt_ajoutEditeur.Text = "+";
            this.bt_ajoutEditeur.UseVisualStyleBackColor = true;
            this.bt_ajoutEditeur.Click += new System.EventHandler(this.bt_ajoutEditeur_Click);
            // 
            // tb_prenomAuteur
            // 
            this.tb_prenomAuteur.Location = new System.Drawing.Point(83, 62);
            this.tb_prenomAuteur.Name = "tb_prenomAuteur";
            this.tb_prenomAuteur.Size = new System.Drawing.Size(142, 20);
            this.tb_prenomAuteur.TabIndex = 14;
            // 
            // tb_idAuteur
            // 
            this.tb_idAuteur.Location = new System.Drawing.Point(28, 88);
            this.tb_idAuteur.Name = "tb_idAuteur";
            this.tb_idAuteur.ReadOnly = true;
            this.tb_idAuteur.Size = new System.Drawing.Size(100, 20);
            this.tb_idAuteur.TabIndex = 15;
            this.tb_idAuteur.Visible = false;
            // 
            // tb_idEditeur
            // 
            this.tb_idEditeur.Location = new System.Drawing.Point(16, 55);
            this.tb_idEditeur.Name = "tb_idEditeur";
            this.tb_idEditeur.ReadOnly = true;
            this.tb_idEditeur.Size = new System.Drawing.Size(68, 20);
            this.tb_idEditeur.TabIndex = 16;
            this.tb_idEditeur.Visible = false;
            // 
            // lb_nomAut
            // 
            this.lb_nomAut.AutoSize = true;
            this.lb_nomAut.Location = new System.Drawing.Point(15, 28);
            this.lb_nomAut.Name = "lb_nomAut";
            this.lb_nomAut.Size = new System.Drawing.Size(29, 13);
            this.lb_nomAut.TabIndex = 17;
            this.lb_nomAut.Text = "Nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Prénom";
            // 
            // groupBox_auteur
            // 
            this.groupBox_auteur.Controls.Add(this.lb_nomAut);
            this.groupBox_auteur.Controls.Add(this.bt_validAjoutAut);
            this.groupBox_auteur.Controls.Add(this.label6);
            this.groupBox_auteur.Controls.Add(this.tb_nomauteur);
            this.groupBox_auteur.Controls.Add(this.tb_prenomAuteur);
            this.groupBox_auteur.Controls.Add(this.tb_idAuteur);
            this.groupBox_auteur.Location = new System.Drawing.Point(123, 125);
            this.groupBox_auteur.Name = "groupBox_auteur";
            this.groupBox_auteur.Size = new System.Drawing.Size(260, 133);
            this.groupBox_auteur.TabIndex = 19;
            this.groupBox_auteur.TabStop = false;
            this.groupBox_auteur.Text = "Ajout d\'auteur";
            // 
            // comboBox_idAuteur
            // 
            this.comboBox_idAuteur.FormattingEnabled = true;
            this.comboBox_idAuteur.Location = new System.Drawing.Point(442, 90);
            this.comboBox_idAuteur.Name = "comboBox_idAuteur";
            this.comboBox_idAuteur.Size = new System.Drawing.Size(35, 21);
            this.comboBox_idAuteur.TabIndex = 20;
            this.comboBox_idAuteur.Visible = false;
            // 
            // comboBox_idEditeur
            // 
            this.comboBox_idEditeur.FormattingEnabled = true;
            this.comboBox_idEditeur.Location = new System.Drawing.Point(441, 284);
            this.comboBox_idEditeur.Name = "comboBox_idEditeur";
            this.comboBox_idEditeur.Size = new System.Drawing.Size(46, 21);
            this.comboBox_idEditeur.TabIndex = 21;
            this.comboBox_idEditeur.Visible = false;
            // 
            // bt_validAjoutAut
            // 
            this.bt_validAjoutAut.Location = new System.Drawing.Point(150, 88);
            this.bt_validAjoutAut.Name = "bt_validAjoutAut";
            this.bt_validAjoutAut.Size = new System.Drawing.Size(75, 23);
            this.bt_validAjoutAut.TabIndex = 22;
            this.bt_validAjoutAut.Text = "Ajouter";
            this.bt_validAjoutAut.UseVisualStyleBackColor = true;
            this.bt_validAjoutAut.Click += new System.EventHandler(this.bt_validAjoutAut_Click);
            // 
            // bt_validAjourEditeur
            // 
            this.bt_validAjourEditeur.Location = new System.Drawing.Point(251, 35);
            this.bt_validAjourEditeur.Name = "bt_validAjourEditeur";
            this.bt_validAjourEditeur.Size = new System.Drawing.Size(75, 23);
            this.bt_validAjourEditeur.TabIndex = 23;
            this.bt_validAjourEditeur.Text = "Ajouter";
            this.bt_validAjourEditeur.UseVisualStyleBackColor = true;
            this.bt_validAjourEditeur.Click += new System.EventHandler(this.bt_validAjourEditeur_Click);
            // 
            // groupBox_editeur
            // 
            this.groupBox_editeur.Controls.Add(this.label7);
            this.groupBox_editeur.Controls.Add(this.bt_validAjourEditeur);
            this.groupBox_editeur.Controls.Add(this.tb_editeur);
            this.groupBox_editeur.Controls.Add(this.tb_idEditeur);
            this.groupBox_editeur.Location = new System.Drawing.Point(109, 323);
            this.groupBox_editeur.Name = "groupBox_editeur";
            this.groupBox_editeur.Size = new System.Drawing.Size(340, 75);
            this.groupBox_editeur.TabIndex = 24;
            this.groupBox_editeur.TabStop = false;
            this.groupBox_editeur.Text = "Ajout d\'éditeur";
            // 
            // label_ajoutAuteur
            // 
            this.label_ajoutAuteur.AutoSize = true;
            this.label_ajoutAuteur.Location = new System.Drawing.Point(62, 150);
            this.label_ajoutAuteur.Name = "label_ajoutAuteur";
            this.label_ajoutAuteur.Size = new System.Drawing.Size(356, 13);
            this.label_ajoutAuteur.TabIndex = 25;
            this.label_ajoutAuteur.Text = "Si l\'auteur n\'est pas renseigné, vous devez le rajouter avec le boutonn \"+\"";
            // 
            // Label_ajoutEditeur
            // 
            this.Label_ajoutEditeur.AutoSize = true;
            this.Label_ajoutEditeur.Location = new System.Drawing.Point(75, 339);
            this.Label_ajoutEditeur.Name = "Label_ajoutEditeur";
            this.Label_ajoutEditeur.Size = new System.Drawing.Size(343, 13);
            this.Label_ajoutEditeur.TabIndex = 26;
            this.Label_ajoutEditeur.Text = "Si l\'éditeur n\'est pas présent dans la liste , ajoutez le avec le bouton \"+\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thème";
            // 
            // comboBox_theme
            // 
            this.comboBox_theme.FormattingEnabled = true;
            this.comboBox_theme.Location = new System.Drawing.Point(116, 469);
            this.comboBox_theme.Name = "comboBox_theme";
            this.comboBox_theme.Size = new System.Drawing.Size(251, 21);
            this.comboBox_theme.TabIndex = 28;
            this.comboBox_theme.DropDown += new System.EventHandler(this.comboBox_theme_DropDown);
            this.comboBox_theme.SelectedIndexChanged += new System.EventHandler(this.comboBox_theme_SelectedIndexChanged);
            // 
            // comboBox_idTheme
            // 
            this.comboBox_idTheme.FormattingEnabled = true;
            this.comboBox_idTheme.Location = new System.Drawing.Point(441, 469);
            this.comboBox_idTheme.Name = "comboBox_idTheme";
            this.comboBox_idTheme.Size = new System.Drawing.Size(35, 21);
            this.comboBox_idTheme.TabIndex = 29;
            this.comboBox_idTheme.Visible = false;
            // 
            // bt_ajoutTheme
            // 
            this.bt_ajoutTheme.Location = new System.Drawing.Point(378, 467);
            this.bt_ajoutTheme.Name = "bt_ajoutTheme";
            this.bt_ajoutTheme.Size = new System.Drawing.Size(40, 23);
            this.bt_ajoutTheme.TabIndex = 30;
            this.bt_ajoutTheme.Text = "+";
            this.bt_ajoutTheme.UseVisualStyleBackColor = true;
            this.bt_ajoutTheme.Click += new System.EventHandler(this.bt_ajoutTheme_Click);
            // 
            // groupBox_AjoutTheme
            // 
            this.groupBox_AjoutTheme.Controls.Add(this.bt_ValidAjoutTheme);
            this.groupBox_AjoutTheme.Controls.Add(this.label8);
            this.groupBox_AjoutTheme.Controls.Add(this.tb_idTheme);
            this.groupBox_AjoutTheme.Controls.Add(this.tb_theme);
            this.groupBox_AjoutTheme.Location = new System.Drawing.Point(116, 505);
            this.groupBox_AjoutTheme.Name = "groupBox_AjoutTheme";
            this.groupBox_AjoutTheme.Size = new System.Drawing.Size(333, 66);
            this.groupBox_AjoutTheme.TabIndex = 31;
            this.groupBox_AjoutTheme.TabStop = false;
            this.groupBox_AjoutTheme.Text = "Ajouter un thème";
            // 
            // tb_theme
            // 
            this.tb_theme.Location = new System.Drawing.Point(78, 29);
            this.tb_theme.Name = "tb_theme";
            this.tb_theme.Size = new System.Drawing.Size(154, 20);
            this.tb_theme.TabIndex = 0;
            // 
            // tb_idTheme
            // 
            this.tb_idTheme.Location = new System.Drawing.Point(24, 60);
            this.tb_idTheme.Name = "tb_idTheme";
            this.tb_idTheme.ReadOnly = true;
            this.tb_idTheme.Size = new System.Drawing.Size(38, 20);
            this.tb_idTheme.TabIndex = 1;
            this.tb_idTheme.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "nom";
            // 
            // bt_ValidAjoutTheme
            // 
            this.bt_ValidAjoutTheme.Location = new System.Drawing.Point(245, 29);
            this.bt_ValidAjoutTheme.Name = "bt_ValidAjoutTheme";
            this.bt_ValidAjoutTheme.Size = new System.Drawing.Size(75, 23);
            this.bt_ValidAjoutTheme.TabIndex = 3;
            this.bt_ValidAjoutTheme.Text = "Ajouter";
            this.bt_ValidAjoutTheme.UseVisualStyleBackColor = true;
            this.bt_ValidAjoutTheme.Click += new System.EventHandler(this.bt_ValidAjoutTheme_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // refLiv_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 651);
            this.Controls.Add(this.Label_ajoutEditeur);
            this.Controls.Add(this.groupBox_AjoutTheme);
            this.Controls.Add(this.bt_ajoutTheme);
            this.Controls.Add(this.comboBox_idTheme);
            this.Controls.Add(this.comboBox_theme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_ajoutAuteur);
            this.Controls.Add(this.comboBox_idEditeur);
            this.Controls.Add(this.comboBox_idAuteur);
            this.Controls.Add(this.groupBox_auteur);
            this.Controls.Add(this.bt_ajoutEditeur);
            this.Controls.Add(this.bt_ajoutAuteur);
            this.Controls.Add(this.combobox_auteur);
            this.Controls.Add(this.comboBox_editeur);
            this.Controls.Add(this.tb_dateEdit);
            this.Controls.Add(this.tb_titre);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_editeur);
            this.Name = "refLiv_form";
            this.Text = "Référencer un nouveau livre";
            this.Load += new System.EventHandler(this.refLiv_form_Load);
            this.groupBox_auteur.ResumeLayout(false);
            this.groupBox_auteur.PerformLayout();
            this.groupBox_editeur.ResumeLayout(false);
            this.groupBox_editeur.PerformLayout();
            this.groupBox_AjoutTheme.ResumeLayout(false);
            this.groupBox_AjoutTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.TextBox tb_titre;
        private System.Windows.Forms.TextBox tb_nomauteur;
        private System.Windows.Forms.TextBox tb_editeur;
        private System.Windows.Forms.TextBox tb_dateEdit;
        private System.Windows.Forms.ComboBox comboBox_editeur;
        private System.Windows.Forms.ComboBox combobox_auteur;
        private System.Windows.Forms.Button bt_ajoutAuteur;
        private System.Windows.Forms.Button bt_ajoutEditeur;
        private System.Windows.Forms.TextBox tb_prenomAuteur;
        private System.Windows.Forms.TextBox tb_idAuteur;
        private System.Windows.Forms.TextBox tb_idEditeur;
        private System.Windows.Forms.Label lb_nomAut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_auteur;
        private System.Windows.Forms.ComboBox comboBox_idAuteur;
        private System.Windows.Forms.ComboBox comboBox_idEditeur;
        private System.Windows.Forms.Button bt_validAjoutAut;
        private System.Windows.Forms.Button bt_validAjourEditeur;
        private System.Windows.Forms.GroupBox groupBox_editeur;
        private System.Windows.Forms.Label label_ajoutAuteur;
        private System.Windows.Forms.Label Label_ajoutEditeur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_theme;
        private System.Windows.Forms.ComboBox comboBox_idTheme;
        private System.Windows.Forms.Button bt_ajoutTheme;
        private System.Windows.Forms.GroupBox groupBox_AjoutTheme;
        private System.Windows.Forms.Button bt_ValidAjoutTheme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_idTheme;
        private System.Windows.Forms.TextBox tb_theme;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}