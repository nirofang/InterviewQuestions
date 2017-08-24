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
    public class Leet045_Jump_Game_II_Tests
    {
        [TestMethod()]
        public void canJump_Test()
        {
            Assert.IsTrue(Leet045_Jump_Game_II.canJump(new int[] { 2, 3, 1, 1, 4 }, 5));

            Assert.IsFalse(Leet045_Jump_Game_II.canJump(new int[] { 3, 2, 1, 0, 4 }, 5));
        }
    }
}