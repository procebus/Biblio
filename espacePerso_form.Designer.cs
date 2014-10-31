namespace bibliothèque001
{
    partial class espacePerso_form
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
            this.bienvenu_lb = new System.Windows.Forms.Label();
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.lb_abonne = new System.Windows.Forms.Label();
            this.bt_decnx = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.gb_relances = new System.Windows.Forms.GroupBox();
            this.bt_affRelance = new System.Windows.Forms.Button();
            this.lb_relances = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_login.SuspendLayout();
            this.gb_relances.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bienvenu_lb
            // 
            this.bienvenu_lb.AutoSize = true;
            this.bienvenu_lb.Location = new System.Drawing.Point(123, 30);
            this.bienvenu_lb.Name = "bienvenu_lb";
            this.bienvenu_lb.Size = new System.Drawing.Size(52, 13);
            this.bienvenu_lb.TabIndex = 0;
            this.bienvenu_lb.Text = "Bienvenu";
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.lb_abonne);
            this.gb_login.Controls.Add(this.bt_decnx);
            this.gb_login.Controls.Add(this.lb_id);
            this.gb_login.Controls.Add(this.bienvenu_lb);
            this.gb_login.Location = new System.Drawing.Point(583, 12);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(343, 111);
            this.gb_login.TabIndex = 1;
            this.gb_login.TabStop = false;
            // 
            // lb_abonne
            // 
            this.lb_abonne.AutoSize = true;
            this.lb_abonne.Location = new System.Drawing.Point(190, 30);
            this.lb_abonne.Name = "lb_abonne";
            this.lb_abonne.Size = new System.Drawing.Size(35, 13);
            this.lb_abonne.TabIndex = 3;
            this.lb_abonne.Text = "label3";
            this.lb_abonne.Click += new System.EventHandler(this.lb_abonne_Click);
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
            this.lb_id.Location = new System.Drawing.Point(81, 71);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(35, 13);
            this.lb_id.TabIndex = 1;
            this.lb_id.Text = "label1";
            this.lb_id.Visible = false;
            // 
            // gb_relances
            // 
            this.gb_relances.Controls.Add(this.bt_affRelance);
            this.gb_relances.Controls.Add(this.lb_relances);
            this.gb_relances.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_relances.Location = new System.Drawing.Point(583, 152);
            this.gb_relances.Name = "gb_relances";
            this.gb_relances.Size = new System.Drawing.Size(344, 99);
            this.gb_relances.TabIndex = 2;
            this.gb_relances.TabStop = false;
            this.gb_relances.Text = "Courrier";
            // 
            // bt_affRelance
            // 
            this.bt_affRelance.Enabled = false;
            this.bt_affRelance.Location = new System.Drawing.Point(234, 39);
            this.bt_affRelance.Name = "bt_affRelance";
            this.bt_affRelance.Size = new System.Drawing.Size(75, 23);
            this.bt_affRelance.TabIndex = 1;
            this.bt_affRelance.Text = "Afficher";
            this.bt_affRelance.UseVisualStyleBackColor = true;
            this.bt_affRelance.Click += new System.EventHandler(this.bt_affRelance_Click);
            // 
            // lb_relances
            // 
            this.lb_relances.AutoSize = true;
            this.lb_relances.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_relances.Location = new System.Drawing.Point(50, 44);
            this.lb_relances.Name = "lb_relances";
            this.lb_relances.Size = new System.Drawing.Size(125, 13);
            this.lb_relances.TabIndex = 0;
            this.lb_relances.Text = "Vous avez O relance";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(95, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mes outils";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Mes emprunts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Catalogue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Accès à mes emprunts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accès au catalogue de la bibliothèque";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(86, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 111);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bibliothèque001.Properties.Resources.logo_biblio;
            this.pictureBox1.Location = new System.Drawing.Point(697, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 168);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // espacePerso_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 599);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_relances);
            this.Controls.Add(this.gb_login);
            this.Name = "espacePerso_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espace Personnel";
            this.Load += new System.EventHandler(this.espacePerso_form_Load);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.gb_relances.ResumeLayout(false);
            this.gb_relances.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bienvenu_lb;
        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Button bt_decnx;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.GroupBox gb_relances;
        private System.Windows.Forms.Button bt_affRelance;
        private System.Windows.Forms.Label lb_relances;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_abonne;
    }
}