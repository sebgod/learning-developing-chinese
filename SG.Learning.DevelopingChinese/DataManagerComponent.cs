using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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

        public IEnumerable<DataFolder> EnumerateDataFolders()
        {
            return DataDirectory.EnumerateDirectories().Select(childDir => new DataFolder(childDir));
        }
    }
}
