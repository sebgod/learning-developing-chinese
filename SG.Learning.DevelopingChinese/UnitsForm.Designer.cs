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
            this.dataManagerComponent = new SG.Learning.DevelopingChinese.DataManagerComponent(this.components);
            this.betterListView1 = new ComponentOwl.BetterListView.BetterListView();
            this.groupUnits = new ComponentOwl.BetterListView.BetterListViewGroup();
            this.groupLearning = new ComponentOwl.BetterListView.BetterListViewGroup();
            ((System.ComponentModel.ISupportInitialize)(this.betterListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // betterListView1
            // 
            this.betterListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betterListView1.Groups.Add(this.groupUnits);
            this.betterListView1.Groups.Add(this.groupLearning);
            this.betterListView1.Location = new System.Drawing.Point(0, 0);
            this.betterListView1.Name = "betterListView1";
            this.betterListView1.Size = new System.Drawing.Size(741, 603);
            this.betterListView1.TabIndex = 0;
            // 
            // groupUnits
            // 
            this.groupUnits.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.groupUnits.Header = "Units";
            this.groupUnits.Name = "groupUnits";
            // 
            // groupLearning
            // 
            this.groupLearning.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.groupLearning.Header = "Learning";
            this.groupLearning.Name = "groupLearning";
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 603);
            this.Controls.Add(this.betterListView1);
            this.Name = "UnitsForm";
            this.Text = "Unit Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UnitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.betterListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataManagerComponent dataManagerComponent;
        private ComponentOwl.BetterListView.BetterListView betterListView1;
        private ComponentOwl.BetterListView.BetterListViewGroup groupUnits;
        private ComponentOwl.BetterListView.BetterListViewGroup groupLearning;
    }
}

