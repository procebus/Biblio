namespace bibliothèque001
{
    partial class statsEmp_form
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
            this.cb_auteur = new System.Windows.Forms.ComboBox();
            this.cb_titre = new System.Windows.Forms.ComboBox();
            this.cb_mois = new System.Windows.Forms.ComboBox();
            this.cb_annee = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tb_Emp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_rech = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_auteur
            // 
            this.cb_auteur.FormattingEnabled = true;
            this.cb_auteur.Location = new System.Drawing.Point(120, 84);
            this.cb_auteur.Name = "cb_auteur";
            this.cb_auteur.Size = new System.Drawing.Size(121, 21);
            this.cb_auteur.TabIndex = 0;
            // 
            // cb_titre
            // 
            this.cb_titre.FormattingEnabled = true;
            this.cb_titre.Location = new System.Drawing.Point(120, 133);
            this.cb_titre.Name = "cb_titre";
            this.cb_titre.Size = new System.Drawing.Size(121, 21);
            this.cb_titre.TabIndex = 1;
            // 
            // cb_mois
            // 
            this.cb_mois.FormattingEnabled = true;
            this.cb_mois.Items.AddRange(new object[] {
            "janvier",
            "février",
            "mars",
            "avril",
            "mai",
            "juin",
            "juillet",
            "août",
            "septembre",
            "octobre",
            "novembre",
            "décembre"});
            this.cb_mois.Location = new System.Drawing.Point(108, 208);
            this.cb_mois.Name = "cb_mois";
            this.cb_mois.Size = new System.Drawing.Size(121, 21);
            this.cb_mois.TabIndex = 2;
            // 
            // cb_annee
            // 
            this.cb_annee.FormattingEnabled = true;
            this.cb_annee.Items.AddRange(new object[] {
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014"});
            this.cb_annee.Location = new System.Drawing.Point(297, 208);
            this.cb_annee.Name = "cb_annee";
            this.cb_annee.Size = new System.Drawing.Size(93, 21);
            this.cb_annee.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(46, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Auteur";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(46, 134);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Titre";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // tb_Emp
            // 
            this.tb_Emp.Location = new System.Drawing.Point(280, 105);
            this.tb_Emp.Multiline = true;
            this.tb_Emp.Name = "tb_Emp";
            this.tb_Emp.Size = new System.Drawing.Size(208, 67);
            this.tb_Emp.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre d\'emprunts";
            // 
            // bt_rech
            // 
            this.bt_rech.Location = new System.Drawing.Point(130, 265);
            this.bt_rech.Name = "bt_rech";
            this.bt_rech.Size = new System.Drawing.Size(75, 23);
            this.bt_rech.TabIndex = 11;
            this.bt_rech.Text = "Rechercher";
            this.bt_rech.UseVisualStyleBackColor = true;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(297, 265);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 12;
            this.bt_close.Text = "Fermer";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sélectionner l\'auteur ou le titre du livre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mois";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Année";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sélectionner le mois et l\'année";
            // 
            // statsEmp_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 327);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_rech);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Emp);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.cb_annee);
            this.Controls.Add(this.cb_mois);
            this.Controls.Add(this.cb_titre);
            this.Controls.Add(this.cb_auteur);
            this.Name = "statsEmp_form";
            this.Text = "Statistiques d\'emprunts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_auteur;
        private System.Windows.Forms.ComboBox cb_titre;
        private System.Windows.Forms.ComboBox cb_mois;
        private System.Windows.Forms.ComboBox cb_annee;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox tb_Emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_rech;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}