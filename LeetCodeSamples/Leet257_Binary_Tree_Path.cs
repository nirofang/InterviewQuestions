using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet257_Binary_Tree_Path
    {
        static Stack<KeyValuePair<TreeNode, string>> stack = new Stack<KeyValuePair<TreeNode, string>>();

        public static IList<string> BinaryTreePaths(TreeNode root)
        {

            stack.Push(new KeyValuePair<TreeNode, string>(root, ""));
            List<string> res = new List<string>();

            if (root == null)
            {
                return null;
            }

            while (stack.Count != 0)
            {
                var pair = stack.Pop();
                TreeNode node = pair.Key;
                string str = pair.Value;
                if (node.left == null && node.right == null)
                {
                    res.Add(str + node.val.ToString());
                }

                if (node.left != null)
                {
                    stack.Push(new KeyValuePair<TreeNode, string>(
                        node.left, 
                        str + node.val.ToString() + "->" 
                        ));
                }

                if (node.right != null)
                {
                    stack.Push(new KeyValuePair<TreeNode, string>(
                        node.right,
                        str + node.val.ToString() + "->"
                        ));
                }

            }
            return res;
        }
    }
}
