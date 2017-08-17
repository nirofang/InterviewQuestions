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
    public class Leet090_Subsets_II_Tests
    {
        [TestMethod()]
        public void SubsetsWithDup_Test()
        {
            var result = new Leet090_Subsets_II().SubsetsWithDup(new int[] { 1, 2, 3 });

            result.Contains<IList<int>>(new List<int> { 3 }, ColOp.comp);

            List<List<int>> exp = new List<List<int>> { new List<int> { 3 }, new List<int> { 1 },
            new List<int> { 2 }, new List<int> { 1,2,3 },
            new List<int> { 1,3 }, new List<int> { 2,3 },
            new List<int> { 1,2 }, new List<int> {}};


            Assert.IsTrue(result.All(x => exp.Contains(x, ColOp.comp)));


            result = new Leet090_Subsets_II().SubsetsWithDup(new int[] { 3, 3 });
            exp = new List<List<int>> { new List<int> { 3,3 },new List<int> { 3 },new List<int> {} };


            Assert.IsTrue(result.All(x => exp.Contains(x, ColOp.comp)));

        }
    }
}