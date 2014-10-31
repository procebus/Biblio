namespace bibliothèque001
{
    partial class retourEmp_form
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
            this.cb_abo = new System.Windows.Forms.ComboBox();
            this.tb_dateRetour = new System.Windows.Forms.TextBox();
            this.ck_deteriore = new System.Windows.Forms.CheckBox();
            this.bt_Valider = new System.Windows.Forms.Button();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_idAo = new System.Windows.Forms.ComboBox();
            this.combobox_livres = new System.Windows.Forms.ComboBox();
            this.combobox_idlivre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_abo
            // 
            this.cb_abo.FormattingEnabled = true;
            this.cb_abo.Location = new System.Drawing.Point(173, 29);
            this.cb_abo.Name = "cb_abo";
            this.cb_abo.Size = new System.Drawing.Size(209, 21);
            this.cb_abo.TabIndex = 0;
            this.cb_abo.DropDown += new System.EventHandler(this.cb_abo_DropDown);
            this.cb_abo.SelectedIndexChanged += new System.EventHandler(this.cb_abo_SelectedIndexChanged);
            // 
            // tb_dateRetour
            // 
            this.tb_dateRetour.Location = new System.Drawing.Point(174, 90);
            this.tb_dateRetour.Name = "tb_dateRetour";
            this.tb_dateRetour.Size = new System.Drawing.Size(208, 20);
            this.tb_dateRetour.TabIndex = 1;
            // 
            // ck_deteriore
            // 
            this.ck_deteriore.AutoSize = true;
            this.ck_deteriore.Location = new System.Drawing.Point(44, 127);
            this.ck_deteriore.Name = "ck_deteriore";
            this.ck_deteriore.Size = new System.Drawing.Size(166, 17);
            this.ck_deteriore.TabIndex = 2;
            this.ck_deteriore.Text = "Cochez si le livre est détérioré";
            this.ck_deteriore.UseVisualStyleBackColor = true;
            // 
            // bt_Valider
            // 
            this.bt_Valider.Location = new System.Drawing.Point(107, 174);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(75, 23);
            this.bt_Valider.TabIndex = 3;
            this.bt_Valider.Text = "Valider";
            this.bt_Valider.UseVisualStyleBackColor = true;
            this.bt_Valider.Click += new System.EventHandler(this.bt_Valider_Click);
            // 
            // bt_Annuler
            // 
            this.bt_Annuler.Location = new System.Drawing.Point(221, 174);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_Annuler.TabIndex = 4;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = true;
            this.bt_Annuler.Click += new System.EventHandler(this.bt_Annuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sélectionner l\'abonné";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saisir la date de retour";
            // 
            // comboBox_idAo
            // 
            this.comboBox_idAo.FormattingEnabled = true;
            this.comboBox_idAo.Location = new System.Drawing.Point(388, 29);
            this.comboBox_idAo.Name = "comboBox_idAo";
            this.comboBox_idAo.Size = new System.Drawing.Size(21, 21);
            this.comboBox_idAo.TabIndex = 7;
            this.comboBox_idAo.Visible = false;
            // 
            // combobox_livres
            // 
            this.combobox_livres.FormattingEnabled = true;
            this.combobox_livres.Location = new System.Drawing.Point(174, 56);
            this.combobox_livres.Name = "combobox_livres";
            this.combobox_livres.Size = new System.Drawing.Size(208, 21);
            this.combobox_livres.TabIndex = 8;
            // 
            // combobox_idlivre
            // 
            this.combobox_idlivre.FormattingEnabled = true;
            this.combobox_idlivre.Location = new System.Drawing.Point(388, 55);
            this.combobox_idlivre.Name = "combobox_idlivre";
            this.combobox_idlivre.Size = new System.Drawing.Size(20, 21);
            this.combobox_idlivre.TabIndex = 9;
            this.combobox_idlivre.Visible = false;
            // 
            // retourEmp_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 233);
            this.Controls.Add(this.combobox_idlivre);
            this.Controls.Add(this.combobox_livres);
            this.Controls.Add(this.comboBox_idAo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Annuler);
            this.Controls.Add(this.bt_Valider);
            this.Controls.Add(this.ck_deteriore);
            this.Controls.Add(this.tb_dateRetour);
            this.Controls.Add(this.cb_abo);
            this.Name = "retourEmp_form";
            this.Text = "Enregistrer un retour de livre";
            this.Load += new System.EventHandler(this.retourEmp_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_abo;
        private System.Windows.Forms.TextBox tb_dateRetour;
        private System.Windows.Forms.CheckBox ck_deteriore;
        private System.Windows.Forms.Button bt_Valider;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_idAo;
        private System.Windows.Forms.ComboBox combobox_livres;
        private System.Windows.Forms.ComboBox combobox_idlivre;
    }
}