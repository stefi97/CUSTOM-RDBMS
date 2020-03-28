namespace Client
{
    partial class FormDeleteTable
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
            this.TableTree = new System.Windows.Forms.TreeView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.TablesBtn = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.panelIndex = new System.Windows.Forms.Panel();
            this.btnOkIndex = new System.Windows.Forms.Button();
            this.indexColumnText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableNameIndex = new System.Windows.Forms.Label();
            this.btnCancelIndex = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.panelIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableTree
            // 
            this.TableTree.Location = new System.Drawing.Point(95, 34);
            this.TableTree.Name = "TableTree";
            this.TableTree.Size = new System.Drawing.Size(164, 215);
            this.TableTree.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(494, 34);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete table";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // TablesBtn
            // 
            this.TablesBtn.Location = new System.Drawing.Point(265, 34);
            this.TablesBtn.Name = "TablesBtn";
            this.TablesBtn.Size = new System.Drawing.Size(103, 23);
            this.TablesBtn.TabIndex = 2;
            this.TablesBtn.Text = "Show All Tables";
            this.TablesBtn.UseVisualStyleBackColor = true;
            this.TablesBtn.Click += new System.EventHandler(this.TablesBtn_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(12, 309);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(494, 80);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 4;
            this.btnIndex.Text = "Create Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // panelIndex
            // 
            this.panelIndex.Controls.Add(this.btnCancelIndex);
            this.panelIndex.Controls.Add(this.tableNameIndex);
            this.panelIndex.Controls.Add(this.label2);
            this.panelIndex.Controls.Add(this.btnOkIndex);
            this.panelIndex.Controls.Add(this.indexColumnText);
            this.panelIndex.Controls.Add(this.label1);
            this.panelIndex.Location = new System.Drawing.Point(310, 176);
            this.panelIndex.Name = "panelIndex";
            this.panelIndex.Size = new System.Drawing.Size(268, 114);
            this.panelIndex.TabIndex = 5;
            this.panelIndex.Visible = false;
            // 
            // btnOkIndex
            // 
            this.btnOkIndex.Location = new System.Drawing.Point(184, 40);
            this.btnOkIndex.Name = "btnOkIndex";
            this.btnOkIndex.Size = new System.Drawing.Size(75, 23);
            this.btnOkIndex.TabIndex = 10;
            this.btnOkIndex.Text = "Ok";
            this.btnOkIndex.UseVisualStyleBackColor = true;
            this.btnOkIndex.Click += new System.EventHandler(this.btnOkIndex_Click);
            // 
            // indexColumnText
            // 
            this.indexColumnText.Location = new System.Drawing.Point(78, 42);
            this.indexColumnText.Name = "indexColumnText";
            this.indexColumnText.Size = new System.Drawing.Size(100, 20);
            this.indexColumnText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Index Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Table:";
            // 
            // tableNameIndex
            // 
            this.tableNameIndex.AutoSize = true;
            this.tableNameIndex.Location = new System.Drawing.Point(80, 14);
            this.tableNameIndex.Name = "tableNameIndex";
            this.tableNameIndex.Size = new System.Drawing.Size(0, 13);
            this.tableNameIndex.TabIndex = 12;
            // 
            // btnCancelIndex
            // 
            this.btnCancelIndex.Location = new System.Drawing.Point(184, 69);
            this.btnCancelIndex.Name = "btnCancelIndex";
            this.btnCancelIndex.Size = new System.Drawing.Size(75, 23);
            this.btnCancelIndex.TabIndex = 13;
            this.btnCancelIndex.Text = "Cancel";
            this.btnCancelIndex.UseVisualStyleBackColor = true;
            this.btnCancelIndex.Click += new System.EventHandler(this.btnCancelIndex_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(494, 126);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 6;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // FormDeleteTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 378);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.panelIndex);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.TablesBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.TableTree);
            this.Name = "FormDeleteTable";
            this.Text = "FormDeleteTable";
            this.panelIndex.ResumeLayout(false);
            this.panelIndex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TableTree;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button TablesBtn;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Panel panelIndex;
        private System.Windows.Forms.Label tableNameIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOkIndex;
        private System.Windows.Forms.TextBox indexColumnText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelIndex;
        private System.Windows.Forms.Button insertBtn;
    }
}