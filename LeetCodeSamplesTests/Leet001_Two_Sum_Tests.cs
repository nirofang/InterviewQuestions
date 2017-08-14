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
    public class Leet001_Two_Sum_Tests
    {
        [TestMethod()]
        public void Two_Sum_Tests()
        {
            int[] result = new Leet001_Two_Sum().Two_Sum_dic_n(new int[] { 1, 2, 3 }, 3);

            CollectionAssert.AreEqual(result, new int[] { 0, 1 });

            try
            {
                new Leet001_Two_Sum().Two_Sum_dic_n(null, 3);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.GetType(), typeof(ArgumentNullException));
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Two_Sum_Tests_Exception()
        {

            new Leet001_Two_Sum().Two_Sum_dic_n(null, 3);
        }


        [TestMethod()]
        public void Two_Sum_n2_Self_Tests()
        {
            int[] result = new Leet001_Two_Sum().Two_Sum_Self_n2(new int[] { 1, 2, 3 }, 3);

            CollectionAssert.AreEqual(result, new int[] { 0, 1 });
        }

        [TestMethod()]
        public void Two_Sum_dic_n_Self_Tests()
        {
            int[] result = new Leet001_Two_Sum().Two_Sum_dic_n_Self(new int[] { 1, 2, 3 }, 3);

            CollectionAssert.AreEqual(result, new int[] { 0, 1 });
        }

    }
}