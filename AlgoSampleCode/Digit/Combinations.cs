using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSampleCode.Digit
{

    /// <summary>
    /// There is a collection "C" which contians numbers between 0 and 9, but not all of them. Given a number T, plesae write a function to return a number K, ensure K is the smallest one that larger than T. (The number "K" will be constitute by any number of "C").
    /// </summary>
    class Combinations
    {

        internal static void RunSmaple()
        {
            int[] c = new int[] { 0, 4, 5, 8, 9 };
            int T = 3235;
            int K = 0;
            //K = GetK(c, T);

            //if(K != 4000)
            //{
            //    throw new ArgumentException("Error result!");
            //}

            //c = new int[] { 0, 3, 5, 2, 9 };
            //K = GetK(c, T);

            //if (K != 3239)
            //{
            //    throw new ArgumentException("Error result!");
            //}

            //c = new int[] { 7, 2, 6 };
            //K = GetK(c, T);

            //if (K != 6222)
            //{
            //    throw new ArgumentException("Error result!");
            //}

            //c = new int[] { 0, 1, 2};
            //K = GetK(c, T);

            //if (K != 10000)
            //{
            //    throw new ArgumentException("Error result!");
            //}

            //T = 7779;
            //c = new int[] { 1, 2, 4, 5, 6, 7 };
            //K = GetK(c, T);

            //if (K != 11111)
            //{
            //    throw new ArgumentException("Error result!");
            //}

            //T = 2459;
            //c = new int[] { 1, 2, 4 };
            //K = GetK(c, T);

            //if (K != 4111)
            //{
            //    throw new ArgumentException("Error result!");
            //}


            T = 122459;
            c = new int[] { 1, 2, 4 };
            K = GetK(c, T);

            if (K != 124111)
            {
                throw new ArgumentException("Error result!");
            }
        }

        private static int GetK(int[] c, int t)
        {
            if (c.Count() == 0)
            {
                throw new ArgumentException("c is empty");
            }


            int tt = t;
            System.Collections.Stack sepT = new System.Collections.Stack();
            //System.Collections.Stack<int?> sepT1 = new System.Collections.Stack<int?>();
            System.Collections.Queue k = new System.Collections.Queue();
            bool resetUseSmallest = false;
            bool expandOneBit = false;

            // 特殊情况 T= 0; c里面全是0 退出

            // 取得T最高位
            while (tt != 0) {
                int mt = tt % 10;
                sepT.Push(mt);
                tt -= mt;
                tt = tt / 10;

            }
            int? bigger = null;

            while (sepT.Count != 0)
            {
                int? highBitT = sepT.Pop() as int?;


                // 如果找到相同数字 继续比价后面
                // 如果是最后一位相同，要找大一点的数
                if (FoundMatchingInC(c, highBitT) && sepT.Count!=0)
                {
                    k.Enqueue(highBitT);
                    continue;
                }
                // 否则找有没有比它大的数字， 如果找到后面都用最小值
                else if ((bigger = FoundBiggerOne(c, highBitT)) !=null)
                {
                    resetUseSmallest = true;
                    k.Enqueue(bigger);
                    break; 
                }

                // 如果都比它小就要 考虑下面的情况
                // 如果之前没有相等的情，扩充一位， 而且后面都取最小值
                // 如果之前有相等，按照反序找大一点的数字，如果找到了就把后面取最小，都没有就扩充最高位,后面取最小值。
                else
                {
                    expandOneBit = true;
                    break;
                }
            }

            SortFromSmallToBig(c);
            int small = c[0];

            if (expandOneBit)
            {
                int fillSamllLength = sepT.Count + 1;

                System.Collections.Stack tmpK = new System.Collections.Stack();
                while (k.Count != 0)
                {
                    tmpK.Push(k.Dequeue());
                }

                while (tmpK.Count != 0)
                {
                    bigger = FoundBiggerOne(c, tmpK.Pop() as int?);
                    if (bigger == null)
                    {
                        fillSamllLength++;
                        continue;
                    }
                    else
                    {
                        System.Collections.Stack tmpK2 = new System.Collections.Stack();
                        while (tmpK.Count != 0)
                        {
                            tmpK2.Push(tmpK.Pop());
                        }
                        while (tmpK2.Count != 0)
                        {
                            k.Enqueue(tmpK2.Pop());
                        }
                        k.Enqueue(bigger);
                        break;
                    }
                }
                if (k.Count != 0)
                {

                    for (int i = 0; i < fillSamllLength; i++)
                    {
                        k.Enqueue(small);
                    }
                }
                else if (k.Count == 0)
                {
                    //expand highest bit
                    //first non-zero smalleset
                    int nonZeroSmall = FirstNonZeroSmallest(c);
                    k.Enqueue(nonZeroSmall);
                    for (int i = 0; i < fillSamllLength; i++)
                    {
                        k.Enqueue(small);
                    }
                }

            }
            if (resetUseSmallest)
            {
                for (int i = 0; i < sepT.Count; i++)
                {
                    k.Enqueue(small);
                }
            }

            int kVal = 0;
            while(k.Count!=0)
            {
                var kv = k.Dequeue() as int?;
                if (kv.HasValue){
                    kVal = kVal*10 + kv.Value;
                }
            }


            return kVal;
        }
        

        private static int? FoundBiggerOne(int[] c, int? v)
        {
            int ?tv = null;
            if (v.HasValue)
            {
                foreach (int cc in c)
                {
                    if (cc > v && tv == null)
                    {
                        tv = cc;
                    }
                    else if (cc > v && cc < tv)
                    {
                        tv = cc;
                    }
                }
            }
            return tv;
        }

        private static void SortFromSmallToBig(int[] c)
        {
            int lengthC = c.Length;
            QuickSortArray(c, 0, lengthC - 1);
        }

        private static int FirstNonZeroSmallest(int[] c)
        {
            if (c.Count() == 0)
            {
                throw new ArgumentException("c is empty");
            }

            if (c[0] != 0) return c[0];

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i]!=0 )
                {
                    return c[i];
                }
            }
            return -1;
        }

        private static void QuickSortArray(int[] c, int left ,int right)
        {
            
            int? pivot = c[(left + right)/2];
            int i = left, j = right;
            while (c[i] < pivot)
            {
                i++;
            }
            while (c[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                //Swap
                int? tmp = c[i];
                c[i] = c[j];
                c[j] = tmp.Value;

                i++;
                j--;
            }


            // Recursive call
            if (left < j)
            {
                QuickSortArray(c, left, j);
            }

            if (i < right)
            {
                QuickSortArray(c, i, right);

            }
        }

        private static bool FoundMatchingInC(int[] c, int? v)
        {
            if (v.HasValue)
            {
                foreach(int cc in c)
                {
                    if (cc == v) return true;
                }
            }
            return false;
        }

        private static int GetTopT(int t)
        {
            throw new NotImplementedException();
        }
    }
}
