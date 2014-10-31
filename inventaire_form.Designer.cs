namespace bibliothèque001
{
    partial class inventaire_form
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
            this.listbox_livres = new System.Windows.Forms.ListBox();
            this.bt_rebus = new System.Windows.Forms.Button();
            this.gb_etat = new System.Windows.Forms.GroupBox();
            this.rb_rebus = new System.Windows.Forms.RadioButton();
            this.rb_emprunt = new System.Windows.Forms.RadioButton();
            this.rd_dispo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_idLivre = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_DateRebus = new System.Windows.Forms.TextBox();
            this.tb_DateEdition = new System.Windows.Forms.TextBox();
            this.tb_DateEmp = new System.Windows.Forms.TextBox();
            this.tb_DateEnreg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_AboEmp = new System.Windows.Forms.TextBox();
            this.Pary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Edition = new System.Windows.Forms.TextBox();
            this.bt_fermer = new System.Windows.Forms.Button();
            this.bt_dispo = new System.Windows.Forms.Button();
            this.gb_etat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox_livres
            // 
            this.listbox_livres.FormattingEnabled = true;
            this.listbox_livres.Location = new System.Drawing.Point(295, 49);
            this.listbox_livres.Name = "listbox_livres";
            this.listbox_livres.Size = new System.Drawing.Size(349, 147);
            this.listbox_livres.TabIndex = 9;
            this.listbox_livres.SelectedIndexChanged += new System.EventHandler(this.listbox_livres_SelectedIndexChanged);
            // 
            // bt_rebus
            // 
            this.bt_rebus.Location = new System.Drawing.Point(295, 202);
            this.bt_rebus.Name = "bt_rebus";
            this.bt_rebus.Size = new System.Drawing.Size(111, 21);
            this.bt_rebus.TabIndex = 10;
            this.bt_rebus.Text = "Mise au Rebus";
            this.bt_rebus.UseVisualStyleBackColor = true;
            this.bt_rebus.Click += new System.EventHandler(this.bt_rebus_Click);
            // 
            // gb_etat
            // 
            this.gb_etat.Controls.Add(this.rb_rebus);
            this.gb_etat.Controls.Add(this.rb_emprunt);
            this.gb_etat.Controls.Add(this.rd_dispo);
            this.gb_etat.Location = new System.Drawing.Point(100, 49);
            this.gb_etat.Name = "gb_etat";
            this.gb_etat.Size = new System.Drawing.Size(162, 144);
            this.gb_etat.TabIndex = 11;
            this.gb_etat.TabStop = false;
            this.gb_etat.Text = "Etat du livre";
            // 
            // rb_rebus
            // 
            this.rb_rebus.AutoSize = true;
            this.rb_rebus.Location = new System.Drawing.Point(18, 100);
            this.rb_rebus.Name = "rb_rebus";
            this.rb_rebus.Size = new System.Drawing.Size(85, 17);
            this.rb_rebus.TabIndex = 8;
            this.rb_rebus.TabStop = true;
            this.rb_rebus.Text = "Mis au rebus";
            this.rb_rebus.UseVisualStyleBackColor = true;
            this.rb_rebus.CheckedChanged += new System.EventHandler(this.rb_rebus_CheckedChanged);
            // 
            // rb_emprunt
            // 
            this.rb_emprunt.AutoSize = true;
            this.rb_emprunt.Location = new System.Drawing.Point(18, 63);
            this.rb_emprunt.Name = "rb_emprunt";
            this.rb_emprunt.Size = new System.Drawing.Size(70, 17);
            this.rb_emprunt.TabIndex = 7;
            this.rb_emprunt.TabStop = true;
            this.rb_emprunt.Text = "Emprunté";
            this.rb_emprunt.UseVisualStyleBackColor = true;
            this.rb_emprunt.CheckedChanged += new System.EventHandler(this.rb_emprunt_CheckedChanged);
            // 
            // rd_dispo
            // 
            this.rd_dispo.AutoSize = true;
            this.rd_dispo.Location = new System.Drawing.Point(18, 29);
            this.rd_dispo.Name = "rd_dispo";
            this.rd_dispo.Size = new System.Drawing.Size(74, 17);
            this.rd_dispo.TabIndex = 6;
            this.rd_dispo.TabStop = true;
            this.rd_dispo.Text = "Disponible";
            this.rd_dispo.UseVisualStyleBackColor = true;
            this.rd_dispo.CheckedChanged += new System.EventHandler(this.rd_dispo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Liste des livres";
            // 
            // listBox_idLivre
            // 
            this.listBox_idLivre.FormattingEnabled = true;
            this.listBox_idLivre.Location = new System.Drawing.Point(661, 62);
            this.listBox_idLivre.Name = "listBox_idLivre";
            this.listBox_idLivre.Size = new System.Drawing.Size(21, 134);
            this.listBox_idLivre.TabIndex = 16;
            this.listBox_idLivre.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date de mise au rebus";
            // 
            // tb_DateRebus
            // 
            this.tb_DateRebus.Location = new System.Drawing.Point(166, 169);
            this.tb_DateRebus.Name = "tb_DateRebus";
            this.tb_DateRebus.ReadOnly = true;
            this.tb_DateRebus.Size = new System.Drawing.Size(218, 20);
            this.tb_DateRebus.TabIndex = 20;
            // 
            // tb_DateEdition
            // 
            this.tb_DateEdition.Location = new System.Drawing.Point(166, 129);
            this.tb_DateEdition.Name = "tb_DateEdition";
            this.tb_DateEdition.ReadOnly = true;
            this.tb_DateEdition.Size = new System.Drawing.Size(218, 20);
            this.tb_DateEdition.TabIndex = 23;
            // 
            // tb_DateEmp
            // 
            this.tb_DateEmp.Location = new System.Drawing.Point(166, 87);
            this.tb_DateEmp.Name = "tb_DateEmp";
            this.tb_DateEmp.ReadOnly = true;
            this.tb_DateEmp.Size = new System.Drawing.Size(218, 20);
            this.tb_DateEmp.TabIndex = 24;
            // 
            // tb_DateEnreg
            // 
            this.tb_DateEnreg.Location = new System.Drawing.Point(168, 45);
            this.tb_DateEnreg.Name = "tb_DateEnreg";
            this.tb_DateEnreg.ReadOnly = true;
            this.tb_DateEnreg.Size = new System.Drawing.Size(216, 20);
            this.tb_DateEnreg.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date d\'enregistrement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "emprunté le";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Date d\'édition";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Edition);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Pary);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_AboEmp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_DateEnreg);
            this.groupBox1.Controls.Add(this.tb_DateRebus);
            this.groupBox1.Controls.Add(this.tb_DateEmp);
            this.groupBox1.Controls.Add(this.tb_DateEdition);
            this.groupBox1.Location = new System.Drawing.Point(30, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 213);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information sur le livre";
            // 
            // tb_AboEmp
            // 
            this.tb_AboEmp.Location = new System.Drawing.Point(443, 87);
            this.tb_AboEmp.Name = "tb_AboEmp";
            this.tb_AboEmp.ReadOnly = true;
            this.tb_AboEmp.Size = new System.Drawing.Size(176, 20);
            this.tb_AboEmp.TabIndex = 30;
            // 
            // Pary
            // 
            this.Pary.AutoSize = true;
            this.Pary.Location = new System.Drawing.Point(398, 90);
            this.Pary.Name = "Pary";
            this.Pary.Size = new System.Drawing.Size(23, 13);
            this.Pary.TabIndex = 31;
            this.Pary.Text = "Par";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Chez";
            // 
            // tb_Edition
            // 
            this.tb_Edition.Location = new System.Drawing.Point(443, 133);
            this.tb_Edition.Name = "tb_Edition";
            this.tb_Edition.ReadOnly = true;
            this.tb_Edition.Size = new System.Drawing.Size(176, 20);
            this.tb_Edition.TabIndex = 33;
            // 
            // bt_fermer
            // 
            this.bt_fermer.Location = new System.Drawing.Point(357, 488);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_fermer.TabIndex = 30;
            this.bt_fermer.Text = "Fermer";
            this.bt_fermer.UseVisualStyleBackColor = true;
            this.bt_fermer.Click += new System.EventHandler(this.bt_fermer_Click);
            // 
            // bt_dispo
            // 
            this.bt_dispo.Location = new System.Drawing.Point(421, 202);
            this.bt_dispo.Name = "bt_dispo";
            this.bt_dispo.Size = new System.Drawing.Size(151, 23);
            this.bt_dispo.TabIndex = 31;
            this.bt_dispo.Text = "Remettre en disponibilité";
            this.bt_dispo.UseVisualStyleBackColor = true;
            this.bt_dispo.Click += new System.EventHandler(this.bt_dispo_Click);
            // 
            // inventaire_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 552);
            this.Controls.Add(this.bt_dispo);
            this.Controls.Add(this.bt_fermer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_idLivre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_etat);
            this.Controls.Add(this.bt_rebus);
            this.Controls.Add(this.listbox_livres);
            this.Name = "inventaire_form";
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.inventaire_form_Load);
            this.gb_etat.ResumeLayout(false);
            this.gb_etat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_livres;
        private System.Windows.Forms.Button bt_rebus;
        private System.Windows.Forms.GroupBox gb_etat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_idLivre;
        private System.Windows.Forms.RadioButton rb_emprunt;
        private System.Windows.Forms.RadioButton rd_dispo;
        private System.Windows.Forms.RadioButton rb_rebus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_DateRebus;
        private System.Windows.Forms.TextBox tb_DateEdition;
        private System.Windows.Forms.TextBox tb_DateEmp;
        private System.Windows.Forms.TextBox tb_DateEnreg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Edition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Pary;
        private System.Windows.Forms.TextBox tb_AboEmp;
        private System.Windows.Forms.Button bt_fermer;
        private System.Windows.Forms.Button bt_dispo;
    }
}