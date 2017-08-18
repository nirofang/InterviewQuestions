using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet106_Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal
    {

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder == null || postorder == null || inorder.Length == 0 || postorder.Length == 0)
            {
                return null;
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                dict.Add(inorder[i], i);
            }
            return buildTree(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1, dict);
        }

        private TreeNode buildTree(int[] inorder, int inStart, int inEnd, int[] postorder, int postStart, int postEnd, Dictionary<int, int> dict)
        {
            if (inStart > inEnd)
            {
                return null;
            }
            TreeNode node = new TreeNode(postorder[postEnd]);
            int position = dict[postorder[postEnd]];
            node.left = buildTree(inorder, inStart, position - 1, postorder, postStart, postStart + position - inStart - 1, dict);
            node.right = buildTree(inorder, position + 1, inEnd, postorder, postStart + position - inStart, postEnd - 1, dict);

            return node;
        }
    }
}
