using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet094_Binary_Tree_Inorder_Traversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null)
            {
                return list;
            }
            inorder(root, list);
            return list;
        }

        void inorder(TreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            if (node.left != null)
            {
                inorder(node.left, list);
            }
            list.Add(node.val);
            if (node.right != null)
            {
                inorder(node.right, list);
            }
        }
    }
}
