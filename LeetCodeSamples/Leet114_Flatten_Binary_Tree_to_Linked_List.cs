using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet114_Flatten_Binary_Tree_to_Linked_List
    {
        static TreeNode pre = null;
        public static void Flatten(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Flatten(root.right);
            Flatten(root.left);

            root.left = null;
            root.right = pre;
            pre = root;
        }
    }
}
