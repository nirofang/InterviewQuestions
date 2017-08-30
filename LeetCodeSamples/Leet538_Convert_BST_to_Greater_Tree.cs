using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet538_Convert_BST_to_Greater_Tree
    {
        static int sum = 0;
        public static TreeNode ConvertBST(TreeNode root)
        {
            dfs(root);
            return root;
        }

        static void dfs(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            dfs(root.right);
            root.val += sum;
            sum = root.val;
            dfs(root.left);
        }
    }
}
