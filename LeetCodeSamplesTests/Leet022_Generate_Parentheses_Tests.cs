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
    public class Leet022_Generate_Parentheses_Tests
    {
        [TestMethod()]
        public void GenerateParenthesis_Test()
        {
            string[] exp = new string[] {
  "((()))",
  "(()())",
  "(())()",
  "()(())",
  "()()()"
            };
            new Leet022_Generate_Parentheses().GenerateParenthesis(4).SequenceEqual(exp);
        }
    }
}