using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples.DataStruct
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode()
        {
        }

        public TreeNode(int x) { val = x; }


        public TreeNode CreateTree(int[] x)
        {
            if (x.Length == 0)
            {
                return null;
            }

            if (x.Length == 3)
            {
                TreeNode n1 = new TreeNode(x[0]);
                n1.left = new TreeNode(x[1]);
                n1.right = new TreeNode(x[2]);
                return n1;
            }

            return new TreeNode(x[0]);

        }
    }
}
