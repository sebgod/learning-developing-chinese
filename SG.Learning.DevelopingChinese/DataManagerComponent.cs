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
            return OpenSubFolder(subFolder).EnumerateDirectories().Select(childDir => new DataFolder(childDir));
        }

        private DirectoryInfo OpenSubFolder(DataSubFolder subFolder)
        {
            return DataDirectory.EnumerateDirectories(subFolder.ToString()).Single();
        }

        public IEnumerable<TreeNode> EnumerateDataFiles<T>(DataSubFolder subFolder,
                                                           Func<FileInfo, DataFile<T>> fileParser,
                                                           SearchOption searchOption = SearchOption.TopDirectoryOnly)
            where T : class
        {
            switch (searchOption)
            {
                case SearchOption.AllDirectories:
                    return
                        from dataFolder in EnumerateDataFolders(subFolder)
                        let treeNode = new TreeNode(dataFolder.Name) {Tag = dataFolder}
                        where treeNode.AddChildrenIfAny(
                            dataFolder.EnumerateDataFiles(fileParser),
                            DataFileToTreeNode)
                        select treeNode;

                case SearchOption.TopDirectoryOnly:
                    return
                        new DataFolder(OpenSubFolder(subFolder))
                            .EnumerateDataFiles(fileParser)
                            .Select(DataFileToTreeNode);

                default:
                    throw new ArgumentException(searchOption + " is not implemented!", "searchOption");
            }
        }

        private static TreeNode DataFileToTreeNode<T>(DataFile<T> dataFile)
            where T : class 
        {
            return new TreeNode(dataFile.Name) { Tag = dataFile };
        }
    }
}
