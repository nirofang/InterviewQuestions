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
    public class Leet120_Triangle_Tests
    {
        [TestMethod()]
        public void MinimumTotal_Test()
        {
            var input = new List<List<int>>{
                new List<int>{ 2 }, new List<int>{ 3, 4 },
                new List<int>{ 6, 5, 7 }, new List<int>{ 4, 1, 8 ,3 }
            };

            // https://www.zhihu.com/question/56554741/answer/149512897
            // C# 中为什么List<List<T>> 不能转换为 IList<IList<T>> ?

            Assert.AreEqual(11, new Leet120_Triangle().MinimumTotal(input.Select(x=>x).ToList<IList<int>>()));
        }
    }
}