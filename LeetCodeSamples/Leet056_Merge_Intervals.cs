using LeetCodeSamples.DataStruct;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{


    public class Leet056_Merge_Intervals
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            IList<Interval> vals = new List<Interval>();
            foreach (Interval v1 in intervals)
            {
                int i = 0;
                while (i < vals.Count)
                {
                    Interval v2 = vals[i];
                    if (isOverlap(v1, v2))
                    {
                        v2.start = Math.Min(v1.start, v2.start);
                        v2.end = Math.Max(v1.end, v2.end);
                        break;
                    }
                    i++;
                }

                if (i < vals.Count)
                {
                    int index = vals.Count - 1;
                    Interval v2 = vals[i];
                    while (index > i)
                    {
                        Interval v3 = vals[index];
                        if (isOverlap(v2, v3))
                        {
                            v2.start = Math.Min(v3.start, v2.start);
                            v2.end = Math.Max(v3.end, v2.end);
                            vals.RemoveAt(index);
                        }
                        index--;
                    }
                }
                else
                {
                    vals.Add(v1);
                }
            }

            return vals;
        }

        private bool isOverlap(Interval v1, Interval v2)
        {
            if ((v2.start >= v1.start && v2.start <= v1.end) || (v1.start >= v2.start && v1.end <= v2.end))
            {
                return true;
            }
            if ((v2.end >= v1.start && v2.end <= v1.end) || (v1.end >= v2.start && v1.end <= v2.end))
            {
                return true;
            }
            if ((v1.start <= v2.start && v1.end >= v2.end) || (v2.start <= v1.start && v2.end >= v1.end))
            {
                return true;
            }
            return false;
        }




        //static bool comp(const Interval &a, const Interval &b) {
        //    return (a.start<b.start);
        //}
        

        public static List<Interval> merge2(List<Interval> intervals)
        {
            List<Interval> res = new List<Interval>();
            if (intervals.Count == 0)
            {
                return res;
            }
            //sort(intervals.begin(), intervals.end(), comp);
            IntervalComparer comp = new IntervalComparer();
            intervals.Sort(comp);

            res.Add(intervals[0]);
            for (int i = 1; i < intervals.Count; ++i)
            {
                if (res.Last().end >= intervals[i].start)
                {
                    res.Last().end = Math.Max(res.Last().end, intervals[i].end);
                }
                else
                {
                    res.Add(intervals[i]);
                }
            }
            return res;
        }

        class IntervalComparer : IComparer<Interval>
        {
            public int Compare(Interval x, Interval y)
            {
                return x.start - y.start;
            }
        }
    }
}
