using System;
using System.Collections.Generic;
using System.IO;
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
            await AddDataFilesToTreeAsync(DataSubFolder.Courses, UnitFile.Parse, SearchOption.AllDirectories);
            await AddDataFilesToTreeAsync(DataSubFolder.Learning, FlashcardFile.Parse);
            treeViewUnits.ExpandAll();
        }

        #region Data Manager
        private void InitializeDataManager()
        {
            dataManagerComponent.SetRoot(Application.StartupPath);
        }

        private async Task AddDataFilesToTreeAsync<T>(DataSubFolder subFolder,
            Func<FileInfo, DataFile<T>> fileParser,
            SearchOption searchOption = SearchOption.TopDirectoryOnly)
            where T : class
        {
            var dataFiles = dataManagerComponent.EnumerateDataFiles(subFolder, fileParser, searchOption);
            treeViewUnits.Nodes["Node" + subFolder].Nodes.AddRange(await Task.Run(() => dataFiles.ToArray()));
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
            if (unitFile != null)
                await RenderUnitAsync(unitFile);

            var flashcardFile = e.Node.Tag as FlashcardFile;
            if (flashcardFile != null)
                await RenderFlashcardStoreAsync(flashcardFile);
        }

        private async Task RenderFlashcardStoreAsync(FlashcardFile flashcardFile)
        {
            MessageBox.Show((await flashcardFile.ParseDataFileAsync()).Flashcards.Creator);
        }

        private async Task RenderUnitAsync(UnitFile unitFile)
        {
            if (DataGridCacheEquals(unitFile))
                return;

            var unit = await unitFile.ParseDataFileAsync();
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

        private bool DataGridCacheEquals<T>(T unitFile)
            where T : class
        {
            var isSame = unitFile.Equals(dataGridView1.Tag as T);
            dataGridView1.Tag = unitFile;
            return isSame;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(string.Format("Error {1}@{0:d}", e.RowIndex, e.Exception.Message));
            e.Cancel = true;
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            var messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "ColumnIndex", e.ColumnIndex);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "InheritedCellStyle", e.InheritedCellStyle);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "ParsingApplied", e.ParsingApplied);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Value", e.Value);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "DesiredType", e.DesiredType);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "CellParsing Event");
        }
    }
}
