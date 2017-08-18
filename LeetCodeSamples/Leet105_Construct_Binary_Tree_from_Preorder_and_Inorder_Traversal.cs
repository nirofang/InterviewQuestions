using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder != null && inorder != null && preorder.Length > 0 && inorder.Length > 0)
            {
                return myBuildTree(inorder, 0, inorder.Length - 1, preorder, 0, preorder.Length - 1);
            }
            else
            {
                return null;
            }
        }

        private TreeNode myBuildTree(int[] inorder, int instart, int inend,
                int[] preorder, int prestart, int preend)
        {
            if (instart > inend)
            {
                return null;
            }

            TreeNode root = new TreeNode(preorder[prestart]);
            int position = findPosition(inorder, instart, inend, preorder[prestart]);

            root.left = myBuildTree(inorder, instart, position - 1,
                    preorder, prestart + 1, prestart + position - instart);
            root.right = myBuildTree(inorder, position + 1, inend,
                    preorder, position - inend + preend + 1, preend);
            return root;
        }

        private int findPosition(int[] order, int start, int end, int key)
        {
            for (int i = start; i <= end; i++)
            {
                if (order[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
