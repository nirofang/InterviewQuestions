using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet144_Binary_Tree_Preorder_Traversal
    {
        static List<int> res = new List<int>();
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            dfs(root);
            return res;
        }
        static void dfs(TreeNode root)
        {
            if (root == null)
                return;

            res.Add(root.val);
            dfs(root.left);
            dfs(root.right);
        }

        public static IList<int> PreorderTraversal2(TreeNode root)
        {
            Stack<TreeNode> st = new Stack<TreeNode>();
            st.Push(root);
            
            while(st.Count!=0)
            {
                TreeNode node = st.Pop();

                if (node==null) continue;

                res.Add(node.val);
                st.Push(node.right);
                st.Push(node.left);
            }
            
            return res;
        }
        //static void dfs2(TreeNode root)
        //{
        //    if (root == null)
        //        return;

        //    res.Add(root.val);
        //    dfs(root.left);
        //    dfs(root.right);
        //}

    }
}
