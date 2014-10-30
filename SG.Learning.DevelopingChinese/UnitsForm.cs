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

    }
}
