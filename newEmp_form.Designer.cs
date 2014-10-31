namespace bibliothèque001
{
    partial class newEmp_form
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
            this.bt_Enregistrer = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.tb_codeEmp = new System.Windows.Forms.TextBox();
            this.tb_DateEmp = new System.Windows.Forms.TextBox();
            this.cb_abo = new System.Windows.Forms.ComboBox();
            this.comboBox_idAbo = new System.Windows.Forms.ComboBox();
            this.tb_idAbo = new System.Windows.Forms.TextBox();
            this.tb_idLiv = new System.Windows.Forms.TextBox();
            this.comboBox_livre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_idlivre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_etatLiv = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attribuer un Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abonné";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date d\'emprunt";
            // 
            // bt_Enregistrer
            // 
            this.bt_Enregistrer.Location = new System.Drawing.Point(82, 207);
            this.bt_Enregistrer.Name = "bt_Enregistrer";
            this.bt_Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.bt_Enregistrer.TabIndex = 3;
            this.bt_Enregistrer.Text = "Enregistrer";
            this.bt_Enregistrer.UseVisualStyleBackColor = true;
            this.bt_Enregistrer.Click += new System.EventHandler(this.bt_Enregistrer_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(216, 207);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Fermer";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // tb_codeEmp
            // 
            this.tb_codeEmp.Location = new System.Drawing.Point(156, 162);
            this.tb_codeEmp.Name = "tb_codeEmp";
            this.tb_codeEmp.Size = new System.Drawing.Size(85, 20);
            this.tb_codeEmp.TabIndex = 5;
            // 
            // tb_DateEmp
            // 
            this.tb_DateEmp.Location = new System.Drawing.Point(156, 130);
            this.tb_DateEmp.Name = "tb_DateEmp";
            this.tb_DateEmp.ReadOnly = true;
            this.tb_DateEmp.Size = new System.Drawing.Size(171, 20);
            this.tb_DateEmp.TabIndex = 6;
            // 
            // cb_abo
            // 
            this.cb_abo.FormattingEnabled = true;
            this.cb_abo.Location = new System.Drawing.Point(156, 90);
            this.cb_abo.Name = "cb_abo";
            this.cb_abo.Size = new System.Drawing.Size(157, 21);
            this.cb_abo.TabIndex = 7;
            this.cb_abo.SelectedIndexChanged += new System.EventHandler(this.cb_abo_SelectedIndexChanged);
            // 
            // comboBox_idAbo
            // 
            this.comboBox_idAbo.FormattingEnabled = true;
            this.comboBox_idAbo.Location = new System.Drawing.Point(340, 90);
            this.comboBox_idAbo.Name = "comboBox_idAbo";
            this.comboBox_idAbo.Size = new System.Drawing.Size(54, 21);
            this.comboBox_idAbo.TabIndex = 8;
            this.comboBox_idAbo.Visible = false;
            // 
            // tb_idAbo
            // 
            this.tb_idAbo.Location = new System.Drawing.Point(409, 91);
            this.tb_idAbo.Name = "tb_idAbo";
            this.tb_idAbo.ReadOnly = true;
            this.tb_idAbo.Size = new System.Drawing.Size(52, 20);
            this.tb_idAbo.TabIndex = 9;
            this.tb_idAbo.Visible = false;
            // 
            // tb_idLiv
            // 
            this.tb_idLiv.Location = new System.Drawing.Point(409, 21);
            this.tb_idLiv.Name = "tb_idLiv";
            this.tb_idLiv.ReadOnly = true;
            this.tb_idLiv.Size = new System.Drawing.Size(52, 20);
            this.tb_idLiv.TabIndex = 10;
            this.tb_idLiv.Visible = false;
            // 
            // comboBox_livre
            // 
            this.comboBox_livre.FormattingEnabled = true;
            this.comboBox_livre.Location = new System.Drawing.Point(156, 20);
            this.comboBox_livre.Name = "comboBox_livre";
            this.comboBox_livre.Size = new System.Drawing.Size(157, 21);
            this.comboBox_livre.TabIndex = 11;
            this.comboBox_livre.SelectedIndexChanged += new System.EventHandler(this.comboBox_livre_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Titre du livre";
            // 
            // comboBox_idlivre
            // 
            this.comboBox_idlivre.FormattingEnabled = true;
            this.comboBox_idlivre.Location = new System.Drawing.Point(340, 20);
            this.comboBox_idlivre.Name = "comboBox_idlivre";
            this.comboBox_idlivre.Size = new System.Drawing.Size(54, 21);
            this.comboBox_idlivre.TabIndex = 13;
            this.comboBox_idlivre.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "etat du livre";
            // 
            // tb_etatLiv
            // 
            this.tb_etatLiv.Location = new System.Drawing.Point(156, 52);
            this.tb_etatLiv.Name = "tb_etatLiv";
            this.tb_etatLiv.Size = new System.Drawing.Size(157, 20);
            this.tb_etatLiv.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // newEmp_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 270);
            this.Controls.Add(this.tb_etatLiv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_idlivre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_livre);
            this.Controls.Add(this.tb_idLiv);
            this.Controls.Add(this.tb_idAbo);
            this.Controls.Add(this.comboBox_idAbo);
            this.Controls.Add(this.cb_abo);
            this.Controls.Add(this.tb_DateEmp);
            this.Controls.Add(this.tb_codeEmp);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_Enregistrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newEmp_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvel emprunt";
            this.Load += new System.EventHandler(this.newEmp_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Enregistrer;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.TextBox tb_codeEmp;
        private System.Windows.Forms.TextBox tb_DateEmp;
        private System.Windows.Forms.ComboBox cb_abo;
        private System.Windows.Forms.ComboBox comboBox_idAbo;
        private System.Windows.Forms.TextBox tb_idAbo;
        private System.Windows.Forms.TextBox tb_idLiv;
        private System.Windows.Forms.ComboBox comboBox_livre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_idlivre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_etatLiv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}