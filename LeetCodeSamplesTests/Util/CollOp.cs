using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples.Util
{

    public static class ColOp<T>
    {
        public static IEqualityComparer<ICollection<T>> comp = new CollEqualityComparer<T>();

        //public static IEqualityComparer<T> comp = new CollEqualityComparer<T>();

        internal static void AreEqual(List<List<T>> result, List<List<T>> exp)
        {
            Assert.IsNotNull(result);
            Assert.AreNotEqual(result.Count, 0);
            Assert.AreEqual(result.Count, exp.Count);

            for (int i=0; i<result.Count; i++)
            {
                //Assert.IsTrue(result[i].SequenceEqual(exp[i]));
                Assert.IsTrue(exp[i].All(x => result[i].Contains(x)));
            }
        }
    }

    public static class ColOp
    {
        public static IEqualityComparer<ICollection<int>> comp = new CollEqualityComparer();

        internal static void AreEqual(List<List<int>> result, List<List<int>> exp)
        {
            Assert.AreEqual(result.Count, exp.Count);

            Assert.IsTrue(result.All(x => exp.Contains(x, ColOp<int>.comp)));
            Assert.IsTrue(exp.All(x => result.Contains(x, ColOp<int>.comp)));
        }
    }


    class CollEqualityComparer : IEqualityComparer<ICollection<int>>
    {
        public bool Equals(ICollection<int> b1, ICollection<int> b2)
        {

            return b1.SequenceEqual(b2);
        }

        public int GetHashCode(ICollection<int> coll)
        {
            return coll.GetHashCode();
        }
    }


    class CollEqualityComparer<T> : IEqualityComparer<ICollection<T>>
    {
        public bool Equals(ICollection<T> b1, ICollection<T> b2)
        {

            return b1.SequenceEqual(b2);
        }


        public int GetHashCode(ICollection<T> coll)
        {
            return coll.GetHashCode();
        }

    }

}
