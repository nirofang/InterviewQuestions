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
            var list = new List<Interval> {
                new Interval(1, 3), new Interval(8, 10),
                new Interval(15, 18)};

            var insert = new Interval(2, 6);
            
            var exp = new List<Interval> {
                new Interval(1, 6), new Interval(8, 10), new Interval(15, 18)};

            var result = new Leet057_Insert_Interval().Insert(list, insert);
            
            CollectionAssert.AreEqual(result.ToArray(), exp);

            result = Leet057_Insert_Interval.insert2(list, insert);

            CollectionAssert.AreEqual(result.ToArray(), exp);


            list = new List<Interval> {
                new Interval(1, 3), new Interval(8, 10),
                new Interval(15, 18), new Interval(23, 30)};

            insert = new Interval(6, 20);

            exp = new List<Interval> {
                new Interval(1, 3), new Interval(6, 20), new Interval(23, 30)};

            result = Leet057_Insert_Interval.insert2(list, insert);

            CollectionAssert.AreEqual(result.ToArray(), exp);


            list = new List<Interval> {
                new Interval(1, 3), new Interval(8, 10),
                new Interval(15, 18), new Interval(23, 30)};

            insert = new Interval(6, 16);

            exp = new List<Interval> {
                new Interval(1, 3), new Interval(6, 18), new Interval(23, 30)};

            result = Leet057_Insert_Interval.insert2(list, insert);

            CollectionAssert.AreEqual(result.ToArray(), exp);


        }
    }
}