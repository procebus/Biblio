namespace bibliothèque001
{
    partial class rechEmp_form
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
            this.rb_codeEmp = new System.Windows.Forms.RadioButton();
            this.rb_Abo = new System.Windows.Forms.RadioButton();
            this.rb_date = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_codeEmp
            // 
            this.rb_codeEmp.AutoSize = true;
            this.rb_codeEmp.Location = new System.Drawing.Point(52, 84);
            this.rb_codeEmp.Name = "rb_codeEmp";
            this.rb_codeEmp.Size = new System.Drawing.Size(50, 17);
            this.rb_codeEmp.TabIndex = 0;
            this.rb_codeEmp.TabStop = true;
            this.rb_codeEmp.Text = "Code";
            this.rb_codeEmp.UseVisualStyleBackColor = true;
            // 
            // rb_Abo
            // 
            this.rb_Abo.AutoSize = true;
            this.rb_Abo.Location = new System.Drawing.Point(52, 122);
            this.rb_Abo.Name = "rb_Abo";
            this.rb_Abo.Size = new System.Drawing.Size(62, 17);
            this.rb_Abo.TabIndex = 1;
            this.rb_Abo.TabStop = true;
            this.rb_Abo.Text = "Abonné";
            this.rb_Abo.UseVisualStyleBackColor = true;
            // 
            // rb_date
            // 
            this.rb_date.AutoSize = true;
            this.rb_date.Location = new System.Drawing.Point(52, 161);
            this.rb_date.Name = "rb_date";
            this.rb_date.Size = new System.Drawing.Size(48, 17);
            this.rb_date.TabIndex = 2;
            this.rb_date.TabStop = true;
            this.rb_date.Text = "Date";
            this.rb_date.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(265, 45);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 147);
            this.textBox4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(318, 217);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 8;
            this.bt_cancel.Text = "Fermer";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rechercher par :";
            // 
            // rechEmp_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rb_date);
            this.Controls.Add(this.rb_Abo);
            this.Controls.Add(this.rb_codeEmp);
            this.Name = "rechEmp_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rechercher un emprunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_codeEmp;
        private System.Windows.Forms.RadioButton rb_Abo;
        private System.Windows.Forms.RadioButton rb_date;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label1;
    }
}