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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewUnits = new System.Windows.Forms.TreeView();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageVocabulary = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.columnVoc_中文 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVoc_拼音 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVoc_词性 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnVoc_英文 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVoc_英文and1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVoc_英文alt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataManagerComponent = new SG.Learning.DevelopingChinese.DataManagerComponent(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageVocabulary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainer1.Size = new System.Drawing.Size(741, 603);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 0;
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
            this.treeViewUnits.Size = new System.Drawing.Size(118, 603);
            this.treeViewUnits.TabIndex = 0;
            this.treeViewUnits.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewUnits_AfterSelect);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageVocabulary);
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(619, 603);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageVocabulary
            // 
            this.tabPageVocabulary.Controls.Add(this.dataGridView1);
            this.tabPageVocabulary.Location = new System.Drawing.Point(4, 22);
            this.tabPageVocabulary.Name = "tabPageVocabulary";
            this.tabPageVocabulary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVocabulary.Size = new System.Drawing.Size(611, 577);
            this.tabPageVocabulary.TabIndex = 1;
            this.tabPageVocabulary.Text = "Vocabulary";
            this.tabPageVocabulary.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnVoc_中文,
            this.columnVoc_拼音,
            this.columnVoc_词性,
            this.columnVoc_英文,
            this.columnVoc_英文and1,
            this.columnVoc_英文alt1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 571);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(611, 577);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // columnVoc_中文
            // 
            this.columnVoc_中文.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnVoc_中文.HeaderText = "Chinese";
            this.columnVoc_中文.Name = "columnVoc_中文";
            this.columnVoc_中文.Width = 70;
            // 
            // columnVoc_拼音
            // 
            this.columnVoc_拼音.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.NullValue = null;
            this.columnVoc_拼音.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnVoc_拼音.HeaderText = "Pinyin";
            this.columnVoc_拼音.Name = "columnVoc_拼音";
            this.columnVoc_拼音.Width = 60;
            // 
            // columnVoc_词性
            // 
            this.columnVoc_词性.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.columnVoc_词性.HeaderText = "Class";
            this.columnVoc_词性.Items.AddRange(new object[] {
            "adj",
            "adv",
            "conj",
            "idiom",
            "noun",
            "prefix",
            "prep",
            "pronoun",
            "suffix",
            "verb"});
            this.columnVoc_词性.Name = "columnVoc_词性";
            this.columnVoc_词性.Sorted = true;
            this.columnVoc_词性.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnVoc_英文
            // 
            this.columnVoc_英文.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnVoc_英文.HeaderText = "English";
            this.columnVoc_英文.Name = "columnVoc_英文";
            this.columnVoc_英文.Width = 66;
            // 
            // columnVoc_英文and1
            // 
            this.columnVoc_英文and1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnVoc_英文and1.HeaderText = "English - Add.";
            this.columnVoc_英文and1.Name = "columnVoc_英文and1";
            this.columnVoc_英文and1.Width = 69;
            // 
            // columnVoc_英文alt1
            // 
            this.columnVoc_英文alt1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnVoc_英文alt1.HeaderText = "English - Alternative";
            this.columnVoc_英文alt1.Name = "columnVoc_英文alt1";
            this.columnVoc_英文alt1.Width = 114;
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
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageVocabulary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewUnits;
        private DataManagerComponent dataManagerComponent;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageVocabulary;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnVoc_中文;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnVoc_拼音;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnVoc_词性;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnVoc_英文;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnVoc_英文and1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnVoc_英文alt1;
    }
}

