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
    public class Leet538_Convert_BST_to_Greater_Tree_Tests
    {
        [TestMethod()]
        public void ConvertBST_Test()
        {
            TreeNode node = new TreeNode();
            var tree = node.CreateTree2(new string[] {
                "5", "4", "11", "7", "#", "#", "2", "#", "#", "#", "8", "13",
                "#", "#", "4", "#", "1", "#", "#" });
            var exp = node.CreateTree2(new string[] {
                "31", "35", "48", "55", "#", "#", "37", "#", "#", "#", "13", "26",
                "#", "#", "5", "#", "1", "#", "#" });

            //            5
            //        4           8    
            //    11          13      4
            //7       2                   1


            //            31
            //        35           13
            //    48          26      5
            //55       37                   1


            var res = Leet538_Convert_BST_to_Greater_Tree.ConvertBST(tree);
            Assert.IsTrue(res.EqualsTo(exp));
        }
    }
}