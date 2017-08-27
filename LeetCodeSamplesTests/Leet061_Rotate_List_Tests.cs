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
    public class Leet061_Rotate_List_Tests
    {
        [TestMethod()]
        public void rotateRight_Test()
        {
            ListNode list = new ListNode(new int[] { 1, 2, 3, 4, 5 });
            ListNode exp = new ListNode(new int[] { 4, 5, 1, 2, 3 });
            ListNode res = Leet061_Rotate_List.rotateRight(list, 2);
            Assert.AreEqual(res, exp);
        }
    }
}