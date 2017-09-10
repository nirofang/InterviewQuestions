using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet110_Balanced_Binary_Tree
    {
        public static bool Balanced_Binary_Tree(TreeNode root)
        {
            int height = getHeight(root);
            //if (height != -1)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return (height != -1);
        }

        private static int getHeight(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            int l = getHeight(root.left);
            if (l == -1)
            {
                return -1;
            }

            int r = getHeight(root.right);
            if (r == -1)
            {
                return -1;
            }

            if (Math.Abs(l -r)>1)
            {
                return -1;
            }
            else
            {
                return Math.Max(l, r) + 1;
            }
        }
    }
}
