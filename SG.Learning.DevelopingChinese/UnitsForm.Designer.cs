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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Courses");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Learning");
            this.dataManagerComponent = new SG.Learning.DevelopingChinese.DataManagerComponent(this.components);
            this.treeViewUnits = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewUnits
            // 
            this.treeViewUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewUnits.Location = new System.Drawing.Point(0, 0);
            this.treeViewUnits.Name = "treeViewUnits";
            treeNode1.Name = "NodeCourses";
            treeNode1.Text = "Courses";
            treeNode2.Name = "NodeLearning";
            treeNode2.Text = "Learning";
            this.treeViewUnits.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeViewUnits.Size = new System.Drawing.Size(303, 211);
            this.treeViewUnits.TabIndex = 0;
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 211);
            this.Controls.Add(this.treeViewUnits);
            this.Name = "UnitsForm";
            this.Text = "Unit Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UnitsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DataManagerComponent dataManagerComponent;
        private System.Windows.Forms.TreeView treeViewUnits;
    }
}

