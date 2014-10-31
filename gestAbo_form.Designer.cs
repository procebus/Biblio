namespace bibliothèque001
{
    partial class gestAbo_form
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
            this.bt_resiliation = new System.Windows.Forms.Button();
            this.bt_apply = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_infoAbo = new System.Windows.Forms.GroupBox();
            this.tb_codeAbo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.listView_abo = new System.Windows.Forms.ListView();
            this.Col_idAbo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nomprenomAbo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_infoAbo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_resiliation
            // 
            this.bt_resiliation.Location = new System.Drawing.Point(223, 406);
            this.bt_resiliation.Name = "bt_resiliation";
            this.bt_resiliation.Size = new System.Drawing.Size(75, 23);
            this.bt_resiliation.TabIndex = 5;
            this.bt_resiliation.Text = "Résiliser";
            this.bt_resiliation.UseVisualStyleBackColor = true;
            this.bt_resiliation.Click += new System.EventHandler(this.bt_resiliation_Click);
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(333, 406);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(146, 23);
            this.bt_apply.TabIndex = 6;
            this.bt_apply.Text = "Appliquer les modifications";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(530, 406);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 7;
            this.bt_close.Text = "Fermer";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Liste des abonnés";
            // 
            // gb_infoAbo
            // 
            this.gb_infoAbo.Controls.Add(this.tb_codeAbo);
            this.gb_infoAbo.Controls.Add(this.label6);
            this.gb_infoAbo.Controls.Add(this.label5);
            this.gb_infoAbo.Controls.Add(this.label2);
            this.gb_infoAbo.Controls.Add(this.label4);
            this.gb_infoAbo.Controls.Add(this.tb_nom);
            this.gb_infoAbo.Controls.Add(this.label3);
            this.gb_infoAbo.Controls.Add(this.tb_prenom);
            this.gb_infoAbo.Controls.Add(this.tb_tel);
            this.gb_infoAbo.Controls.Add(this.tb_date);
            this.gb_infoAbo.Location = new System.Drawing.Point(318, 65);
            this.gb_infoAbo.Name = "gb_infoAbo";
            this.gb_infoAbo.Size = new System.Drawing.Size(330, 250);
            this.gb_infoAbo.TabIndex = 9;
            this.gb_infoAbo.TabStop = false;
            this.gb_infoAbo.Text = "Informations sur l\'abonné";
            // 
            // tb_codeAbo
            // 
            this.tb_codeAbo.Location = new System.Drawing.Point(122, 36);
            this.tb_codeAbo.Name = "tb_codeAbo";
            this.tb_codeAbo.ReadOnly = true;
            this.tb_codeAbo.Size = new System.Drawing.Size(53, 20);
            this.tb_codeAbo.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Identifiant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date d\'inscription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Téléphone";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(122, 74);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.ReadOnly = true;
            this.tb_nom.Size = new System.Drawing.Size(154, 20);
            this.tb_nom.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prénom";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(122, 112);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.ReadOnly = true;
            this.tb_prenom.Size = new System.Drawing.Size(154, 20);
            this.tb_prenom.TabIndex = 14;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(122, 147);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(154, 20);
            this.tb_tel.TabIndex = 15;
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(122, 196);
            this.tb_date.Name = "tb_date";
            this.tb_date.ReadOnly = true;
            this.tb_date.Size = new System.Drawing.Size(154, 20);
            this.tb_date.TabIndex = 16;
            // 
            // listView_abo
            // 
            this.listView_abo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_idAbo,
            this.col_nomprenomAbo});
            this.listView_abo.Location = new System.Drawing.Point(43, 65);
            this.listView_abo.Name = "listView_abo";
            this.listView_abo.Size = new System.Drawing.Size(255, 312);
            this.listView_abo.TabIndex = 10;
            this.listView_abo.UseCompatibleStateImageBehavior = false;
            this.listView_abo.View = System.Windows.Forms.View.Details;
            this.listView_abo.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_abo_ItemSelectionChanged);
            this.listView_abo.SelectedIndexChanged += new System.EventHandler(this.listView_abo_SelectedIndexChanged);
            // 
            // Col_idAbo
            // 
            this.Col_idAbo.Text = "Id";
            // 
            // col_nomprenomAbo
            // 
            this.col_nomprenomAbo.Text = "Nom et prénom";
            this.col_nomprenomAbo.Width = 141;
            // 
            // gestAbo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 498);
            this.Controls.Add(this.listView_abo);
            this.Controls.Add(this.gb_infoAbo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_resiliation);
            this.Name = "gestAbo_form";
            this.Text = "Gestion des Abonnés";
            this.Load += new System.EventHandler(this.gestAbo_form_Load);
            this.gb_infoAbo.ResumeLayout(false);
            this.gb_infoAbo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_resiliation;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_infoAbo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_codeAbo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView_abo;
        private System.Windows.Forms.ColumnHeader Col_idAbo;
        private System.Windows.Forms.ColumnHeader col_nomprenomAbo;
    }
}