using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SG.Learning.DevelopingChinese
{
    static class TreeNodeHelper
    {
        public static bool AddChildrenIfAny<T>(this TreeNode root, IEnumerable<T> children, Func<T, TreeNode> childSelector)
        {
            var childArray = children.Select(childSelector).ToArray();
            if (childArray.Length > 0)
            {
                root.Nodes.AddRange(childArray);
                return true;
            }
            return false;
        }
    }
}
