namespace OBS_Database
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstID = new System.Windows.Forms.ListBox();
            this.selectAllOrtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obsDataSet = new OBS_Database.obsDataSet();
            this.selectAllOrtTableAdapter = new OBS_Database.obsDataSetTableAdapters.selectAllOrtTableAdapter();
            this.txtOID = new System.Windows.Forms.TextBox();
            this.txtOName = new System.Windows.Forms.TextBox();
            this.txtOPLZ = new System.Windows.Forms.TextBox();
            this.txtOEZahl = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstName = new System.Windows.Forms.ListBox();
            this.lstPLZ = new System.Windows.Forms.ListBox();
            this.lstEZahl = new System.Windows.Forms.ListBox();
            this.btn_delete_ort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllOrtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstID
            // 
            this.lstID.DataSource = this.selectAllOrtBindingSource;
            this.lstID.DisplayMember = "OID";
            this.lstID.FormattingEnabled = true;
            this.lstID.Location = new System.Drawing.Point(34, 156);
            this.lstID.Name = "lstID";
            this.lstID.Size = new System.Drawing.Size(80, 355);
            this.lstID.TabIndex = 0;
            this.lstID.ValueMember = "OID";
            // 
            // selectAllOrtBindingSource
            // 
            this.selectAllOrtBindingSource.DataMember = "selectAllOrt";
            this.selectAllOrtBindingSource.DataSource = this.obsDataSet;
            // 
            // obsDataSet
            // 
            this.obsDataSet.DataSetName = "obsDataSet";
            this.obsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectAllOrtTableAdapter
            // 
            this.selectAllOrtTableAdapter.ClearBeforeFill = true;
            // 
            // txtOID
            // 
            this.txtOID.Location = new System.Drawing.Point(11, 47);
            this.txtOID.Name = "txtOID";
            this.txtOID.Size = new System.Drawing.Size(80, 20);
            this.txtOID.TabIndex = 1;
            // 
            // txtOName
            // 
            this.txtOName.Location = new System.Drawing.Point(106, 47);
            this.txtOName.Name = "txtOName";
            this.txtOName.Size = new System.Drawing.Size(136, 20);
            this.txtOName.TabIndex = 2;
            // 
            // txtOPLZ
            // 
            this.txtOPLZ.Location = new System.Drawing.Point(256, 47);
            this.txtOPLZ.Name = "txtOPLZ";
            this.txtOPLZ.Size = new System.Drawing.Size(136, 20);
            this.txtOPLZ.TabIndex = 3;
            // 
            // txtOEZahl
            // 
            this.txtOEZahl.Location = new System.Drawing.Point(417, 47);
            this.txtOEZahl.Name = "txtOEZahl";
            this.txtOEZahl.Size = new System.Drawing.Size(136, 20);
            this.txtOEZahl.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(705, 47);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 20);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "OID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "OName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "OPLZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "OEZahl";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOID);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOName);
            this.groupBox1.Controls.Add(this.txtOPLZ);
            this.groupBox1.Controls.Add(this.txtOEZahl);
            this.groupBox1.Location = new System.Drawing.Point(23, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ort";
            // 
            // lstName
            // 
            this.lstName.DataSource = this.selectAllOrtBindingSource;
            this.lstName.DisplayMember = "OName";
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(130, 156);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(135, 355);
            this.lstName.TabIndex = 11;
            this.lstName.ValueMember = "OID";
            // 
            // lstPLZ
            // 
            this.lstPLZ.DataSource = this.selectAllOrtBindingSource;
            this.lstPLZ.DisplayMember = "OPLZ";
            this.lstPLZ.FormattingEnabled = true;
            this.lstPLZ.Location = new System.Drawing.Point(279, 156);
            this.lstPLZ.Name = "lstPLZ";
            this.lstPLZ.Size = new System.Drawing.Size(136, 355);
            this.lstPLZ.TabIndex = 12;
            this.lstPLZ.ValueMember = "OID";
            // 
            // lstEZahl
            // 
            this.lstEZahl.DataSource = this.selectAllOrtBindingSource;
            this.lstEZahl.DisplayMember = "OEZahl";
            this.lstEZahl.FormattingEnabled = true;
            this.lstEZahl.Location = new System.Drawing.Point(440, 156);
            this.lstEZahl.Name = "lstEZahl";
            this.lstEZahl.Size = new System.Drawing.Size(136, 355);
            this.lstEZahl.TabIndex = 13;
            this.lstEZahl.ValueMember = "OID";
            // 
            // btn_delete_ort
            // 
            this.btn_delete_ort.Location = new System.Drawing.Point(728, 226);
            this.btn_delete_ort.Name = "btn_delete_ort";
            this.btn_delete_ort.Size = new System.Drawing.Size(103, 24);
            this.btn_delete_ort.TabIndex = 14;
            this.btn_delete_ort.Text = "Delete Ort";
            this.btn_delete_ort.UseVisualStyleBackColor = true;
            this.btn_delete_ort.Click += new System.EventHandler(this.btn_delete_ort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 547);
            this.Controls.Add(this.btn_delete_ort);
            this.Controls.Add(this.lstEZahl);
            this.Controls.Add(this.lstPLZ);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstID);
            this.Name = "Form1";
            this.Text = "OBS-DB-SP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectAllOrtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstID;
        private obsDataSet obsDataSet;
        private System.Windows.Forms.BindingSource selectAllOrtBindingSource;
        private obsDataSetTableAdapters.selectAllOrtTableAdapter selectAllOrtTableAdapter;
        private System.Windows.Forms.TextBox txtOID;
        private System.Windows.Forms.TextBox txtOName;
        private System.Windows.Forms.TextBox txtOPLZ;
        private System.Windows.Forms.TextBox txtOEZahl;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.ListBox lstPLZ;
        private System.Windows.Forms.ListBox lstEZahl;
        private System.Windows.Forms.Button btn_delete_ort;
    }
}

