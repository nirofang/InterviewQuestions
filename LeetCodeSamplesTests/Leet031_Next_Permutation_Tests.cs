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
    public class Leet031_Next_Permutation_Tests
    {
        [TestMethod()]
        public void NextPermutation_Test()
        {
            int[] input = new int[] { 1, 2, 3 };
            new Leet031_Next_Permutation().NextPermutation(input);
            int[] exp = new int[] { 1, 3, 2 };

            input = new int[] { 3, 2, 1 };
            new Leet031_Next_Permutation().NextPermutation(input);
            exp = new int[] { 1, 2, 3 };

            input = new int[] { 1, 1, 5 };
            new Leet031_Next_Permutation().NextPermutation(input);
            exp = new int[] { 1, 5, 1 };

            CollectionAssert.AreEqual(input, exp);
        }
    }
}