namespace Client
{
    partial class FormTable
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
            this.AddTablePanel = new System.Windows.Forms.Panel();
            this.cbIsNull = new System.Windows.Forms.ComboBox();
            this.TypeCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCnAddTable = new System.Windows.Forms.Button();
            this.btnAddTableOK = new System.Windows.Forms.Button();
            this.clLength = new System.Windows.Forms.TextBox();
            this.clName = new System.Windows.Forms.TextBox();
            this.addColumnBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbForeignKey = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDone = new System.Windows.Forms.Button();
            this.cbPrimaryKey = new System.Windows.Forms.ComboBox();
            this.cbUniqueKey = new System.Windows.Forms.ComboBox();
            this.AddTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTablePanel
            // 
            this.AddTablePanel.Controls.Add(this.panel2);
            this.AddTablePanel.Controls.Add(this.panel1);
            this.AddTablePanel.Controls.Add(this.label3);
            this.AddTablePanel.Controls.Add(this.dataGridView1);
            this.AddTablePanel.Controls.Add(this.TableName);
            this.AddTablePanel.Controls.Add(this.label4);
            this.AddTablePanel.Location = new System.Drawing.Point(12, 23);
            this.AddTablePanel.Name = "AddTablePanel";
            this.AddTablePanel.Size = new System.Drawing.Size(1005, 331);
            this.AddTablePanel.TabIndex = 2;
            // 
            // cbIsNull
            // 
            this.cbIsNull.FormattingEnabled = true;
            this.cbIsNull.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbIsNull.Location = new System.Drawing.Point(324, 36);
            this.cbIsNull.Name = "cbIsNull";
            this.cbIsNull.Size = new System.Drawing.Size(74, 21);
            this.cbIsNull.TabIndex = 22;
            // 
            // TypeCb
            // 
            this.TypeCb.FormattingEnabled = true;
            this.TypeCb.Items.AddRange(new object[] {
            "char",
            "varchar",
            "text",
            "binary",
            "image",
            "int",
            "bigint",
            "float",
            "date",
            "datetime",
            "time",
            "double"});
            this.TypeCb.Location = new System.Drawing.Point(135, 36);
            this.TypeCb.Name = "TypeCb";
            this.TypeCb.Size = new System.Drawing.Size(82, 21);
            this.TypeCb.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(745, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Columns";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(545, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(447, 272);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Length";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "IsNull";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Unique Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Primary Key";
            // 
            // btnCnAddTable
            // 
            this.btnCnAddTable.Location = new System.Drawing.Point(217, 144);
            this.btnCnAddTable.Name = "btnCnAddTable";
            this.btnCnAddTable.Size = new System.Drawing.Size(97, 39);
            this.btnCnAddTable.TabIndex = 14;
            this.btnCnAddTable.Text = "Cancel";
            this.btnCnAddTable.UseVisualStyleBackColor = true;
            this.btnCnAddTable.Click += new System.EventHandler(this.btnCnAddTable_Click);
            // 
            // btnAddTableOK
            // 
            this.btnAddTableOK.Location = new System.Drawing.Point(3, 144);
            this.btnAddTableOK.Name = "btnAddTableOK";
            this.btnAddTableOK.Size = new System.Drawing.Size(99, 39);
            this.btnAddTableOK.TabIndex = 13;
            this.btnAddTableOK.Text = "Ok";
            this.btnAddTableOK.UseVisualStyleBackColor = true;
            this.btnAddTableOK.Click += new System.EventHandler(this.btnAddTableOK_Click);
            // 
            // clLength
            // 
            this.clLength.Location = new System.Drawing.Point(233, 37);
            this.clLength.Name = "clLength";
            this.clLength.Size = new System.Drawing.Size(75, 20);
            this.clLength.TabIndex = 11;
            // 
            // clName
            // 
            this.clName.Location = new System.Drawing.Point(48, 36);
            this.clName.Name = "clName";
            this.clName.Size = new System.Drawing.Size(81, 20);
            this.clName.TabIndex = 9;
            // 
            // addColumnBtn
            // 
            this.addColumnBtn.Location = new System.Drawing.Point(433, 34);
            this.addColumnBtn.Name = "addColumnBtn";
            this.addColumnBtn.Size = new System.Drawing.Size(75, 23);
            this.addColumnBtn.TabIndex = 8;
            this.addColumnBtn.Text = "Add Column";
            this.addColumnBtn.UseVisualStyleBackColor = true;
            this.addColumnBtn.Click += new System.EventHandler(this.addColumnBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Column IsNull";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Column Length";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Column Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Column name";
            // 
            // TableName
            // 
            this.TableName.Location = new System.Drawing.Point(240, 27);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(100, 20);
            this.TableName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Table Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Foreign Key";
            // 
            // cbForeignKey
            // 
            this.cbForeignKey.FormattingEnabled = true;
            this.cbForeignKey.Location = new System.Drawing.Point(174, 88);
            this.cbForeignKey.Name = "cbForeignKey";
            this.cbForeignKey.Size = new System.Drawing.Size(121, 21);
            this.cbForeignKey.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbUniqueKey);
            this.panel1.Controls.Add(this.cbPrimaryKey);
            this.panel1.Controls.Add(this.cbForeignKey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCnAddTable);
            this.panel1.Controls.Add(this.btnAddTableOK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(60, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 203);
            this.panel1.TabIndex = 25;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDone);
            this.panel2.Controls.Add(this.addColumnBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbIsNull);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TypeCb);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.clName);
            this.panel2.Controls.Add(this.clLength);
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 108);
            this.panel2.TabIndex = 26;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(433, 76);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 23;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cbPrimaryKey
            // 
            this.cbPrimaryKey.FormattingEnabled = true;
            this.cbPrimaryKey.Location = new System.Drawing.Point(174, 32);
            this.cbPrimaryKey.Name = "cbPrimaryKey";
            this.cbPrimaryKey.Size = new System.Drawing.Size(121, 21);
            this.cbPrimaryKey.TabIndex = 25;
            // 
            // cbUniqueKey
            // 
            this.cbUniqueKey.FormattingEnabled = true;
            this.cbUniqueKey.Location = new System.Drawing.Point(174, 60);
            this.cbUniqueKey.Name = "cbUniqueKey";
            this.cbUniqueKey.Size = new System.Drawing.Size(121, 21);
            this.cbUniqueKey.TabIndex = 26;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 487);
            this.Controls.Add(this.AddTablePanel);
            this.Name = "FormTable";
            this.Text = "FormTable";
            this.AddTablePanel.ResumeLayout(false);
            this.AddTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddTablePanel;
        private System.Windows.Forms.Button btnCnAddTable;
        private System.Windows.Forms.Button btnAddTableOK;
        private System.Windows.Forms.TextBox clLength;
        private System.Windows.Forms.TextBox clName;
        private System.Windows.Forms.Button addColumnBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeCb;
        private System.Windows.Forms.ComboBox cbIsNull;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbForeignKey;
        private System.Windows.Forms.ComboBox cbUniqueKey;
        private System.Windows.Forms.ComboBox cbPrimaryKey;
    }
}