namespace bibliothèque001
{
    partial class gestUsers_form
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
            this.bt_quit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new bibliothèque001.DataSet1();
            this.utilisateursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateursTableAdapter = new bibliothèque001.DataSet1TableAdapters.utilisateursTableAdapter();
            this.numUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pseudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(301, 230);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(75, 23);
            this.bt_quit.TabIndex = 0;
            this.bt_quit.Text = "Quitter";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numUserDataGridViewTextBoxColumn,
            this.pseudoDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilisateursBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(365, 168);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateursBindingSource
            // 
            this.utilisateursBindingSource.DataMember = "utilisateurs";
            this.utilisateursBindingSource.DataSource = this.dataSet1;
            // 
            // utilisateursTableAdapter
            // 
            this.utilisateursTableAdapter.ClearBeforeFill = true;
            // 
            // numUserDataGridViewTextBoxColumn
            // 
            this.numUserDataGridViewTextBoxColumn.DataPropertyName = "numUser";
            this.numUserDataGridViewTextBoxColumn.HeaderText = "numUser";
            this.numUserDataGridViewTextBoxColumn.Name = "numUserDataGridViewTextBoxColumn";
            this.numUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pseudoDataGridViewTextBoxColumn
            // 
            this.pseudoDataGridViewTextBoxColumn.DataPropertyName = "pseudo";
            this.pseudoDataGridViewTextBoxColumn.HeaderText = "pseudo";
            this.pseudoDataGridViewTextBoxColumn.Name = "pseudoDataGridViewTextBoxColumn";
            this.pseudoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gestUsers_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_quit);
            this.Name = "gestUsers_form";
            this.Text = "gestUsers_form";
            this.Load += new System.EventHandler(this.gestUsers_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateursBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource utilisateursBindingSource;
        private DataSet1TableAdapters.utilisateursTableAdapter utilisateursTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}