using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples.Util
{

    public static class ColOp
    {
        public static IEqualityComparer<ICollection<int>> comp = new CollEqualityComparer();
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


}
