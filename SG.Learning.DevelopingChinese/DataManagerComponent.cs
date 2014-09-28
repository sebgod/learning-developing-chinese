using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG.Learning.DevelopingChinese
{
    public partial class DataManagerComponent : Component
    {
        public DataManagerComponent()
        {
            InitializeComponent();
        }

        public DataManagerComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected internal void SetRoot(string root)
        {
            var rootDir = new DirectoryInfo(root);
            while (rootDir != null && (DataDirectory = rootDir.EnumerateDirectories("data").SingleOrDefault()) == null)
            {
                rootDir = rootDir.Parent;
            }
        }

        [Browsable(false)]
        [Category("Behavior")]
        [Description("The directory where the XML data is stored")]
        public DirectoryInfo DataDirectory { get; private set; }

        public IEnumerable<DataFolder> EnumerateDataFolders(DataSubFolder subFolder)
        {
            var specificDataDir = DataDirectory.EnumerateDirectories(subFolder.ToString()).First();
            return specificDataDir.EnumerateDirectories().Select(childDir => new DataFolder(childDir));
        }


        public IEnumerable<TreeNode> EnumerateDataFiles<T>(DataSubFolder subFolder, Func<FileInfo, DataFile<T>> fileParser)
            where T : class
        {
            return
                from dataFolder in EnumerateDataFolders(subFolder)
                let treeNode = new TreeNode(dataFolder.Name) { Tag = dataFolder }
                where treeNode.AddChildrenIfAny(
                    dataFolder.EnumerateDataFiles(fileParser),
                    unitFile => new TreeNode(unitFile.Name) { Tag = unitFile })
                select treeNode;
        }
    }
}
