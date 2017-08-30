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
    public class Leet112_Path_Sum_Tests
    {
        [TestMethod()]
        public void HasPathSum_Test()
        {
            TreeNode node = new TreeNode();
            var tree = node.CreateTree2(new string[] {
                "5", "4", "11", "7", "#", "#", "2", "#", "#", "#", "8", "13",
                "#", "#", "4", "#", "1", "#", "#" });
            Assert.IsTrue(Leet112_Path_Sum.HasPathSum(tree, 22));
        }
    }
}