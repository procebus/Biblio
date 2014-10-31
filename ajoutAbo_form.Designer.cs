namespace bibliothèque001
{
    partial class ajoutAbo_form
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
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(167, 33);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(163, 20);
            this.tb_nom.TabIndex = 0;
            this.tb_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date du jour";
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(167, 167);
            this.tb_date.Name = "tb_date";
            this.tb_date.ReadOnly = true;
            this.tb_date.Size = new System.Drawing.Size(135, 20);
            this.tb_date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Téléphone";
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(167, 115);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(135, 20);
            this.tb_tel.TabIndex = 4;
            this.tb_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tel_KeyPress);
            this.tb_tel.Validating += new System.ComponentModel.CancelEventHandler(this.tb_tel_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prénom";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(167, 70);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(163, 20);
            this.tb_prenom.TabIndex = 6;
            this.tb_prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_prenom_KeyPress);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(81, 238);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 8;
            this.bt_save.Text = "Enregistrer";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(227, 238);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 9;
            this.bt_close.Text = "Fermer";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ajoutAbo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 307);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nom);
            this.Name = "ajoutAbo_form";
            this.Text = "Ajout d\'abonné";
            this.Load += new System.EventHandler(this.ajoutAbo_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}