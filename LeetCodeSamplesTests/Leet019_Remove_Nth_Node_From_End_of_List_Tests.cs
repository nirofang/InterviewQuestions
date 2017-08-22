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
    public class Leet019_Remove_Nth_Node_From_End_of_List_Tests
    {
        [TestMethod()]
        public void RemoveNthFromEnd_Test()
        {
            ListNode list = new ListNode(new int[] { 5, 7, 9, 5, 7, 9 });
            ListNode exp = new ListNode(new int[] { 5, 7, 9, 7, 9 });
            ListNode head = new Leet019_Remove_Nth_Node_From_End_of_List().RemoveNthFromEnd(list, 3);
            Assert.AreEqual(head, exp);

            list = new ListNode(new int[] { 5, 7, 9, 5, 7, 9 });
            exp = new ListNode(new int[] { 5, 7, 9, 7, 9 });
            head = new Leet019_Remove_Nth_Node_From_End_of_List().RemoveNthFromEnd_Own(list, 3);
            Assert.AreEqual(head, exp);

        }
    }
}