using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSamples.DataStruct;

namespace LeetCodeSamples.Tests
{
    [TestClass()]
    public class Leet144_Binary_Tree_Preorder_Traversal_Tests
    {
        [TestMethod()]
        public void PreorderTraversal_Test()
        {
            TreeNode node = new TreeNode();
            var tree = node.CreateTree2(new string[] {
                "5", "4", "11", "7", "#", "#", "2", "#", "#", "#", "8", "13",
                "#", "#", "4", "#", "1", "#", "#" });

            //            5
            //        4           8    
            //    11          13      4
            //7       2                   1

            var exp = new List<int> { 5, 4, 11, 7, 2, 8, 13, 4, 1};
            var res = Leet144_Binary_Tree_Preorder_Traversal.PreorderTraversal(tree);
            CollectionAssert.AreEqual(res.ToList(), exp);

            res.Clear();
            res = Leet144_Binary_Tree_Preorder_Traversal.PreorderTraversal2(tree);
            CollectionAssert.AreEqual(res.ToList(), exp);

        }
    }
}