namespace Client
{
    partial class FormIndex
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
            this.btnShowIndex = new System.Windows.Forms.Button();
            this.IndexTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuIndex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowIndex
            // 
            this.btnShowIndex.Location = new System.Drawing.Point(664, 24);
            this.btnShowIndex.Name = "btnShowIndex";
            this.btnShowIndex.Size = new System.Drawing.Size(75, 23);
            this.btnShowIndex.TabIndex = 0;
            this.btnShowIndex.Text = "Show Index";
            this.btnShowIndex.UseVisualStyleBackColor = true;
            this.btnShowIndex.Click += new System.EventHandler(this.btnShowIndex_Click);
            // 
            // IndexTreeView
            // 
            this.IndexTreeView.ContextMenuStrip = this.contextMenuIndex;
            this.IndexTreeView.Location = new System.Drawing.Point(54, 24);
            this.IndexTreeView.Name = "IndexTreeView";
            this.IndexTreeView.Size = new System.Drawing.Size(123, 151);
            this.IndexTreeView.TabIndex = 1;
            this.IndexTreeView.Visible = false;
            // 
            // contextMenuIndex
            // 
            this.contextMenuIndex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDataToolStripMenuItem});
            this.contextMenuIndex.Name = "contextMenuIndex";
            this.contextMenuIndex.Size = new System.Drawing.Size(181, 48);
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewDataToolStripMenuItem.Text = "View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IndexTreeView);
            this.Controls.Add(this.btnShowIndex);
            this.Name = "FormIndex";
            this.Text = "FormIndex";
            this.contextMenuIndex.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowIndex;
        private System.Windows.Forms.TreeView IndexTreeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuIndex;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
    }
}