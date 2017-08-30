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
    public class Leet257_Binary_Tree_Path_Tests
    {
        [TestMethod()]
        public void BinaryTreePaths_Test()
        {
            TreeNode node = new TreeNode();
            var tree = node.CreateTree2(new string[] {
                "5", "4", "11", "7", "#", "#", "2", "#", "#", "#", "8", "13",
                "#", "#", "4", "#", "1", "#", "#" });
            var exp = new string[] { "5->8->4->1", "5->8->13", "5->4->11->2", "5->4->11->7" };
            var res = Leet257_Binary_Tree_Path.BinaryTreePaths(tree);
            CollectionAssert.AreEqual(exp, res.ToArray());
        }
    }
}