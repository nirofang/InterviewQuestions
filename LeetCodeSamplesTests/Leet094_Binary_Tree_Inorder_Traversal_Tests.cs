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
    public class Leet094_Binary_Tree_Inorder_Traversal_Tests
    {
        [TestMethod()]
        public void InorderTraversal_Test()
        {
            TreeNode node= new TreeNode();
            var tree = node.CreateTree(new string[] { "3", "2", "1", "#",  "6"});
            var result = new Leet094_Binary_Tree_Inorder_Traversal().InorderTraversal(tree);
            CollectionAssert.AreEqual(result.ToArray(), new int[] {1, 6, 2, 3 });

            tree = node.CreateTree(new string[] { "3", "2", "1", "#", "#", "6" });
            result = new Leet094_Binary_Tree_Inorder_Traversal().InorderTraversal(tree);
            CollectionAssert.AreEqual(result.ToArray(), new int[] { 1, 2, 6, 3 });

            var tree2 = node.CreateTree2(new string[] { "3", "2", "1", "#", "#", "6" });
            var result2 = new Leet094_Binary_Tree_Inorder_Traversal().InorderTraversal(tree2);
            CollectionAssert.AreEqual(result2.ToArray(), new int[] { 1, 2, 6, 3 });


        }
    }
}