using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet041_Frist_Missing_Positive
    {
        public int firstMissingPositive(int[] A)
        {
            if (A == null ||  A.Length == 0)
            {
                return -1;
            }
            for(int i=0; i<A.Length; i++)
            {
                if(A[i]<0)
                {
                    return i;
                }
            }
            return A.Length;
        }

        /// <summary>
        /// Position of integer n should be n-1 if sorted
        /// correct form [1,2,3,4....#, n]
        /// if not in position swap it with a[a[p]-1]
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int firstMissingPositive_Default(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                return 1;
            }
            int n = A.Length;

            for(int i=0; i<n; i++)
            {
                int num = A[i];
                while(A[i]<=n && A[i]>0 && A[num-1]!=num)
                {
                    A[i] = A[num - 1];
                    A[num - 1] = num;
                    num = A[i];
                }
            }

            for(int i=0;i<n;i++)
            {
                if(A[i]!=i+1)
                {
                    return i + 1;
                }
            }
            return n + 1;   //nothing in middle lossing, return largest
        }
    }

}
