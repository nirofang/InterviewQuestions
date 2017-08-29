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
    public class Leet109_Covert_Sorted_List_to_Binary_Search_Tree_Tests
    {
        [TestMethod()]
        public void SortedListToBST_Test()
        {
            ListNode list = new ListNode(new int[] { 3, 4, 5, 8, 11, 22, 33, 55 });
            TreeNode tree = Leet109_Covert_Sorted_List_to_Binary_Search_Tree.SortedListToBST(list);

        }
    }
}