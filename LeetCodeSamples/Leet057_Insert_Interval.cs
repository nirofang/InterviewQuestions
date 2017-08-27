using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet057_Insert_Interval
    {

        public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
        {
            int i = 0;
            IList<Interval> list = new List<Interval>();

            while (i < intervals.Count)
            {
                Interval v = intervals[i];
                if (isOverlap(newInterval, v))
                {
                    v.start = Math.Min(newInterval.start, v.start);
                    v.end = Math.Max(newInterval.end, v.end);
                    break;
                }
                else
                {
                    if (!list.Contains(newInterval) && v.start > newInterval.end)
                    {
                        list.Add(newInterval);
                    }
                    list.Add(v);
                }
                i++;
            }

            if (intervals.Count == 0)
            {
                list.Add(newInterval);
            }
            else
            {
                if (i < intervals.Count - 1)
                {
                    int index = i + 1;

                    Interval v2 = intervals[i];
                    while (index < intervals.Count)
                    {
                        Interval v1 = intervals[index];
                        if (isOverlap(v1, v2))
                        {
                            v2.start = Math.Min(v1.start, v2.start);
                            v2.end = Math.Max(v1.end, v2.end);
                        }
                        else
                        {
                            if (!list.Contains(v2))
                            {
                                list.Add(v2);
                            }
                            list.Add(v1);
                        }
                        index++;
                    }

                    if (!list.Contains(v2))
                    {
                        list.Add(v2);
                    }
                }
                else if (i == intervals.Count - 1)
                {
                    list.Add(intervals[i]);
                }
                else if (!list.Contains(newInterval))
                {
                    list.Add(newInterval);
                }
            }
            return list;
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


        public static List<Interval> insert2(List<Interval> intervals, Interval newInterval)
        {
            List<Interval> res = intervals;
            int i = 0, overlap = 0, n = res.Count;
            while (i < n)
            {
                if (newInterval.end < res[i].start) break;
                else if (newInterval.start > res[i].end) { }
                else
                {
                    newInterval.start = Math.Min(newInterval.start, res[i].start);
                    newInterval.end = Math.Max(newInterval.end, res[i].end);
                    ++overlap;
                }
                ++i;
            }
            if (overlap > 0) res.RemoveRange(i - overlap, overlap);
            res.Insert(i - overlap, newInterval);
            return res;
        }

    }

}
