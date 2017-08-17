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
    public class Leet079_Word_Search_Tests
    {
        [TestMethod()]
        public void Exist_Test()
        {
            char[,] input = new char[,] {
                { 'A', 'B', 'C', 'E' }, 
                { 'S', 'F', 'C', 'S' }, 
                { 'A', 'D', 'E', 'E' } };
            Assert.IsTrue(new Leet079_Word_Search().Exist(input, "ABCCED"));
            Assert.IsTrue(new Leet079_Word_Search().Exist(input, "SEE"));
            Assert.IsFalse(new Leet079_Word_Search().Exist(input, "ABCB"));
        }
    }
}