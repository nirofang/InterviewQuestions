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
    public class Leet055_Jump_Game_Tests
    {
        [TestMethod()]
        public void CanJump_Test()
        {
            Assert.IsTrue(new Leet055_Jump_Game().CanJump(new int[] { 2, 3, 1, 1, 4 }));
            Assert.IsFalse(new Leet055_Jump_Game().CanJump(new int[] { 3, 2, 1, 0, 4 }));

        }
    }
}