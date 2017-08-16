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
    public class Leet057_Insert_Interval_Tests
    {
        [TestMethod()]
        public void Insert_Test()
        {
            var result = new Leet057_Insert_Interval().Insert(new List<Interval> {
                new Interval(1, 3), new Interval(8, 10), new Interval(15, 18)}, new Interval(2, 6));
            CollectionAssert.AreEqual(result.ToArray(), new List<Interval> {
                new Interval(1, 6), new Interval(8, 10), new Interval(15, 18)});
        }
    }
}