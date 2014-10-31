namespace bibliothèque001
{
    partial class relances_form
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
            this.cb_relances = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_abo = new System.Windows.Forms.ListBox();
            this.tb_livreEmp = new System.Windows.Forms.TextBox();
            this.tb_dateEmp = new System.Windows.Forms.TextBox();
            this.bt_resiliation = new System.Windows.Forms.Button();
            this.bt_relancer = new System.Windows.Forms.Button();
            this.bt_quit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_Code = new System.Windows.Forms.ListBox();
            this.tb_idAbo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_relances
            // 
            this.cb_relances.FormattingEnabled = true;
            this.cb_relances.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_relances.Location = new System.Drawing.Point(154, 46);
            this.cb_relances.Name = "cb_relances";
            this.cb_relances.Size = new System.Drawing.Size(48, 21);
            this.cb_relances.TabIndex = 0;
            this.cb_relances.SelectedIndexChanged += new System.EventHandler(this.cb_relances_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de relances";
            // 
            // lb_abo
            // 
            this.lb_abo.FormattingEnabled = true;
            this.lb_abo.Location = new System.Drawing.Point(39, 124);
            this.lb_abo.Name = "lb_abo";
            this.lb_abo.Size = new System.Drawing.Size(202, 186);
            this.lb_abo.TabIndex = 2;
            this.lb_abo.SelectedIndexChanged += new System.EventHandler(this.lb_abo_SelectedIndexChanged);
            // 
            // tb_livreEmp
            // 
            this.tb_livreEmp.Location = new System.Drawing.Point(399, 121);
            this.tb_livreEmp.Name = "tb_livreEmp";
            this.tb_livreEmp.ReadOnly = true;
            this.tb_livreEmp.Size = new System.Drawing.Size(239, 20);
            this.tb_livreEmp.TabIndex = 3;
            // 
            // tb_dateEmp
            // 
            this.tb_dateEmp.Location = new System.Drawing.Point(399, 168);
            this.tb_dateEmp.Name = "tb_dateEmp";
            this.tb_dateEmp.ReadOnly = true;
            this.tb_dateEmp.Size = new System.Drawing.Size(239, 20);
            this.tb_dateEmp.TabIndex = 4;
            // 
            // bt_resiliation
            // 
            this.bt_resiliation.Location = new System.Drawing.Point(264, 230);
            this.bt_resiliation.Name = "bt_resiliation";
            this.bt_resiliation.Size = new System.Drawing.Size(110, 23);
            this.bt_resiliation.TabIndex = 5;
            this.bt_resiliation.Text = "Résilier l\'abonné";
            this.bt_resiliation.UseVisualStyleBackColor = true;
            this.bt_resiliation.Click += new System.EventHandler(this.bt_resiliation_Click);
            // 
            // bt_relancer
            // 
            this.bt_relancer.Location = new System.Drawing.Point(265, 277);
            this.bt_relancer.Name = "bt_relancer";
            this.bt_relancer.Size = new System.Drawing.Size(109, 23);
            this.bt_relancer.TabIndex = 6;
            this.bt_relancer.Text = "Relancer l\'abonné";
            this.bt_relancer.UseVisualStyleBackColor = true;
            this.bt_relancer.Click += new System.EventHandler(this.bt_relancer_Click);
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(503, 277);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(75, 23);
            this.bt_quit.TabIndex = 7;
            this.bt_quit.Text = "Fermer";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Abonnés concernés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Titre du livre emprunté";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date d\'emprunt";
            // 
            // listBox_Code
            // 
            this.listBox_Code.FormattingEnabled = true;
            this.listBox_Code.Location = new System.Drawing.Point(3, 133);
            this.listBox_Code.Name = "listBox_Code";
            this.listBox_Code.Size = new System.Drawing.Size(30, 173);
            this.listBox_Code.TabIndex = 11;
            this.listBox_Code.Visible = false;
            // 
            // tb_idAbo
            // 
            this.tb_idAbo.Location = new System.Drawing.Point(274, 75);
            this.tb_idAbo.Name = "tb_idAbo";
            this.tb_idAbo.ReadOnly = true;
            this.tb_idAbo.Size = new System.Drawing.Size(100, 20);
            this.tb_idAbo.TabIndex = 12;
            this.tb_idAbo.Visible = false;
            // 
            // relances_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 357);
            this.Controls.Add(this.tb_idAbo);
            this.Controls.Add(this.listBox_Code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.bt_relancer);
            this.Controls.Add(this.bt_resiliation);
            this.Controls.Add(this.tb_dateEmp);
            this.Controls.Add(this.tb_livreEmp);
            this.Controls.Add(this.lb_abo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_relances);
            this.Name = "relances_form";
            this.Text = "Relances en Cours";
            this.Load += new System.EventHandler(this.relances_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_relances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_abo;
        private System.Windows.Forms.TextBox tb_livreEmp;
        private System.Windows.Forms.TextBox tb_dateEmp;
        private System.Windows.Forms.Button bt_resiliation;
        private System.Windows.Forms.Button bt_relancer;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_Code;
        private System.Windows.Forms.TextBox tb_idAbo;
    }
}