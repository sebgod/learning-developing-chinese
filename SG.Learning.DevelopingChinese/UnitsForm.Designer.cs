namespace SG.Learning.DevelopingChinese
{
    partial class UnitsForm
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("中级教程");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("中级听力");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("中级阅读");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("中级口语");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Courses", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewUnits = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewUnits);
            this.splitContainer1.Size = new System.Drawing.Size(741, 603);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewUnits
            // 
            this.treeViewUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewUnits.Location = new System.Drawing.Point(0, 0);
            this.treeViewUnits.Name = "treeViewUnits";
            treeNode11.Name = "NodeZhongjiJiaocheng";
            treeNode11.Text = "中级教程";
            treeNode12.Name = "NodeZhongjiTingli";
            treeNode12.Text = "中级听力";
            treeNode13.Name = "NodeZhongjiYuedu";
            treeNode13.Text = "中级阅读";
            treeNode14.Name = "NodeZhongjiKouyu";
            treeNode14.Text = "中级口语";
            treeNode15.Name = "NodeCourses";
            treeNode15.Text = "Courses";
            this.treeViewUnits.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.treeViewUnits.Size = new System.Drawing.Size(118, 603);
            this.treeViewUnits.TabIndex = 0;
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 603);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UnitsForm";
            this.Text = "Unit Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UnitsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewUnits;
    }
}

