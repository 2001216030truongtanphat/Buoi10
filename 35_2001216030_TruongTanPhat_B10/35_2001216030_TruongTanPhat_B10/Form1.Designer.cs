namespace _35_2001216030_TruongTanPhat_B10
{
    partial class Form1
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
            this.Create = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.dgvIDN = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRUDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDNDataSet = new _35_2001216030_TruongTanPhat_B10.IDNDataSet();
            this.cRUDTableAdapter = new _35_2001216030_TruongTanPhat_B10.IDNDataSetTableAdapters.CRUDTableAdapter();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDNDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(99, 13);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(131, 62);
            this.Create.TabIndex = 0;
            this.Create.Text = "&C";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.create_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(275, 12);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(131, 62);
            this.Read.TabIndex = 1;
            this.Read.Text = "&R";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.read_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(275, 114);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(131, 62);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "&D";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(99, 114);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(131, 62);
            this.Update.TabIndex = 3;
            this.Update.Text = "&U";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.update_Click);
            // 
            // dgvIDN
            // 
            this.dgvIDN.AutoGenerateColumns = false;
            this.dgvIDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvIDN.DataSource = this.cRUDBindingSource;
            this.dgvIDN.Location = new System.Drawing.Point(99, 241);
            this.dgvIDN.Name = "dgvIDN";
            this.dgvIDN.Size = new System.Drawing.Size(412, 89);
            this.dgvIDN.TabIndex = 4;
            this.dgvIDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // cRUDBindingSource
            // 
            this.cRUDBindingSource.DataMember = "CRUD";
            this.cRUDBindingSource.DataSource = this.iDNDataSet;
            // 
            // iDNDataSet
            // 
            this.iDNDataSet.DataSetName = "IDNDataSet";
            this.iDNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRUDTableAdapter
            // 
            this.cRUDTableAdapter.ClearBeforeFill = true;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(497, 79);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 5;
            this.connect.Text = "CN";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(365, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(58, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(441, 366);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 506);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.dgvIDN);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDNDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView dgvIDN;
        private IDNDataSet iDNDataSet;
        private System.Windows.Forms.BindingSource cRUDBindingSource;
        private IDNDataSetTableAdapters.CRUDTableAdapter cRUDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

