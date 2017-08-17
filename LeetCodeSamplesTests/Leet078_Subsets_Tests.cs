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
    public class Leet078_Subsets_Tests
    {
        [TestMethod()]
        public void Subsets_Test()
        {
//[
//  [3],
//  [1],
//  [2],
//  [1,2,3],
//  [1,3],
//  [2,3],
//  [1,2],
//  []
//]

            var result = new Leet078_Subsets().Subsets(new int[] { 1, 2, 3 });
            var output = result.Select(x => x.ToArray()).ToArray();
            //CollectionAssert.IsSubsetOf(output, new int[] { 3 });

                //new List<List<int>> { new List<int> { 3 }, new List<int> { 1 },
                //new List<int> { 2 }, new List<int> { 1,2,3 },
                //new List<int> { 1,3 }, new List<int> { 2,3 },
                //new List<int> { 1,2 }, new List<int> {}});
        }
    }
}