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
    public class Leet110_Balanced_Binary_Tree_Tests
    {
        [TestMethod()]
        public void Balanced_Binary_Tree_Test()
        {
            TreeNode node = new TreeNode();
            var tree = node.CreateTree2(new string[] {
                "5", "4", "11", "7", "#", "#", "2", "#", "#", "#", "8", "13",
                "#", "#", "4", "#", "1", "#", "#" });


            //            5
            //        4           8    
            //    11          13      4
            //7       2                   1

            Assert.IsFalse(Leet110_Balanced_Binary_Tree.Balanced_Binary_Tree(tree));


            tree = node.CreateTree2(new string[] {
                "5", "4", "11", "7", "#", "#", "2", "#", "#","6", "#", "#", "8", "13",
                "#", "#", "4", "#", "1", "#", "#" });

            //            5
            //        4           8    
            //    11      6    13      4
            //7       2                   1

            Assert.IsTrue(Leet110_Balanced_Binary_Tree.Balanced_Binary_Tree(tree));


            tree = node.CreateTree2(new string[] {
                "5", "#", "#" });

            Assert.IsTrue(Leet110_Balanced_Binary_Tree.Balanced_Binary_Tree(tree));

            tree = node.CreateTree2(new string[] {
                "5", "4", "#", "#" });

            Assert.IsTrue(Leet110_Balanced_Binary_Tree.Balanced_Binary_Tree(tree));

            tree = node.CreateTree2(new string[] {
                "5", "4","6", "#", "#" });

            Assert.IsFalse(Leet110_Balanced_Binary_Tree.Balanced_Binary_Tree(tree));


            tree = node.CreateTree2(new string[] {
                "5", "#","4", "#", "6" });

            Assert.IsFalse(Leet110_Balanced_Binary_Tree.Balanced_Binary_Tree(tree));
        }
    }
}