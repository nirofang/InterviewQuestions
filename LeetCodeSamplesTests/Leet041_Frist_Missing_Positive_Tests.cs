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
    public class Leet041_Frist_Missing_Positive_Tests
    {
        [TestMethod()]
        public void firstMissingPositive_Test()
        {
            int res = new Leet041_Frist_Missing_Positive().firstMissingPositive(new int[] { 1, 2, 0 });
            Assert.AreEqual(res, 3);

            res = new Leet041_Frist_Missing_Positive().firstMissingPositive(new int[] { 3, 4, -1, 1 });
            Assert.AreEqual(res, 2);


            res = new Leet041_Frist_Missing_Positive().firstMissingPositive_Default(new int[] { 1, 2, 0 });
            Assert.AreEqual(res, 3);

            res = new Leet041_Frist_Missing_Positive().firstMissingPositive_Default(new int[] { 3, 4, -1, 1 });
            Assert.AreEqual(res, 2);
        }
    }
}