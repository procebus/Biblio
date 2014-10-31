namespace bibliothèque001
{
    partial class espaceAdmin_form
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
            this.gb_liv = new System.Windows.Forms.GroupBox();
            this.bt_inventaire = new System.Windows.Forms.Button();
            this.bt_catalogue = new System.Windows.Forms.Button();
            this.bt_refLiv = new System.Windows.Forms.Button();
            this.bt_commande = new System.Windows.Forms.Button();
            this.gb_abo = new System.Windows.Forms.GroupBox();
            this.bt_users = new System.Windows.Forms.Button();
            this.bt_gestAbo = new System.Windows.Forms.Button();
            this.bt_newAbo = new System.Windows.Forms.Button();
            this.gb_emp = new System.Windows.Forms.GroupBox();
            this.bt_retourEmp = new System.Windows.Forms.Button();
            this.bt_rel = new System.Windows.Forms.Button();
            this.bt_newEmp = new System.Windows.Forms.Button();
            this.bt_stats = new System.Windows.Forms.Button();
            this.bt_lstEmp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_login.SuspendLayout();
            this.gb_liv.SuspendLayout();
            this.gb_abo.SuspendLayout();
            this.gb_emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.bt_decnx);
            this.gb_login.Controls.Add(this.lb_id);
            this.gb_login.Controls.Add(this.bienvenu_lb);
            this.gb_login.Location = new System.Drawing.Point(455, 31);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(343, 111);
            this.gb_login.TabIndex = 2;
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
            // gb_liv
            // 
            this.gb_liv.Controls.Add(this.bt_inventaire);
            this.gb_liv.Controls.Add(this.bt_catalogue);
            this.gb_liv.Controls.Add(this.bt_refLiv);
            this.gb_liv.Controls.Add(this.bt_commande);
            this.gb_liv.Location = new System.Drawing.Point(25, 22);
            this.gb_liv.Name = "gb_liv";
            this.gb_liv.Size = new System.Drawing.Size(389, 151);
            this.gb_liv.TabIndex = 3;
            this.gb_liv.TabStop = false;
            this.gb_liv.Text = "Gestion des livres";
            // 
            // bt_inventaire
            // 
            this.bt_inventaire.Location = new System.Drawing.Point(201, 94);
            this.bt_inventaire.Name = "bt_inventaire";
            this.bt_inventaire.Size = new System.Drawing.Size(144, 37);
            this.bt_inventaire.TabIndex = 3;
            this.bt_inventaire.Text = "Inventaire";
            this.bt_inventaire.UseVisualStyleBackColor = true;
            this.bt_inventaire.Click += new System.EventHandler(this.bt_inventaire_Click);
            // 
            // bt_catalogue
            // 
            this.bt_catalogue.Location = new System.Drawing.Point(201, 31);
            this.bt_catalogue.Name = "bt_catalogue";
            this.bt_catalogue.Size = new System.Drawing.Size(144, 37);
            this.bt_catalogue.TabIndex = 2;
            this.bt_catalogue.Text = "Catalogue";
            this.bt_catalogue.UseVisualStyleBackColor = true;
            this.bt_catalogue.Click += new System.EventHandler(this.bt_catalogue_Click);
            // 
            // bt_refLiv
            // 
            this.bt_refLiv.Location = new System.Drawing.Point(46, 94);
            this.bt_refLiv.Name = "bt_refLiv";
            this.bt_refLiv.Size = new System.Drawing.Size(144, 37);
            this.bt_refLiv.TabIndex = 1;
            this.bt_refLiv.Text = "Référencer un livre";
            this.bt_refLiv.UseVisualStyleBackColor = true;
            this.bt_refLiv.Click += new System.EventHandler(this.bt_refLiv_Click);
            // 
            // bt_commande
            // 
            this.bt_commande.Enabled = false;
            this.bt_commande.Location = new System.Drawing.Point(46, 32);
            this.bt_commande.Name = "bt_commande";
            this.bt_commande.Size = new System.Drawing.Size(144, 37);
            this.bt_commande.TabIndex = 0;
            this.bt_commande.Text = "Commande de livre";
            this.bt_commande.UseVisualStyleBackColor = true;
            this.bt_commande.Click += new System.EventHandler(this.bt_commande_Click);
            // 
            // gb_abo
            // 
            this.gb_abo.Controls.Add(this.bt_users);
            this.gb_abo.Controls.Add(this.bt_gestAbo);
            this.gb_abo.Controls.Add(this.bt_newAbo);
            this.gb_abo.Location = new System.Drawing.Point(25, 212);
            this.gb_abo.Name = "gb_abo";
            this.gb_abo.Size = new System.Drawing.Size(176, 204);
            this.gb_abo.TabIndex = 4;
            this.gb_abo.TabStop = false;
            this.gb_abo.Text = "Gestion des abonnements";
            // 
            // bt_users
            // 
            this.bt_users.Location = new System.Drawing.Point(31, 152);
            this.bt_users.Name = "bt_users";
            this.bt_users.Size = new System.Drawing.Size(110, 36);
            this.bt_users.TabIndex = 2;
            this.bt_users.Text = "Gérer les utilisateurs";
            this.bt_users.UseVisualStyleBackColor = true;
            this.bt_users.Click += new System.EventHandler(this.bt_users_Click);
            // 
            // bt_gestAbo
            // 
            this.bt_gestAbo.Location = new System.Drawing.Point(31, 95);
            this.bt_gestAbo.Name = "bt_gestAbo";
            this.bt_gestAbo.Size = new System.Drawing.Size(110, 40);
            this.bt_gestAbo.TabIndex = 1;
            this.bt_gestAbo.Text = "Gérer les abonnés";
            this.bt_gestAbo.UseVisualStyleBackColor = true;
            this.bt_gestAbo.Click += new System.EventHandler(this.bt_gestAbo_Click);
            // 
            // bt_newAbo
            // 
            this.bt_newAbo.Location = new System.Drawing.Point(31, 40);
            this.bt_newAbo.Name = "bt_newAbo";
            this.bt_newAbo.Size = new System.Drawing.Size(110, 39);
            this.bt_newAbo.TabIndex = 0;
            this.bt_newAbo.Text = "Créer un abonné";
            this.bt_newAbo.UseVisualStyleBackColor = true;
            this.bt_newAbo.Click += new System.EventHandler(this.bt_newAbo_Click);
            // 
            // gb_emp
            // 
            this.gb_emp.Controls.Add(this.bt_retourEmp);
            this.gb_emp.Controls.Add(this.bt_rel);
            this.gb_emp.Controls.Add(this.bt_newEmp);
            this.gb_emp.Controls.Add(this.bt_stats);
            this.gb_emp.Controls.Add(this.bt_lstEmp);
            this.gb_emp.Location = new System.Drawing.Point(226, 194);
            this.gb_emp.Name = "gb_emp";
            this.gb_emp.Size = new System.Drawing.Size(358, 222);
            this.gb_emp.TabIndex = 5;
            this.gb_emp.TabStop = false;
            this.gb_emp.Text = "Gestion des emprunts";
            // 
            // bt_retourEmp
            // 
            this.bt_retourEmp.Location = new System.Drawing.Point(201, 144);
            this.bt_retourEmp.Name = "bt_retourEmp";
            this.bt_retourEmp.Size = new System.Drawing.Size(107, 39);
            this.bt_retourEmp.TabIndex = 4;
            this.bt_retourEmp.Text = "Enregistrer un retour";
            this.bt_retourEmp.UseVisualStyleBackColor = true;
            this.bt_retourEmp.Click += new System.EventHandler(this.bt_retourEmp_Click);
            // 
            // bt_rel
            // 
            this.bt_rel.Location = new System.Drawing.Point(201, 85);
            this.bt_rel.Name = "bt_rel";
            this.bt_rel.Size = new System.Drawing.Size(107, 39);
            this.bt_rel.TabIndex = 3;
            this.bt_rel.Text = "Relances en cours";
            this.bt_rel.UseVisualStyleBackColor = true;
            this.bt_rel.Click += new System.EventHandler(this.bt_rel_Click);
            // 
            // bt_newEmp
            // 
            this.bt_newEmp.Location = new System.Drawing.Point(201, 27);
            this.bt_newEmp.Name = "bt_newEmp";
            this.bt_newEmp.Size = new System.Drawing.Size(107, 39);
            this.bt_newEmp.TabIndex = 2;
            this.bt_newEmp.Text = "Nouvel Emprunt";
            this.bt_newEmp.UseVisualStyleBackColor = true;
            this.bt_newEmp.Click += new System.EventHandler(this.bt_newEmp_Click);
            // 
            // bt_stats
            // 
            this.bt_stats.Enabled = false;
            this.bt_stats.Location = new System.Drawing.Point(26, 124);
            this.bt_stats.Name = "bt_stats";
            this.bt_stats.Size = new System.Drawing.Size(107, 39);
            this.bt_stats.TabIndex = 1;
            this.bt_stats.Text = "statistiques";
            this.bt_stats.UseVisualStyleBackColor = true;
            this.bt_stats.Click += new System.EventHandler(this.bt_stats_Click);
            // 
            // bt_lstEmp
            // 
            this.bt_lstEmp.Location = new System.Drawing.Point(26, 49);
            this.bt_lstEmp.Name = "bt_lstEmp";
            this.bt_lstEmp.Size = new System.Drawing.Size(107, 39);
            this.bt_lstEmp.TabIndex = 0;
            this.bt_lstEmp.Text = "liste des emprunts";
            this.bt_lstEmp.UseVisualStyleBackColor = true;
            this.bt_lstEmp.Click += new System.EventHandler(this.bt_lstEmp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bibliothèque001.Properties.Resources.logo_biblio;
            this.pictureBox1.Location = new System.Drawing.Point(627, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 173);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // espaceAdmin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_emp);
            this.Controls.Add(this.gb_abo);
            this.Controls.Add(this.gb_liv);
            this.Controls.Add(this.gb_login);
            this.Name = "espaceAdmin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Espace Bibliothèquaire";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.espaceAdmin_form_FormClosed);
            this.Load += new System.EventHandler(this.espaceAdmin_form_Load);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.gb_liv.ResumeLayout(false);
            this.gb_abo.ResumeLayout(false);
            this.gb_emp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Button bt_decnx;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label bienvenu_lb;
        private System.Windows.Forms.GroupBox gb_liv;
        private System.Windows.Forms.Button bt_inventaire;
        private System.Windows.Forms.Button bt_catalogue;
        private System.Windows.Forms.Button bt_refLiv;
        private System.Windows.Forms.Button bt_commande;
        private System.Windows.Forms.GroupBox gb_abo;
        private System.Windows.Forms.Button bt_gestAbo;
        private System.Windows.Forms.Button bt_newAbo;
        private System.Windows.Forms.GroupBox gb_emp;
        private System.Windows.Forms.Button bt_retourEmp;
        private System.Windows.Forms.Button bt_rel;
        private System.Windows.Forms.Button bt_newEmp;
        private System.Windows.Forms.Button bt_stats;
        private System.Windows.Forms.Button bt_lstEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_users;
    }
}