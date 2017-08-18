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
    public class Leet093_Restore_IP_Addresses_Tests
    {
        [TestMethod()]
        public void RestoreIpAddresses_Test()
        {
            var result = new Leet093_Restore_IP_Addresses().RestoreIpAddresses("25525511135");
            CollectionAssert.AreEqual(result.ToArray(), new string[] { "255.255.11.135", "255.255.111.35" });
        }
    }
}