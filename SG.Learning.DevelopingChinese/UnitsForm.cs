using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void UnitsForm_Load(object sender, EventArgs e)
        {
            treeViewUnits.ExpandAll();
        }
    }
}
