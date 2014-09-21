using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG.Learning.DevelopingChinese
{
    public partial class UnitsForm : Form
    {
        public UnitsForm()
        {
            InitializeComponent();
        }

        private async void UnitsForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() => InitializeDataManager());
            var classNode = treeViewUnits.Nodes["NodeCourses"];
            classNode.Nodes.AddRange(await Task.Run(() => EnumerateClassFolders().ToArray()));
            treeViewUnits.ExpandAll();
        }

        #region Data Manager
        private void InitializeDataManager()
        {
            dataManagerClasses.SetRoot(Application.StartupPath);
        }

        private IEnumerable<TreeNode> EnumerateClassFolders()
        {
            return
                from dataFolder in dataManagerClasses.EnumerateDataFolders()
                let classNode = new TreeNode(dataFolder.Name) {Tag = dataFolder}
                where classNode.AddChildrenIfAny(
                    dataFolder.EnumerateUnits(),
                    unitFile => new TreeNode(unitFile.Name) {Tag = unitFile})
                select classNode;
        }

        #endregion
        struct IdxPair
        {
            public readonly int Grid;
            public readonly int Data;

            public IdxPair(int grid, int data)
            {
                Grid = grid;
                Data = data;
            }
        }

        private async void treeViewUnits_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var unitFile = e.Node.Tag as UnitFile;
            if (unitFile == null) return;
            // HACK: This is only temporary
            if (dataGridView1.RowCount > 1) return;

            var unit = await unitFile.UnitAsync();
            var vocs = unit.Vocabulary;
            var vocHeader = unit.Vocabulary.ColumnHeader;
            var gridColCount = dataGridView1.ColumnCount;
            var nameToIdx = new Dictionary<string, IdxPair>(gridColCount);
            var dataIdxToName = new Dictionary<int, string>(gridColCount);
            for (var i = 0; i < gridColCount; i++)
            {
                var colNameWithPrefix = dataGridView1.Columns[i].Name;
                var colName = colNameWithPrefix.Substring(colNameWithPrefix.IndexOf('_') + 1);
                if (string.IsNullOrWhiteSpace(colName)) continue;

                var colIdx = vocHeader[colName];
                if (colIdx < 0) continue;
                
                nameToIdx[colName] = new IdxPair(i, colIdx);
                dataIdxToName[colIdx] = colName;
            }

            dataGridView1.Rows.Clear();
            for (var vocRow = 0; vocRow < vocs.Count; vocRow++)
            {
                var data = new object[gridColCount];
                foreach (var nameIdxPair in nameToIdx)
                {
                    data[nameIdxPair.Value.Grid] = vocs[vocRow][nameIdxPair.Value.Data];
                }
                dataGridView1.Rows.Add(data);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
