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
    public class Leet050_Pow_x_n_Tests
    {
        [TestMethod()]
        public void pow_Default_Test()
        {
            Assert.AreEqual(new Leet050_Pow_x_n().pow_Default(2.0, 5), 32.0);

            Assert.AreEqual(new Leet050_Pow_x_n().pow_Self(2.0, 5), 32.0);
        }
    }
}