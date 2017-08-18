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
        public TreeNode left = null;
        public TreeNode right = null;

        public TreeNode()
        {
        }

        public TreeNode(string x) { val = int.Parse(x); }

        public TreeNode(int x) { val = x; }


        public TreeNode CreateTree(string[] vals)
        {
            
            if (vals==null || vals.Length == 0)
            {
                return null;
            }
            if (vals[0] == "#")
            {
                return null;
            }
            
            TreeNode curNode = new TreeNode(vals[0]);
            int index = 1;
            CreateTreeNode(curNode, vals,ref index);

            return curNode;

        }

        TreeNode CreateTreeNode(TreeNode prevNode, string[] vals,ref int index)
        {
            
            if(index == vals.Length || vals[index] == "#")
            {
                return null;
            }
            prevNode.left = new TreeNode(vals[index]);
            TreeNode curNode = prevNode.left;
            index++;
            CreateTreeNode(curNode, vals, ref index);
            index++;

            if (index >= vals.Length || vals[index] == "#")
            {
                return null;
            }
            curNode.right = new TreeNode(vals[index]);
            index++;
            CreateTreeNode(curNode.right, vals, ref index);

            return prevNode;
        }

        public TreeNode CreateTree2(string[] vals)
        {
            TreeNode root = null;
            int index = 0;
            CreateTreeNode2(ref root, vals, ref index);

            return root;

        }


        void CreateTreeNode2(ref TreeNode prevNode, string[] vals, ref int index)
        {

            if (index >= vals.Length || vals[index] == "#")
            {
                return;
            }
            if (prevNode == null)
            {
                prevNode = new TreeNode(vals[index]);
                index++;
                CreateTreeNode2(ref prevNode.left, vals, ref index);
                index++;
                CreateTreeNode2(ref prevNode.right, vals, ref index);
            } 
            return;
        }

    }
}
