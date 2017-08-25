using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet045_Jump_Game_II
    {

        // http://www.cnblogs.com/TenosDoIt/p/3719630.html

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool canJump(int[] A, int n)
        {
            if (n == 1)
            {
                return true;
            }
            else if(A[0] == 0)
            {
                return false;
            }
            //bool canArrive[n];    for java
            //memset(canArrive, 0, sizeof(canArrive));  for java
            bool[] canArrive = Enumerable.Repeat(false, n).ToArray();

            canArrive[0] = true;
            for (int i = 0; i < n; i++)
            {
                if (canArrive[i] == false)
                {
                    continue;
                }
                int farest = Math.Min(i + A[i], n - 1);
                for (int j = i + 1; j <= farest; j++)
                {
                    canArrive[j] = true;
                }
                if (canArrive[n - 1])
                {
                    return true;
                }
            }
            return canArrive[n - 1];
        }


        public static bool canJump2(int[] A, int n)
        {
            int canArrive = 0;//当前能到达的最远位置
            for (int i = 0; i <= canArrive && canArrive < n - 1; i++)
            {
                if (i + A[i] > canArrive) canArrive = i + A[i];
            }
            return canArrive >= n - 1;
        }
    }
}
