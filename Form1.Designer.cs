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
            this.gp_ort = new System.Windows.Forms.GroupBox();
            this.lstName = new System.Windows.Forms.ListBox();
            this.lstPLZ = new System.Windows.Forms.ListBox();
            this.lstEZahl = new System.Windows.Forms.ListBox();
            this.btn_delete_ort = new System.Windows.Forms.Button();
            this.gp_bezirk = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gp_strasse = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllOrtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).BeginInit();
            this.gp_ort.SuspendLayout();
            this.gp_bezirk.SuspendLayout();
            this.gp_strasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstID
            // 
            this.lstID.DataSource = this.selectAllOrtBindingSource;
            this.lstID.DisplayMember = "OID";
            this.lstID.FormattingEnabled = true;
            this.lstID.Location = new System.Drawing.Point(34, 234);
            this.lstID.Name = "lstID";
            this.lstID.Size = new System.Drawing.Size(80, 277);
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
            this.txtOID.Location = new System.Drawing.Point(9, 32);
            this.txtOID.Name = "txtOID";
            this.txtOID.Size = new System.Drawing.Size(80, 20);
            this.txtOID.TabIndex = 1;
            // 
            // txtOName
            // 
            this.txtOName.Location = new System.Drawing.Point(104, 32);
            this.txtOName.Name = "txtOName";
            this.txtOName.Size = new System.Drawing.Size(136, 20);
            this.txtOName.TabIndex = 2;
            // 
            // txtOPLZ
            // 
            this.txtOPLZ.Location = new System.Drawing.Point(254, 32);
            this.txtOPLZ.Name = "txtOPLZ";
            this.txtOPLZ.Size = new System.Drawing.Size(136, 20);
            this.txtOPLZ.TabIndex = 3;
            // 
            // txtOEZahl
            // 
            this.txtOEZahl.Location = new System.Drawing.Point(415, 32);
            this.txtOEZahl.Name = "txtOEZahl";
            this.txtOEZahl.Size = new System.Drawing.Size(136, 20);
            this.txtOEZahl.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(570, 32);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 20);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert Ort";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ort ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ort Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ort PLZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ort Einwohnerzahl";
            // 
            // gp_ort
            // 
            this.gp_ort.Controls.Add(this.txtOID);
            this.gp_ort.Controls.Add(this.btnInsert);
            this.gp_ort.Controls.Add(this.label1);
            this.gp_ort.Controls.Add(this.label2);
            this.gp_ort.Controls.Add(this.label3);
            this.gp_ort.Controls.Add(this.label4);
            this.gp_ort.Controls.Add(this.txtOName);
            this.gp_ort.Controls.Add(this.txtOPLZ);
            this.gp_ort.Controls.Add(this.txtOEZahl);
            this.gp_ort.Location = new System.Drawing.Point(23, 32);
            this.gp_ort.Name = "gp_ort";
            this.gp_ort.Size = new System.Drawing.Size(684, 59);
            this.gp_ort.TabIndex = 10;
            this.gp_ort.TabStop = false;
            this.gp_ort.Text = "Ort";
            // 
            // lstName
            // 
            this.lstName.DataSource = this.selectAllOrtBindingSource;
            this.lstName.DisplayMember = "OName";
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(130, 234);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(135, 277);
            this.lstName.TabIndex = 11;
            this.lstName.ValueMember = "OID";
            // 
            // lstPLZ
            // 
            this.lstPLZ.DataSource = this.selectAllOrtBindingSource;
            this.lstPLZ.DisplayMember = "OPLZ";
            this.lstPLZ.FormattingEnabled = true;
            this.lstPLZ.Location = new System.Drawing.Point(279, 234);
            this.lstPLZ.Name = "lstPLZ";
            this.lstPLZ.Size = new System.Drawing.Size(136, 277);
            this.lstPLZ.TabIndex = 12;
            this.lstPLZ.ValueMember = "OID";
            // 
            // lstEZahl
            // 
            this.lstEZahl.DataSource = this.selectAllOrtBindingSource;
            this.lstEZahl.DisplayMember = "OEZahl";
            this.lstEZahl.FormattingEnabled = true;
            this.lstEZahl.Location = new System.Drawing.Point(440, 234);
            this.lstEZahl.Name = "lstEZahl";
            this.lstEZahl.Size = new System.Drawing.Size(136, 277);
            this.lstEZahl.TabIndex = 13;
            this.lstEZahl.ValueMember = "OID";
            // 
            // btn_delete_ort
            // 
            this.btn_delete_ort.Location = new System.Drawing.Point(593, 315);
            this.btn_delete_ort.Name = "btn_delete_ort";
            this.btn_delete_ort.Size = new System.Drawing.Size(103, 24);
            this.btn_delete_ort.TabIndex = 14;
            this.btn_delete_ort.Text = "Delete Ort";
            this.btn_delete_ort.UseVisualStyleBackColor = true;
            this.btn_delete_ort.Click += new System.EventHandler(this.btn_delete_ort_Click);
            // 
            // gp_bezirk
            // 
            this.gp_bezirk.Controls.Add(this.textBox1);
            this.gp_bezirk.Controls.Add(this.button1);
            this.gp_bezirk.Controls.Add(this.label5);
            this.gp_bezirk.Controls.Add(this.label6);
            this.gp_bezirk.Controls.Add(this.label7);
            this.gp_bezirk.Controls.Add(this.label8);
            this.gp_bezirk.Controls.Add(this.textBox2);
            this.gp_bezirk.Controls.Add(this.textBox3);
            this.gp_bezirk.Controls.Add(this.textBox4);
            this.gp_bezirk.Location = new System.Drawing.Point(23, 97);
            this.gp_bezirk.Name = "gp_bezirk";
            this.gp_bezirk.Size = new System.Drawing.Size(684, 59);
            this.gp_bezirk.TabIndex = 15;
            this.gp_bezirk.TabStop = false;
            this.gp_bezirk.Text = "Bezirk";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Insert Bezirk";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bezirk ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bezirk Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bezirks PLZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bezirk Einwohnerzahl";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(254, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(415, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 20);
            this.textBox4.TabIndex = 4;
            // 
            // gp_strasse
            // 
            this.gp_strasse.Controls.Add(this.textBox5);
            this.gp_strasse.Controls.Add(this.button2);
            this.gp_strasse.Controls.Add(this.label9);
            this.gp_strasse.Controls.Add(this.label10);
            this.gp_strasse.Controls.Add(this.label11);
            this.gp_strasse.Controls.Add(this.label12);
            this.gp_strasse.Controls.Add(this.textBox6);
            this.gp_strasse.Controls.Add(this.textBox7);
            this.gp_strasse.Controls.Add(this.textBox8);
            this.gp_strasse.Location = new System.Drawing.Point(23, 162);
            this.gp_strasse.Name = "gp_strasse";
            this.gp_strasse.Size = new System.Drawing.Size(684, 59);
            this.gp_strasse.TabIndex = 16;
            this.gp_strasse.TabStop = false;
            this.gp_strasse.Text = "Strasse";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 20);
            this.textBox5.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "Insert Straße";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Strasse ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Strasse Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Strasse PLZ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Strasse Einwohnerzahl";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(104, 32);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(136, 20);
            this.textBox6.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(254, 32);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(136, 20);
            this.textBox7.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(415, 32);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(136, 20);
            this.textBox8.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 547);
            this.Controls.Add(this.gp_strasse);
            this.Controls.Add(this.gp_bezirk);
            this.Controls.Add(this.btn_delete_ort);
            this.Controls.Add(this.lstEZahl);
            this.Controls.Add(this.lstPLZ);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.gp_ort);
            this.Controls.Add(this.lstID);
            this.Name = "Form1";
            this.Text = "OBS-DB-SP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectAllOrtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).EndInit();
            this.gp_ort.ResumeLayout(false);
            this.gp_ort.PerformLayout();
            this.gp_bezirk.ResumeLayout(false);
            this.gp_bezirk.PerformLayout();
            this.gp_strasse.ResumeLayout(false);
            this.gp_strasse.PerformLayout();
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
        private System.Windows.Forms.GroupBox gp_ort;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.ListBox lstPLZ;
        private System.Windows.Forms.ListBox lstEZahl;
        private System.Windows.Forms.Button btn_delete_ort;
        private System.Windows.Forms.GroupBox gp_bezirk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox gp_strasse;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
}

