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
    public class Leet060_Permutation_Sequence_Tests
    {
        // http://blog.csdn.net/mijian1207mijian/article/details/52369499

        [TestMethod()]
        public void getPermutation_Test()
        {
            var res = Leet060_Permutation_Sequence.getPermutation(3, 3);

            Assert.AreEqual(res, "213");

            res = Leet060_Permutation_Sequence.getPermutation(3, 6);

            Assert.AreEqual(res, "321");

            res = Leet060_Permutation_Sequence.getPermutation2(3, 6);

            Assert.AreEqual(res, "321");

            res = Leet060_Permutation_Sequence.getPermutation3(3, 6);

            Assert.AreEqual(res, "321");

            // Index out of range
            //res = Leet060_Permutation_Sequence.getPermutation(3, 7);
        }
    }
}