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
            this.btnInsertOrt = new System.Windows.Forms.Button();
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
            this.cb_bezirk_fk = new System.Windows.Forms.ComboBox();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.btnInsertBezirk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.txtBPLZ = new System.Windows.Forms.TextBox();
            this.txtBEZahl = new System.Windows.Forms.TextBox();
            this.gp_strasse = new System.Windows.Forms.GroupBox();
            this.cb_strasse_fk = new System.Windows.Forms.ComboBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.btnInsertStrasse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtSPLZ = new System.Windows.Forms.TextBox();
            this.txtSEZahl = new System.Windows.Forms.TextBox();
            this.btnDeleteStrasse = new System.Windows.Forms.Button();
            this.btnDeleteBezirk = new System.Windows.Forms.Button();
            this.rb_ort = new System.Windows.Forms.RadioButton();
            this.rb_bezirk = new System.Windows.Forms.RadioButton();
            this.rb_strasse = new System.Windows.Forms.RadioButton();
            this.lstPK = new System.Windows.Forms.ListBox();
            this.selectAllBezirkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectAllBezirkTableAdapter = new OBS_Database.obsDataSetTableAdapters.selectAllBezirkTableAdapter();
            this.selectAllStrasseTableAdapter1 = new OBS_Database.obsDataSetTableAdapters.selectAllStrasseTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.selectAllOrtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).BeginInit();
            this.gp_ort.SuspendLayout();
            this.gp_bezirk.SuspendLayout();
            this.gp_strasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllBezirkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstID
            // 
            this.lstID.DataSource = this.selectAllOrtBindingSource;
            this.lstID.DisplayMember = "OID";
            this.lstID.FormattingEnabled = true;
            this.lstID.ItemHeight = 24;
            this.lstID.Location = new System.Drawing.Point(59, 432);
            this.lstID.Margin = new System.Windows.Forms.Padding(6);
            this.lstID.Name = "lstID";
            this.lstID.Size = new System.Drawing.Size(143, 508);
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
            this.txtOID.Location = new System.Drawing.Point(16, 59);
            this.txtOID.Margin = new System.Windows.Forms.Padding(6);
            this.txtOID.Name = "txtOID";
            this.txtOID.Size = new System.Drawing.Size(143, 29);
            this.txtOID.TabIndex = 1;
            // 
            // txtOName
            // 
            this.txtOName.Location = new System.Drawing.Point(385, 59);
            this.txtOName.Margin = new System.Windows.Forms.Padding(6);
            this.txtOName.Name = "txtOName";
            this.txtOName.Size = new System.Drawing.Size(246, 29);
            this.txtOName.TabIndex = 2;
            // 
            // txtOPLZ
            // 
            this.txtOPLZ.Location = new System.Drawing.Point(660, 59);
            this.txtOPLZ.Margin = new System.Windows.Forms.Padding(6);
            this.txtOPLZ.Name = "txtOPLZ";
            this.txtOPLZ.Size = new System.Drawing.Size(246, 29);
            this.txtOPLZ.TabIndex = 3;
            // 
            // txtOEZahl
            // 
            this.txtOEZahl.Location = new System.Drawing.Point(955, 59);
            this.txtOEZahl.Margin = new System.Windows.Forms.Padding(6);
            this.txtOEZahl.Name = "txtOEZahl";
            this.txtOEZahl.Size = new System.Drawing.Size(246, 29);
            this.txtOEZahl.TabIndex = 4;
            // 
            // btnInsertOrt
            // 
            this.btnInsertOrt.Location = new System.Drawing.Point(1239, 26);
            this.btnInsertOrt.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsertOrt.Name = "btnInsertOrt";
            this.btnInsertOrt.Size = new System.Drawing.Size(189, 70);
            this.btnInsertOrt.TabIndex = 5;
            this.btnInsertOrt.Text = "Ort einfügen";
            this.btnInsertOrt.UseVisualStyleBackColor = true;
            this.btnInsertOrt.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ort ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ort Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ort PLZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(950, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ort Einwohnerzahl";
            // 
            // gp_ort
            // 
            this.gp_ort.Controls.Add(this.txtOID);
            this.gp_ort.Controls.Add(this.btnInsertOrt);
            this.gp_ort.Controls.Add(this.label1);
            this.gp_ort.Controls.Add(this.label2);
            this.gp_ort.Controls.Add(this.label3);
            this.gp_ort.Controls.Add(this.label4);
            this.gp_ort.Controls.Add(this.txtOName);
            this.gp_ort.Controls.Add(this.txtOPLZ);
            this.gp_ort.Controls.Add(this.txtOEZahl);
            this.gp_ort.Location = new System.Drawing.Point(42, 59);
            this.gp_ort.Margin = new System.Windows.Forms.Padding(6);
            this.gp_ort.Name = "gp_ort";
            this.gp_ort.Padding = new System.Windows.Forms.Padding(6);
            this.gp_ort.Size = new System.Drawing.Size(1454, 109);
            this.gp_ort.TabIndex = 10;
            this.gp_ort.TabStop = false;
            this.gp_ort.Text = "Ort";
            // 
            // lstName
            // 
            this.lstName.DataSource = this.selectAllOrtBindingSource;
            this.lstName.DisplayMember = "OName";
            this.lstName.FormattingEnabled = true;
            this.lstName.ItemHeight = 24;
            this.lstName.Location = new System.Drawing.Point(429, 432);
            this.lstName.Margin = new System.Windows.Forms.Padding(6);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(244, 508);
            this.lstName.TabIndex = 11;
            this.lstName.ValueMember = "OID";
            // 
            // lstPLZ
            // 
            this.lstPLZ.DataSource = this.selectAllOrtBindingSource;
            this.lstPLZ.DisplayMember = "OPLZ";
            this.lstPLZ.FormattingEnabled = true;
            this.lstPLZ.ItemHeight = 24;
            this.lstPLZ.Location = new System.Drawing.Point(704, 432);
            this.lstPLZ.Margin = new System.Windows.Forms.Padding(6);
            this.lstPLZ.Name = "lstPLZ";
            this.lstPLZ.Size = new System.Drawing.Size(246, 508);
            this.lstPLZ.TabIndex = 12;
            this.lstPLZ.ValueMember = "OID";
            // 
            // lstEZahl
            // 
            this.lstEZahl.DataSource = this.selectAllOrtBindingSource;
            this.lstEZahl.DisplayMember = "OEZahl";
            this.lstEZahl.FormattingEnabled = true;
            this.lstEZahl.ItemHeight = 24;
            this.lstEZahl.Location = new System.Drawing.Point(999, 432);
            this.lstEZahl.Margin = new System.Windows.Forms.Padding(6);
            this.lstEZahl.Name = "lstEZahl";
            this.lstEZahl.Size = new System.Drawing.Size(246, 508);
            this.lstEZahl.TabIndex = 13;
            this.lstEZahl.ValueMember = "OID";
            // 
            // btn_delete_ort
            // 
            this.btn_delete_ort.Location = new System.Drawing.Point(1282, 593);
            this.btn_delete_ort.Margin = new System.Windows.Forms.Padding(6);
            this.btn_delete_ort.Name = "btn_delete_ort";
            this.btn_delete_ort.Size = new System.Drawing.Size(189, 44);
            this.btn_delete_ort.TabIndex = 14;
            this.btn_delete_ort.Text = "Ort löschen";
            this.btn_delete_ort.UseVisualStyleBackColor = true;
            this.btn_delete_ort.Click += new System.EventHandler(this.btn_delete_ort_Click);
            // 
            // gp_bezirk
            // 
            this.gp_bezirk.Controls.Add(this.cb_bezirk_fk);
            this.gp_bezirk.Controls.Add(this.txtBID);
            this.gp_bezirk.Controls.Add(this.btnInsertBezirk);
            this.gp_bezirk.Controls.Add(this.label5);
            this.gp_bezirk.Controls.Add(this.label6);
            this.gp_bezirk.Controls.Add(this.label7);
            this.gp_bezirk.Controls.Add(this.label8);
            this.gp_bezirk.Controls.Add(this.txtBName);
            this.gp_bezirk.Controls.Add(this.txtBPLZ);
            this.gp_bezirk.Controls.Add(this.txtBEZahl);
            this.gp_bezirk.Location = new System.Drawing.Point(42, 179);
            this.gp_bezirk.Margin = new System.Windows.Forms.Padding(6);
            this.gp_bezirk.Name = "gp_bezirk";
            this.gp_bezirk.Padding = new System.Windows.Forms.Padding(6);
            this.gp_bezirk.Size = new System.Drawing.Size(1454, 109);
            this.gp_bezirk.TabIndex = 15;
            this.gp_bezirk.TabStop = false;
            this.gp_bezirk.Text = "Bezirk";
            // 
            // cb_bezirk_fk
            // 
            this.cb_bezirk_fk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bezirk_fk.FormattingEnabled = true;
            this.cb_bezirk_fk.Location = new System.Drawing.Point(170, 59);
            this.cb_bezirk_fk.Margin = new System.Windows.Forms.Padding(6);
            this.cb_bezirk_fk.Name = "cb_bezirk_fk";
            this.cb_bezirk_fk.Size = new System.Drawing.Size(202, 32);
            this.cb_bezirk_fk.TabIndex = 10;
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(16, 59);
            this.txtBID.Margin = new System.Windows.Forms.Padding(6);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(143, 29);
            this.txtBID.TabIndex = 1;
            // 
            // btnInsertBezirk
            // 
            this.btnInsertBezirk.Location = new System.Drawing.Point(1239, 30);
            this.btnInsertBezirk.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsertBezirk.Name = "btnInsertBezirk";
            this.btnInsertBezirk.Size = new System.Drawing.Size(189, 66);
            this.btnInsertBezirk.TabIndex = 5;
            this.btnInsertBezirk.Text = "Bezirk einfügen";
            this.btnInsertBezirk.UseVisualStyleBackColor = true;
            this.btnInsertBezirk.Click += new System.EventHandler(this.btnInsertBezirk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bezirk ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bezirk Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(654, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bezirks PLZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(950, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bezirk Einwohnerzahl";
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(385, 59);
            this.txtBName.Margin = new System.Windows.Forms.Padding(6);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(246, 29);
            this.txtBName.TabIndex = 2;
            // 
            // txtBPLZ
            // 
            this.txtBPLZ.Location = new System.Drawing.Point(660, 59);
            this.txtBPLZ.Margin = new System.Windows.Forms.Padding(6);
            this.txtBPLZ.Name = "txtBPLZ";
            this.txtBPLZ.Size = new System.Drawing.Size(246, 29);
            this.txtBPLZ.TabIndex = 3;
            // 
            // txtBEZahl
            // 
            this.txtBEZahl.Location = new System.Drawing.Point(955, 59);
            this.txtBEZahl.Margin = new System.Windows.Forms.Padding(6);
            this.txtBEZahl.Name = "txtBEZahl";
            this.txtBEZahl.Size = new System.Drawing.Size(246, 29);
            this.txtBEZahl.TabIndex = 4;
            // 
            // gp_strasse
            // 
            this.gp_strasse.Controls.Add(this.cb_strasse_fk);
            this.gp_strasse.Controls.Add(this.txtSID);
            this.gp_strasse.Controls.Add(this.btnInsertStrasse);
            this.gp_strasse.Controls.Add(this.label9);
            this.gp_strasse.Controls.Add(this.label10);
            this.gp_strasse.Controls.Add(this.label11);
            this.gp_strasse.Controls.Add(this.label12);
            this.gp_strasse.Controls.Add(this.txtSName);
            this.gp_strasse.Controls.Add(this.txtSPLZ);
            this.gp_strasse.Controls.Add(this.txtSEZahl);
            this.gp_strasse.Location = new System.Drawing.Point(42, 299);
            this.gp_strasse.Margin = new System.Windows.Forms.Padding(6);
            this.gp_strasse.Name = "gp_strasse";
            this.gp_strasse.Padding = new System.Windows.Forms.Padding(6);
            this.gp_strasse.Size = new System.Drawing.Size(1454, 109);
            this.gp_strasse.TabIndex = 16;
            this.gp_strasse.TabStop = false;
            this.gp_strasse.Text = "Strasse";
            // 
            // cb_strasse_fk
            // 
            this.cb_strasse_fk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_strasse_fk.FormattingEnabled = true;
            this.cb_strasse_fk.Location = new System.Drawing.Point(170, 61);
            this.cb_strasse_fk.Margin = new System.Windows.Forms.Padding(6);
            this.cb_strasse_fk.Name = "cb_strasse_fk";
            this.cb_strasse_fk.Size = new System.Drawing.Size(202, 32);
            this.cb_strasse_fk.TabIndex = 11;
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(16, 59);
            this.txtSID.Margin = new System.Windows.Forms.Padding(6);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(143, 29);
            this.txtSID.TabIndex = 1;
            // 
            // btnInsertStrasse
            // 
            this.btnInsertStrasse.Location = new System.Drawing.Point(1238, 28);
            this.btnInsertStrasse.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsertStrasse.Name = "btnInsertStrasse";
            this.btnInsertStrasse.Size = new System.Drawing.Size(189, 68);
            this.btnInsertStrasse.TabIndex = 5;
            this.btnInsertStrasse.Text = "Strasse einfügen";
            this.btnInsertStrasse.UseVisualStyleBackColor = true;
            this.btnInsertStrasse.Click += new System.EventHandler(this.btnInsertStrasse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Strasse ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Strasse Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(653, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Strasse PLZ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(948, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Strasse Einwohnerzahl";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(383, 61);
            this.txtSName.Margin = new System.Windows.Forms.Padding(6);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(246, 29);
            this.txtSName.TabIndex = 2;
            // 
            // txtSPLZ
            // 
            this.txtSPLZ.Location = new System.Drawing.Point(658, 61);
            this.txtSPLZ.Margin = new System.Windows.Forms.Padding(6);
            this.txtSPLZ.Name = "txtSPLZ";
            this.txtSPLZ.Size = new System.Drawing.Size(246, 29);
            this.txtSPLZ.TabIndex = 3;
            // 
            // txtSEZahl
            // 
            this.txtSEZahl.Location = new System.Drawing.Point(953, 61);
            this.txtSEZahl.Margin = new System.Windows.Forms.Padding(6);
            this.txtSEZahl.Name = "txtSEZahl";
            this.txtSEZahl.Size = new System.Drawing.Size(246, 29);
            this.txtSEZahl.TabIndex = 4;
            // 
            // btnDeleteStrasse
            // 
            this.btnDeleteStrasse.Location = new System.Drawing.Point(1282, 593);
            this.btnDeleteStrasse.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteStrasse.Name = "btnDeleteStrasse";
            this.btnDeleteStrasse.Size = new System.Drawing.Size(189, 44);
            this.btnDeleteStrasse.TabIndex = 17;
            this.btnDeleteStrasse.Text = "Strasse löschen";
            this.btnDeleteStrasse.UseVisualStyleBackColor = true;
            this.btnDeleteStrasse.Click += new System.EventHandler(this.btnDeleteStrasse_Click);
            // 
            // btnDeleteBezirk
            // 
            this.btnDeleteBezirk.Location = new System.Drawing.Point(1282, 593);
            this.btnDeleteBezirk.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteBezirk.Name = "btnDeleteBezirk";
            this.btnDeleteBezirk.Size = new System.Drawing.Size(189, 44);
            this.btnDeleteBezirk.TabIndex = 18;
            this.btnDeleteBezirk.Text = "Bezirk löschen";
            this.btnDeleteBezirk.UseVisualStyleBackColor = true;
            this.btnDeleteBezirk.Click += new System.EventHandler(this.btnDeleteBezirk_Click);
            // 
            // rb_ort
            // 
            this.rb_ort.AutoSize = true;
            this.rb_ort.Checked = true;
            this.rb_ort.Location = new System.Drawing.Point(1282, 668);
            this.rb_ort.Margin = new System.Windows.Forms.Padding(6);
            this.rb_ort.Name = "rb_ort";
            this.rb_ort.Size = new System.Drawing.Size(128, 28);
            this.rb_ort.TabIndex = 19;
            this.rb_ort.TabStop = true;
            this.rb_ort.Text = "Anzeige Ort";
            this.rb_ort.UseVisualStyleBackColor = true;
            this.rb_ort.CheckedChanged += new System.EventHandler(this.radioStateChanged);
            // 
            // rb_bezirk
            // 
            this.rb_bezirk.AutoSize = true;
            this.rb_bezirk.Location = new System.Drawing.Point(1282, 711);
            this.rb_bezirk.Margin = new System.Windows.Forms.Padding(6);
            this.rb_bezirk.Name = "rb_bezirk";
            this.rb_bezirk.Size = new System.Drawing.Size(154, 28);
            this.rb_bezirk.TabIndex = 20;
            this.rb_bezirk.Text = "Anzeige Bezirk";
            this.rb_bezirk.UseVisualStyleBackColor = true;
            this.rb_bezirk.CheckedChanged += new System.EventHandler(this.radioStateChanged);
            // 
            // rb_strasse
            // 
            this.rb_strasse.AutoSize = true;
            this.rb_strasse.Location = new System.Drawing.Point(1282, 753);
            this.rb_strasse.Margin = new System.Windows.Forms.Padding(6);
            this.rb_strasse.Name = "rb_strasse";
            this.rb_strasse.Size = new System.Drawing.Size(164, 28);
            this.rb_strasse.TabIndex = 21;
            this.rb_strasse.Text = "Anzeige Strasse";
            this.rb_strasse.UseVisualStyleBackColor = true;
            this.rb_strasse.CheckedChanged += new System.EventHandler(this.radioStateChanged);
            // 
            // lstPK
            // 
            this.lstPK.DataSource = this.selectAllBezirkBindingSource;
            this.lstPK.DisplayMember = "BOID";
            this.lstPK.FormattingEnabled = true;
            this.lstPK.ItemHeight = 24;
            this.lstPK.Location = new System.Drawing.Point(213, 432);
            this.lstPK.Margin = new System.Windows.Forms.Padding(6);
            this.lstPK.Name = "lstPK";
            this.lstPK.Size = new System.Drawing.Size(202, 508);
            this.lstPK.TabIndex = 22;
            this.lstPK.ValueMember = "BOID";
            // 
            // selectAllBezirkBindingSource
            // 
            this.selectAllBezirkBindingSource.DataMember = "selectAllBezirk";
            this.selectAllBezirkBindingSource.DataSource = this.obsDataSet;
            // 
            // selectAllBezirkTableAdapter
            // 
            this.selectAllBezirkTableAdapter.ClearBeforeFill = true;
            // 
            // selectAllStrasseTableAdapter1
            // 
            this.selectAllStrasseTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 1010);
            this.Controls.Add(this.lstPK);
            this.Controls.Add(this.rb_strasse);
            this.Controls.Add(this.rb_bezirk);
            this.Controls.Add(this.rb_ort);
            this.Controls.Add(this.btnDeleteBezirk);
            this.Controls.Add(this.btnDeleteStrasse);
            this.Controls.Add(this.gp_strasse);
            this.Controls.Add(this.gp_bezirk);
            this.Controls.Add(this.btn_delete_ort);
            this.Controls.Add(this.lstEZahl);
            this.Controls.Add(this.lstPLZ);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.gp_ort);
            this.Controls.Add(this.lstID);
            this.Margin = new System.Windows.Forms.Padding(6);
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
            ((System.ComponentModel.ISupportInitialize)(this.selectAllBezirkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnInsertOrt;
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
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Button btnInsertBezirk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.TextBox txtBPLZ;
        private System.Windows.Forms.TextBox txtBEZahl;
        private System.Windows.Forms.GroupBox gp_strasse;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Button btnInsertStrasse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtSPLZ;
        private System.Windows.Forms.TextBox txtSEZahl;
        private System.Windows.Forms.Button btnDeleteStrasse;
        private System.Windows.Forms.Button btnDeleteBezirk;
        private System.Windows.Forms.RadioButton rb_ort;
        private System.Windows.Forms.RadioButton rb_bezirk;
        private System.Windows.Forms.RadioButton rb_strasse;
        private System.Windows.Forms.ComboBox cb_bezirk_fk;
        private System.Windows.Forms.ComboBox cb_strasse_fk;
        private System.Windows.Forms.ListBox lstPK;
        private System.Windows.Forms.BindingSource selectAllBezirkBindingSource;
        private obsDataSetTableAdapters.selectAllBezirkTableAdapter selectAllBezirkTableAdapter;
        private obsDataSetTableAdapters.selectAllStrasseTableAdapter selectAllStrasseTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

