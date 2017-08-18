using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples.Tests
{
    [TestClass()]
    public class Leet105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal_Tests
    {
        [TestMethod()]
        public void BuildTree_Test()
        {
            var result = new Leet105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal().
                BuildTree(new int[] { 2 ,1 ,4, 3}, new int[] { 4, 1, 3, 2 });


            
        }
    }
}