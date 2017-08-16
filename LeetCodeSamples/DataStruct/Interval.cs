using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples.DataStruct
{
    // Definition for an interval.
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }

        public override bool Equals(object obj)
        {
            return start == ((Interval)obj).start && end == ((Interval)obj).end;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
