namespace bibliothèque001
{
    partial class lstEmp_form
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
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.bt_decnx = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.bienvenu_lb = new System.Windows.Forms.Label();
            this.bt_relances = new System.Windows.Forms.Button();
            this.bt_relAbo = new System.Windows.Forms.Button();
            this.bt_newEmp = new System.Windows.Forms.Button();
            this.bt_enregRetour = new System.Windows.Forms.Button();
            this.bt_quit = new System.Windows.Forms.Button();
            this.bt_rechEmp = new System.Windows.Forms.Button();
            this.listView_emp = new System.Windows.Forms.ListView();
            this.col_codeLiv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_abo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_dateEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_titlivre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_recharger = new System.Windows.Forms.Button();
            this.gb_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.bt_decnx);
            this.gb_login.Controls.Add(this.lb_id);
            this.gb_login.Controls.Add(this.bienvenu_lb);
            this.gb_login.Location = new System.Drawing.Point(563, 31);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(343, 111);
            this.gb_login.TabIndex = 3;
            this.gb_login.TabStop = false;
            // 
            // bt_decnx
            // 
            this.bt_decnx.Location = new System.Drawing.Point(205, 71);
            this.bt_decnx.Name = "bt_decnx";
            this.bt_decnx.Size = new System.Drawing.Size(104, 24);
            this.bt_decnx.TabIndex = 2;
            this.bt_decnx.Text = "Se déconnecter";
            this.bt_decnx.UseVisualStyleBackColor = true;
            this.bt_decnx.Click += new System.EventHandler(this.bt_decnx_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(157, 30);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(35, 13);
            this.lb_id.TabIndex = 1;
            this.lb_id.Text = "label1";
            // 
            // bienvenu_lb
            // 
            this.bienvenu_lb.AutoSize = true;
            this.bienvenu_lb.Location = new System.Drawing.Point(81, 30);
            this.bienvenu_lb.Name = "bienvenu_lb";
            this.bienvenu_lb.Size = new System.Drawing.Size(52, 13);
            this.bienvenu_lb.TabIndex = 0;
            this.bienvenu_lb.Text = "Bienvenu";
            // 
            // bt_relances
            // 
            this.bt_relances.Location = new System.Drawing.Point(608, 168);
            this.bt_relances.Name = "bt_relances";
            this.bt_relances.Size = new System.Drawing.Size(112, 36);
            this.bt_relances.TabIndex = 4;
            this.bt_relances.Text = "Relances en cours";
            this.bt_relances.UseVisualStyleBackColor = true;
            this.bt_relances.Click += new System.EventHandler(this.bt_relances_Click);
            // 
            // bt_relAbo
            // 
            this.bt_relAbo.Location = new System.Drawing.Point(754, 168);
            this.bt_relAbo.Name = "bt_relAbo";
            this.bt_relAbo.Size = new System.Drawing.Size(112, 36);
            this.bt_relAbo.TabIndex = 5;
            this.bt_relAbo.Text = "Relancer l\'abonné";
            this.bt_relAbo.UseVisualStyleBackColor = true;
            this.bt_relAbo.Click += new System.EventHandler(this.bt_relAbo_Click);
            // 
            // bt_newEmp
            // 
            this.bt_newEmp.Location = new System.Drawing.Point(754, 231);
            this.bt_newEmp.Name = "bt_newEmp";
            this.bt_newEmp.Size = new System.Drawing.Size(112, 36);
            this.bt_newEmp.TabIndex = 7;
            this.bt_newEmp.Text = "Enregistrer un emprunt";
            this.bt_newEmp.UseVisualStyleBackColor = true;
            this.bt_newEmp.Click += new System.EventHandler(this.bt_newEmp_Click);
            // 
            // bt_enregRetour
            // 
            this.bt_enregRetour.Location = new System.Drawing.Point(608, 231);
            this.bt_enregRetour.Name = "bt_enregRetour";
            this.bt_enregRetour.Size = new System.Drawing.Size(112, 36);
            this.bt_enregRetour.TabIndex = 6;
            this.bt_enregRetour.Text = "Enregistrer un retour";
            this.bt_enregRetour.UseVisualStyleBackColor = true;
            this.bt_enregRetour.Click += new System.EventHandler(this.bt_enregRetour_Click);
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(685, 296);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(112, 36);
            this.bt_quit.TabIndex = 8;
            this.bt_quit.Text = "Retour à l\'espace";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // bt_rechEmp
            // 
            this.bt_rechEmp.Enabled = false;
            this.bt_rechEmp.Location = new System.Drawing.Point(52, 438);
            this.bt_rechEmp.Name = "bt_rechEmp";
            this.bt_rechEmp.Size = new System.Drawing.Size(112, 36);
            this.bt_rechEmp.TabIndex = 9;
            this.bt_rechEmp.Text = "Rechercher";
            this.bt_rechEmp.UseVisualStyleBackColor = true;
            this.bt_rechEmp.Click += new System.EventHandler(this.bt_rechEmp_Click);
            // 
            // listView_emp
            // 
            this.listView_emp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_codeLiv,
            this.col_abo,
            this.col_dateEmp,
            this.col_titlivre});
            this.listView_emp.Location = new System.Drawing.Point(36, 61);
            this.listView_emp.Name = "listView_emp";
            this.listView_emp.Size = new System.Drawing.Size(487, 344);
            this.listView_emp.TabIndex = 10;
            this.listView_emp.UseCompatibleStateImageBehavior = false;
            this.listView_emp.View = System.Windows.Forms.View.Details;
            // 
            // col_codeLiv
            // 
            this.col_codeLiv.Text = "Code";
            this.col_codeLiv.Width = 80;
            // 
            // col_abo
            // 
            this.col_abo.Text = "Abonné";
            this.col_abo.Width = 121;
            // 
            // col_dateEmp
            // 
            this.col_dateEmp.Text = "Date d\'emprunt";
            this.col_dateEmp.Width = 124;
            // 
            // col_titlivre
            // 
            this.col_titlivre.Text = "Titre du livre";
            this.col_titlivre.Width = 158;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bibliothèque001.Properties.Resources.logo_biblio;
            this.pictureBox1.Location = new System.Drawing.Point(662, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 139);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Liste des emprunts";
            // 
            // bt_recharger
            // 
            this.bt_recharger.Location = new System.Drawing.Point(170, 438);
            this.bt_recharger.Name = "bt_recharger";
            this.bt_recharger.Size = new System.Drawing.Size(114, 36);
            this.bt_recharger.TabIndex = 13;
            this.bt_recharger.Text = "Recharger";
            this.bt_recharger.UseVisualStyleBackColor = true;
            this.bt_recharger.Click += new System.EventHandler(this.bt_recharger_Click);
            // 
            // lstEmp_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 566);
            this.Controls.Add(this.bt_recharger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView_emp);
            this.Controls.Add(this.bt_rechEmp);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.bt_newEmp);
            this.Controls.Add(this.bt_enregRetour);
            this.Controls.Add(this.bt_relAbo);
            this.Controls.Add(this.bt_relances);
            this.Controls.Add(this.gb_login);
            this.Name = "lstEmp_form";
            this.Text = "Bibliothèque - Emprunts";
            this.Load += new System.EventHandler(this.lstEmp_form_Load);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Button bt_decnx;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label bienvenu_lb;
        private System.Windows.Forms.Button bt_relances;
        private System.Windows.Forms.Button bt_relAbo;
        private System.Windows.Forms.Button bt_newEmp;
        private System.Windows.Forms.Button bt_enregRetour;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.Button bt_rechEmp;
        private System.Windows.Forms.ListView listView_emp;
        private System.Windows.Forms.ColumnHeader col_codeLiv;
        private System.Windows.Forms.ColumnHeader col_abo;
        private System.Windows.Forms.ColumnHeader col_dateEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_recharger;
        private System.Windows.Forms.ColumnHeader col_titlivre;
    }
}