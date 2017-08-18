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
            var tree = node.CreateTree(new int[] { 3, 2, 3 });
            var result = new Leet094_Binary_Tree_Inorder_Traversal().InorderTraversal(tree);
            CollectionAssert.AreEqual(result.ToArray(), new int[] { 2, 3, 3 });

        }
    }
}