namespace Client
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
            this.addDatabase = new System.Windows.Forms.Button();
            this.panelDeletedb = new System.Windows.Forms.Panel();
            this.txtDeletedb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletedbCn = new System.Windows.Forms.Button();
            this.btnDeletedbOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAdddb = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dbTextName = new System.Windows.Forms.TextBox();
            this.btnDbCn = new System.Windows.Forms.Button();
            this.dbName = new System.Windows.Forms.Label();
            this.btnDbOk = new System.Windows.Forms.Button();
            this.btnDeletedb = new System.Windows.Forms.Button();
            this.DatabasesPanel = new System.Windows.Forms.Panel();
            this.panelAlldataWithKey = new System.Windows.Forms.Panel();
            this.btnShowDataKey = new System.Windows.Forms.Button();
            this.dataGridViewwithKey = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.cbKeys = new System.Windows.Forms.ComboBox();
            this.panelData = new System.Windows.Forms.Panel();
            this.ForeignKeyIndexData = new System.Windows.Forms.Button();
            this.btnUniqueData = new System.Windows.Forms.Button();
            this.btnUniqueIndex = new System.Windows.Forms.Button();
            this.tbForeign = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUnique = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CancelViewData = new System.Windows.Forms.Button();
            this.keyText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelIndex = new System.Windows.Forms.Panel();
            this.IndexDatabaseName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbColumns = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelIndex = new System.Windows.Forms.Button();
            this.tableNameIndex = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOkIndex = new System.Windows.Forms.Button();
            this.indexColumnText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBasesTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuStripDatabase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabasesBtn = new System.Windows.Forms.Button();
            this.contextMenuTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropTableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllWithSpeccificKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDataSelectedColumns = new System.Windows.Forms.Panel();
            this.cbKey2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewSelectedColumns = new System.Windows.Forms.DataGridView();
            this.cbColumns2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColumnsData = new System.Windows.Forms.Button();
            this.panelDeletedb.SuspendLayout();
            this.panelAdddb.SuspendLayout();
            this.DatabasesPanel.SuspendLayout();
            this.panelAlldataWithKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewwithKey)).BeginInit();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelIndex.SuspendLayout();
            this.contextMenuStripDatabase.SuspendLayout();
            this.contextMenuTable.SuspendLayout();
            this.panelDataSelectedColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // addDatabase
            // 
            this.addDatabase.Location = new System.Drawing.Point(12, 12);
            this.addDatabase.Name = "addDatabase";
            this.addDatabase.Size = new System.Drawing.Size(113, 36);
            this.addDatabase.TabIndex = 0;
            this.addDatabase.Text = "ADD Database";
            this.addDatabase.UseVisualStyleBackColor = true;
            this.addDatabase.Click += new System.EventHandler(this.addDatabase_Click);
            // 
            // panelDeletedb
            // 
            this.panelDeletedb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDeletedb.Controls.Add(this.txtDeletedb);
            this.panelDeletedb.Controls.Add(this.label3);
            this.panelDeletedb.Controls.Add(this.btnDeletedbCn);
            this.panelDeletedb.Controls.Add(this.btnDeletedbOk);
            this.panelDeletedb.Controls.Add(this.label2);
            this.panelDeletedb.Location = new System.Drawing.Point(262, 12);
            this.panelDeletedb.Name = "panelDeletedb";
            this.panelDeletedb.Size = new System.Drawing.Size(282, 202);
            this.panelDeletedb.TabIndex = 1;
            this.panelDeletedb.Visible = false;
            // 
            // txtDeletedb
            // 
            this.txtDeletedb.Location = new System.Drawing.Point(148, 68);
            this.txtDeletedb.Name = "txtDeletedb";
            this.txtDeletedb.Size = new System.Drawing.Size(100, 20);
            this.txtDeletedb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database Name";
            // 
            // btnDeletedbCn
            // 
            this.btnDeletedbCn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletedbCn.Location = new System.Drawing.Point(162, 117);
            this.btnDeletedbCn.Name = "btnDeletedbCn";
            this.btnDeletedbCn.Size = new System.Drawing.Size(75, 23);
            this.btnDeletedbCn.TabIndex = 2;
            this.btnDeletedbCn.Text = "CANCEL";
            this.btnDeletedbCn.UseVisualStyleBackColor = true;
            this.btnDeletedbCn.Click += new System.EventHandler(this.btnDeletedbCn_Click);
            // 
            // btnDeletedbOk
            // 
            this.btnDeletedbOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletedbOk.Location = new System.Drawing.Point(25, 117);
            this.btnDeletedbOk.Name = "btnDeletedbOk";
            this.btnDeletedbOk.Size = new System.Drawing.Size(75, 23);
            this.btnDeletedbOk.TabIndex = 1;
            this.btnDeletedbOk.Text = "OK";
            this.btnDeletedbOk.UseVisualStyleBackColor = true;
            this.btnDeletedbOk.Click += new System.EventHandler(this.btnDeletedbOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Delete Database";
            // 
            // panelAdddb
            // 
            this.panelAdddb.Controls.Add(this.label1);
            this.panelAdddb.Controls.Add(this.dbTextName);
            this.panelAdddb.Controls.Add(this.btnDbCn);
            this.panelAdddb.Controls.Add(this.dbName);
            this.panelAdddb.Controls.Add(this.btnDbOk);
            this.panelAdddb.Location = new System.Drawing.Point(262, 12);
            this.panelAdddb.Name = "panelAdddb";
            this.panelAdddb.Size = new System.Drawing.Size(280, 200);
            this.panelAdddb.TabIndex = 4;
            this.panelAdddb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Database";
            // 
            // dbTextName
            // 
            this.dbTextName.Location = new System.Drawing.Point(148, 62);
            this.dbTextName.Name = "dbTextName";
            this.dbTextName.Size = new System.Drawing.Size(100, 20);
            this.dbTextName.TabIndex = 1;
            // 
            // btnDbCn
            // 
            this.btnDbCn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbCn.Location = new System.Drawing.Point(173, 135);
            this.btnDbCn.Name = "btnDbCn";
            this.btnDbCn.Size = new System.Drawing.Size(75, 34);
            this.btnDbCn.TabIndex = 3;
            this.btnDbCn.Text = "Cancel";
            this.btnDbCn.UseVisualStyleBackColor = true;
            this.btnDbCn.Click += new System.EventHandler(this.btnDbCn_Click);
            // 
            // dbName
            // 
            this.dbName.AutoSize = true;
            this.dbName.Location = new System.Drawing.Point(22, 62);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(84, 13);
            this.dbName.TabIndex = 0;
            this.dbName.Text = "Database Name";
            this.dbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDbOk
            // 
            this.btnDbOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbOk.Location = new System.Drawing.Point(14, 135);
            this.btnDbOk.Name = "btnDbOk";
            this.btnDbOk.Size = new System.Drawing.Size(92, 34);
            this.btnDbOk.TabIndex = 2;
            this.btnDbOk.Text = "Ok";
            this.btnDbOk.UseVisualStyleBackColor = true;
            this.btnDbOk.Click += new System.EventHandler(this.btnDbOk_Click);
            // 
            // btnDeletedb
            // 
            this.btnDeletedb.Location = new System.Drawing.Point(12, 76);
            this.btnDeletedb.Name = "btnDeletedb";
            this.btnDeletedb.Size = new System.Drawing.Size(113, 34);
            this.btnDeletedb.TabIndex = 2;
            this.btnDeletedb.Text = "DELETE Database";
            this.btnDeletedb.UseVisualStyleBackColor = true;
            this.btnDeletedb.Click += new System.EventHandler(this.btnDeletedb_Click);
            // 
            // DatabasesPanel
            // 
            this.DatabasesPanel.Controls.Add(this.panelDataSelectedColumns);
            this.DatabasesPanel.Controls.Add(this.panelAlldataWithKey);
            this.DatabasesPanel.Controls.Add(this.panelData);
            this.DatabasesPanel.Controls.Add(this.panelIndex);
            this.DatabasesPanel.Controls.Add(this.dataBasesTreeView);
            this.DatabasesPanel.Location = new System.Drawing.Point(262, 12);
            this.DatabasesPanel.Name = "DatabasesPanel";
            this.DatabasesPanel.Size = new System.Drawing.Size(930, 420);
            this.DatabasesPanel.TabIndex = 1;
            this.DatabasesPanel.Visible = false;
            // 
            // panelAlldataWithKey
            // 
            this.panelAlldataWithKey.Controls.Add(this.btnShowDataKey);
            this.panelAlldataWithKey.Controls.Add(this.dataGridViewwithKey);
            this.panelAlldataWithKey.Controls.Add(this.label11);
            this.panelAlldataWithKey.Controls.Add(this.cbKeys);
            this.panelAlldataWithKey.Location = new System.Drawing.Point(243, 26);
            this.panelAlldataWithKey.Name = "panelAlldataWithKey";
            this.panelAlldataWithKey.Size = new System.Drawing.Size(602, 394);
            this.panelAlldataWithKey.TabIndex = 12;
            this.panelAlldataWithKey.Visible = false;
            // 
            // btnShowDataKey
            // 
            this.btnShowDataKey.Location = new System.Drawing.Point(32, 334);
            this.btnShowDataKey.Name = "btnShowDataKey";
            this.btnShowDataKey.Size = new System.Drawing.Size(110, 23);
            this.btnShowDataKey.TabIndex = 3;
            this.btnShowDataKey.Text = "Show Data";
            this.btnShowDataKey.UseVisualStyleBackColor = true;
            this.btnShowDataKey.Click += new System.EventHandler(this.btnShowDataKey_Click);
            // 
            // dataGridViewwithKey
            // 
            this.dataGridViewwithKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewwithKey.Location = new System.Drawing.Point(159, 55);
            this.dataGridViewwithKey.Name = "dataGridViewwithKey";
            this.dataGridViewwithKey.Size = new System.Drawing.Size(440, 238);
            this.dataGridViewwithKey.TabIndex = 2;
            this.dataGridViewwithKey.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Key";
            // 
            // cbKeys
            // 
            this.cbKeys.FormattingEnabled = true;
            this.cbKeys.Location = new System.Drawing.Point(32, 55);
            this.cbKeys.Name = "cbKeys";
            this.cbKeys.Size = new System.Drawing.Size(121, 21);
            this.cbKeys.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.ForeignKeyIndexData);
            this.panelData.Controls.Add(this.btnUniqueData);
            this.panelData.Controls.Add(this.btnUniqueIndex);
            this.panelData.Controls.Add(this.tbForeign);
            this.panelData.Controls.Add(this.label10);
            this.panelData.Controls.Add(this.tbUnique);
            this.panelData.Controls.Add(this.label9);
            this.panelData.Controls.Add(this.CancelViewData);
            this.panelData.Controls.Add(this.keyText);
            this.panelData.Controls.Add(this.label8);
            this.panelData.Controls.Add(this.btnDeleteData);
            this.panelData.Controls.Add(this.dataGridView1);
            this.panelData.Location = new System.Drawing.Point(297, 26);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(526, 406);
            this.panelData.TabIndex = 18;
            this.panelData.Visible = false;
            this.panelData.Paint += new System.Windows.Forms.PaintEventHandler(this.panelData_Paint);
            // 
            // ForeignKeyIndexData
            // 
            this.ForeignKeyIndexData.Location = new System.Drawing.Point(240, 368);
            this.ForeignKeyIndexData.Name = "ForeignKeyIndexData";
            this.ForeignKeyIndexData.Size = new System.Drawing.Size(106, 23);
            this.ForeignKeyIndexData.TabIndex = 11;
            this.ForeignKeyIndexData.Text = "View Index Data";
            this.ForeignKeyIndexData.UseVisualStyleBackColor = true;
            this.ForeignKeyIndexData.Click += new System.EventHandler(this.ForeignKeyIndexData_Click);
            // 
            // btnUniqueData
            // 
            this.btnUniqueData.Location = new System.Drawing.Point(240, 334);
            this.btnUniqueData.Name = "btnUniqueData";
            this.btnUniqueData.Size = new System.Drawing.Size(136, 23);
            this.btnUniqueData.TabIndex = 10;
            this.btnUniqueData.Text = "ViewUniqueIndexData";
            this.btnUniqueData.UseVisualStyleBackColor = true;
            this.btnUniqueData.Visible = false;
            this.btnUniqueData.Click += new System.EventHandler(this.btnUniqueData_Click);
            // 
            // btnUniqueIndex
            // 
            this.btnUniqueIndex.Location = new System.Drawing.Point(240, 334);
            this.btnUniqueIndex.Name = "btnUniqueIndex";
            this.btnUniqueIndex.Size = new System.Drawing.Size(75, 23);
            this.btnUniqueIndex.TabIndex = 9;
            this.btnUniqueIndex.Text = "CreateIndex";
            this.btnUniqueIndex.UseVisualStyleBackColor = true;
            this.btnUniqueIndex.Click += new System.EventHandler(this.btnUniqueIndex_Click);
            // 
            // tbForeign
            // 
            this.tbForeign.Location = new System.Drawing.Point(103, 372);
            this.tbForeign.Name = "tbForeign";
            this.tbForeign.Size = new System.Drawing.Size(100, 20);
            this.tbForeign.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Foreign Key";
            // 
            // tbUnique
            // 
            this.tbUnique.Location = new System.Drawing.Point(103, 334);
            this.tbUnique.Name = "tbUnique";
            this.tbUnique.Size = new System.Drawing.Size(100, 20);
            this.tbUnique.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Unique Key";
            // 
            // CancelViewData
            // 
            this.CancelViewData.Location = new System.Drawing.Point(423, 317);
            this.CancelViewData.Name = "CancelViewData";
            this.CancelViewData.Size = new System.Drawing.Size(75, 23);
            this.CancelViewData.TabIndex = 4;
            this.CancelViewData.Text = "Cancel";
            this.CancelViewData.UseVisualStyleBackColor = true;
            this.CancelViewData.Click += new System.EventHandler(this.CancelViewData_Click);
            // 
            // keyText
            // 
            this.keyText.Location = new System.Drawing.Point(103, 299);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(100, 20);
            this.keyText.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Primary Key";
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Location = new System.Drawing.Point(240, 296);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteData.TabIndex = 1;
            this.btnDeleteData.Text = "Delete data";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panelIndex
            // 
            this.panelIndex.Controls.Add(this.IndexDatabaseName);
            this.panelIndex.Controls.Add(this.label7);
            this.panelIndex.Controls.Add(this.cbColumns);
            this.panelIndex.Controls.Add(this.label6);
            this.panelIndex.Controls.Add(this.btnCancelIndex);
            this.panelIndex.Controls.Add(this.tableNameIndex);
            this.panelIndex.Controls.Add(this.label4);
            this.panelIndex.Controls.Add(this.btnOkIndex);
            this.panelIndex.Controls.Add(this.indexColumnText);
            this.panelIndex.Controls.Add(this.label5);
            this.panelIndex.Location = new System.Drawing.Point(297, 29);
            this.panelIndex.Name = "panelIndex";
            this.panelIndex.Size = new System.Drawing.Size(268, 210);
            this.panelIndex.TabIndex = 6;
            this.panelIndex.Visible = false;
            // 
            // IndexDatabaseName
            // 
            this.IndexDatabaseName.AutoSize = true;
            this.IndexDatabaseName.Location = new System.Drawing.Point(73, 35);
            this.IndexDatabaseName.Name = "IndexDatabaseName";
            this.IndexDatabaseName.Size = new System.Drawing.Size(0, 13);
            this.IndexDatabaseName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Database";
            // 
            // cbColumns
            // 
            this.cbColumns.FormattingEnabled = true;
            this.cbColumns.Location = new System.Drawing.Point(73, 96);
            this.cbColumns.Name = "cbColumns";
            this.cbColumns.Size = new System.Drawing.Size(100, 21);
            this.cbColumns.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "IndexOn:";
            // 
            // btnCancelIndex
            // 
            this.btnCancelIndex.Location = new System.Drawing.Point(190, 179);
            this.btnCancelIndex.Name = "btnCancelIndex";
            this.btnCancelIndex.Size = new System.Drawing.Size(75, 23);
            this.btnCancelIndex.TabIndex = 13;
            this.btnCancelIndex.Text = "Cancel";
            this.btnCancelIndex.UseVisualStyleBackColor = true;
            this.btnCancelIndex.Click += new System.EventHandler(this.btnCancelIndex_Click);
            // 
            // tableNameIndex
            // 
            this.tableNameIndex.AutoSize = true;
            this.tableNameIndex.Location = new System.Drawing.Point(81, 68);
            this.tableNameIndex.Name = "tableNameIndex";
            this.tableNameIndex.Size = new System.Drawing.Size(0, 13);
            this.tableNameIndex.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Table:";
            // 
            // btnOkIndex
            // 
            this.btnOkIndex.Location = new System.Drawing.Point(190, 145);
            this.btnOkIndex.Name = "btnOkIndex";
            this.btnOkIndex.Size = new System.Drawing.Size(75, 23);
            this.btnOkIndex.TabIndex = 10;
            this.btnOkIndex.Text = "Ok";
            this.btnOkIndex.UseVisualStyleBackColor = true;
            this.btnOkIndex.Click += new System.EventHandler(this.btnOkIndex_Click);
            // 
            // indexColumnText
            // 
            this.indexColumnText.Location = new System.Drawing.Point(73, 147);
            this.indexColumnText.Name = "indexColumnText";
            this.indexColumnText.Size = new System.Drawing.Size(100, 20);
            this.indexColumnText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Index Name:";
            // 
            // dataBasesTreeView
            // 
            this.dataBasesTreeView.ContextMenuStrip = this.contextMenuStripDatabase;
            this.dataBasesTreeView.Location = new System.Drawing.Point(67, 26);
            this.dataBasesTreeView.Name = "dataBasesTreeView";
            this.dataBasesTreeView.Size = new System.Drawing.Size(155, 250);
            this.dataBasesTreeView.TabIndex = 0;
            // 
            // contextMenuStripDatabase
            // 
            this.contextMenuStripDatabase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTableToolStripMenuItem1});
            this.contextMenuStripDatabase.Name = "contextMenuStrip2";
            this.contextMenuStripDatabase.Size = new System.Drawing.Size(125, 26);
            // 
            // addTableToolStripMenuItem1
            // 
            this.addTableToolStripMenuItem1.Name = "addTableToolStripMenuItem1";
            this.addTableToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.addTableToolStripMenuItem1.Text = "AddTable";
            this.addTableToolStripMenuItem1.Click += new System.EventHandler(this.addTableToolStripMenuItem1_Click);
            // 
            // DatabasesBtn
            // 
            this.DatabasesBtn.Location = new System.Drawing.Point(12, 144);
            this.DatabasesBtn.Name = "DatabasesBtn";
            this.DatabasesBtn.Size = new System.Drawing.Size(113, 41);
            this.DatabasesBtn.TabIndex = 6;
            this.DatabasesBtn.Text = "Databases Show";
            this.DatabasesBtn.UseVisualStyleBackColor = true;
            this.DatabasesBtn.Click += new System.EventHandler(this.DatabasesBtn_Click);
            // 
            // contextMenuTable
            // 
            this.contextMenuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.dropTableToolStripMenuItem1,
            this.createIndexToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.selectAllWithSpeccificKeyToolStripMenuItem,
            this.showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem});
            this.contextMenuTable.Name = "contextMenuTable";
            this.contextMenuTable.Size = new System.Drawing.Size(316, 136);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // dropTableToolStripMenuItem1
            // 
            this.dropTableToolStripMenuItem1.Name = "dropTableToolStripMenuItem1";
            this.dropTableToolStripMenuItem1.Size = new System.Drawing.Size(315, 22);
            this.dropTableToolStripMenuItem1.Text = "DropTable";
            this.dropTableToolStripMenuItem1.Click += new System.EventHandler(this.dropTableToolStripMenuItem1_Click);
            // 
            // createIndexToolStripMenuItem
            // 
            this.createIndexToolStripMenuItem.Name = "createIndexToolStripMenuItem";
            this.createIndexToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.createIndexToolStripMenuItem.Text = "CreateIndex";
            this.createIndexToolStripMenuItem.Click += new System.EventHandler(this.createIndexToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.viewToolStripMenuItem.Text = "View Data";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // selectAllWithSpeccificKeyToolStripMenuItem
            // 
            this.selectAllWithSpeccificKeyToolStripMenuItem.Name = "selectAllWithSpeccificKeyToolStripMenuItem";
            this.selectAllWithSpeccificKeyToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.selectAllWithSpeccificKeyToolStripMenuItem.Text = "Select all with specified key";
            this.selectAllWithSpeccificKeyToolStripMenuItem.Click += new System.EventHandler(this.selectAllWithSpeccificKeyToolStripMenuItem_Click);
            // 
            // panelDataSelectedColumns
            // 
            this.panelDataSelectedColumns.Controls.Add(this.btnColumnsData);
            this.panelDataSelectedColumns.Controls.Add(this.btnShow2);
            this.panelDataSelectedColumns.Controls.Add(this.btnGet);
            this.panelDataSelectedColumns.Controls.Add(this.label13);
            this.panelDataSelectedColumns.Controls.Add(this.cbColumns2);
            this.panelDataSelectedColumns.Controls.Add(this.dataGridViewSelectedColumns);
            this.panelDataSelectedColumns.Controls.Add(this.label12);
            this.panelDataSelectedColumns.Controls.Add(this.cbKey2);
            this.panelDataSelectedColumns.Location = new System.Drawing.Point(243, 26);
            this.panelDataSelectedColumns.Name = "panelDataSelectedColumns";
            this.panelDataSelectedColumns.Size = new System.Drawing.Size(602, 394);
            this.panelDataSelectedColumns.TabIndex = 4;
            this.panelDataSelectedColumns.Visible = false;
            // 
            // cbKey2
            // 
            this.cbKey2.FormattingEnabled = true;
            this.cbKey2.Location = new System.Drawing.Point(182, 14);
            this.cbKey2.Name = "cbKey2";
            this.cbKey2.Size = new System.Drawing.Size(121, 21);
            this.cbKey2.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Key";
            // 
            // dataGridViewSelectedColumns
            // 
            this.dataGridViewSelectedColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedColumns.Location = new System.Drawing.Point(116, 140);
            this.dataGridViewSelectedColumns.Name = "dataGridViewSelectedColumns";
            this.dataGridViewSelectedColumns.Size = new System.Drawing.Size(365, 179);
            this.dataGridViewSelectedColumns.TabIndex = 2;
            // 
            // cbColumns2
            // 
            this.cbColumns2.FormattingEnabled = true;
            this.cbColumns2.Location = new System.Drawing.Point(182, 64);
            this.cbColumns2.Name = "cbColumns2";
            this.cbColumns2.Size = new System.Drawing.Size(121, 21);
            this.cbColumns2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Columns";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(355, 62);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(355, 17);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(75, 23);
            this.btnShow2.TabIndex = 6;
            this.btnShow2.Text = "Show";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem
            // 
            this.showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem.Name = "showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem";
            this.showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem.Text = "Show the selected columns with specified key";
            this.showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem.Click += new System.EventHandler(this.showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem_Click);
            // 
            // btnColumnsData
            // 
            this.btnColumnsData.Location = new System.Drawing.Point(451, 64);
            this.btnColumnsData.Name = "btnColumnsData";
            this.btnColumnsData.Size = new System.Drawing.Size(101, 23);
            this.btnColumnsData.TabIndex = 7;
            this.btnColumnsData.Text = "Show all data";
            this.btnColumnsData.UseVisualStyleBackColor = true;
            this.btnColumnsData.Click += new System.EventHandler(this.btnColumnsData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 498);
            this.Controls.Add(this.DatabasesPanel);
            this.Controls.Add(this.DatabasesBtn);
            this.Controls.Add(this.panelDeletedb);
            this.Controls.Add(this.panelAdddb);
            this.Controls.Add(this.btnDeletedb);
            this.Controls.Add(this.addDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDeletedb.ResumeLayout(false);
            this.panelDeletedb.PerformLayout();
            this.panelAdddb.ResumeLayout(false);
            this.panelAdddb.PerformLayout();
            this.DatabasesPanel.ResumeLayout(false);
            this.panelAlldataWithKey.ResumeLayout(false);
            this.panelAlldataWithKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewwithKey)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelIndex.ResumeLayout(false);
            this.panelIndex.PerformLayout();
            this.contextMenuStripDatabase.ResumeLayout(false);
            this.contextMenuTable.ResumeLayout(false);
            this.panelDataSelectedColumns.ResumeLayout(false);
            this.panelDataSelectedColumns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedColumns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDatabase;
        private System.Windows.Forms.Panel panelDeletedb;
        private System.Windows.Forms.Label dbName;
        private System.Windows.Forms.Button btnDbCn;
        private System.Windows.Forms.Button btnDbOk;
        private System.Windows.Forms.TextBox dbTextName;
        private System.Windows.Forms.Panel panelAdddb;
        private System.Windows.Forms.Button btnDeletedb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeletedb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeletedbCn;
        private System.Windows.Forms.Button btnDeletedbOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DatabasesPanel;
        private System.Windows.Forms.Button DatabasesBtn;
        private System.Windows.Forms.TreeView dataBasesTreeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDatabase;
        private System.Windows.Forms.ToolStripMenuItem addTableToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuTable;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropTableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createIndexToolStripMenuItem;
        private System.Windows.Forms.Panel panelIndex;
        private System.Windows.Forms.ComboBox cbColumns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelIndex;
        private System.Windows.Forms.Label tableNameIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOkIndex;
        private System.Windows.Forms.TextBox indexColumnText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label IndexDatabaseName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CancelViewData;
        private System.Windows.Forms.Button btnUniqueData;
        private System.Windows.Forms.Button btnUniqueIndex;
        private System.Windows.Forms.TextBox tbForeign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUnique;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ForeignKeyIndexData;
        private System.Windows.Forms.ToolStripMenuItem selectAllWithSpeccificKeyToolStripMenuItem;
        private System.Windows.Forms.Panel panelAlldataWithKey;
        private System.Windows.Forms.Button btnShowDataKey;
        private System.Windows.Forms.DataGridView dataGridViewwithKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbKeys;
        private System.Windows.Forms.Panel panelDataSelectedColumns;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbColumns2;
        private System.Windows.Forms.DataGridView dataGridViewSelectedColumns;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbKey2;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.ToolStripMenuItem showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem;
        private System.Windows.Forms.Button btnColumnsData;
    }
}

