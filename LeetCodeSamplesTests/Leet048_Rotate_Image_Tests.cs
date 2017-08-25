using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSamples.Util;

namespace LeetCodeSamples.Tests
{
    [TestClass()]
    public class Leet048_Rotate_Image_Tests
    {
        [TestMethod()]
        public void rotate_Test()
        {
            var col = new List<List<int>> {
                new List<int>{ 1, 2, 0 }, new List<int>{ 3, 0, 4 }, new List<int>{ 0, 5, 0 }
            };
            var exp = new List<List<int>> {
                new List<int>{ 0, 3, 1 }, new List<int>{ 5, 0, 2 }, new List<int>{ 0, 4, 0 }
            };
            Leet048_Rotate_Image.rotate(col);
            ColOp.AreEqual(col, exp);
        }
    }
}