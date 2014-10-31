namespace bibliothèque001
{
    partial class empAbo_form
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
            this.bt_quit = new System.Windows.Forms.Button();
            this.listView_mesEmprunts = new System.Windows.Forms.ListView();
            this.col_titres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_dateEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_dateretour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(528, 327);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(75, 23);
            this.bt_quit.TabIndex = 0;
            this.bt_quit.Text = "Fermer";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // listView_mesEmprunts
            // 
            this.listView_mesEmprunts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_titres,
            this.col_dateEmp,
            this.col_dateretour});
            this.listView_mesEmprunts.Location = new System.Drawing.Point(12, 21);
            this.listView_mesEmprunts.Name = "listView_mesEmprunts";
            this.listView_mesEmprunts.Size = new System.Drawing.Size(608, 282);
            this.listView_mesEmprunts.TabIndex = 1;
            this.listView_mesEmprunts.UseCompatibleStateImageBehavior = false;
            this.listView_mesEmprunts.View = System.Windows.Forms.View.Details;
            // 
            // col_titres
            // 
            this.col_titres.Text = "Titres";
            this.col_titres.Width = 234;
            // 
            // col_dateEmp
            // 
            this.col_dateEmp.Text = "Date d\'emprunt";
            this.col_dateEmp.Width = 161;
            // 
            // col_dateretour
            // 
            this.col_dateretour.Text = "Date de retour";
            this.col_dateretour.Width = 206;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(112, 337);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(35, 13);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "label1";
            // 
            // empAbo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 371);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.listView_mesEmprunts);
            this.Controls.Add(this.bt_quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "empAbo_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mes emprunts";
            this.Load += new System.EventHandler(this.empAbo_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.ListView listView_mesEmprunts;
        private System.Windows.Forms.ColumnHeader col_titres;
        private System.Windows.Forms.ColumnHeader col_dateEmp;
        private System.Windows.Forms.ColumnHeader col_dateretour;
        private System.Windows.Forms.Label lbId;
    }
}