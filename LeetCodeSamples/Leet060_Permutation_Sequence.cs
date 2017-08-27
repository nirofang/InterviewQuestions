using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet060_Permutation_Sequence
    {
        static int getFactorial(int n)
        {
            int ret = n;
            while (--n != 0)
                ret *= n;
            return ret;
        }

        public static string getPermutation(int n, int k)
        {
            int fac = getFactorial(n);
            string candi = "123456789".Substring(0, n);
            char[] res = Enumerable.Repeat('0', n).ToArray();
            for (int i = 0; i < n; i++)
            {
                fac /= (n - i);
                int index = (k - 1) / fac;
                res[i] = candi[index];
                //candi.erase(index, 1); C++
                candi = candi.Remove(index, 1);

                k -= index * fac;
            }
            return new string(res);
        }

        public static string getPermutation2(int n, int k)
        {
            int[] nums = new int[n];
            int pCount = 1;
            for (int i = 0; i < n; ++i)
            {
                nums[i] = i + 1;
                pCount *= (i + 1);
            }

            k--;
            string res = "";
            for (int i = 0; i < n; i++)
            {
                pCount = pCount / (n - i);
                int selected = k / pCount;
                res += (char)('0' + nums[selected]);

                for (int j = selected; j < n - i - 1; j++)
                    nums[j] = nums[j + 1];
                k = k % pCount;
            }
            return res;
        }


        public static string getPermutation3(int n, int k)
        {
            int[] nums = new int[n];

            for (int i = 0; i < n; ++i)
            {
                nums[i] = i + 1;
            }

            var list = nums.ToList();
            for (int j = 0; j < k-1; j++)
            {
                nextPermutation(list);
            }
            char[] numchrs= new char[n];
            for (int i = 0; i < n; ++i)
            {
                numchrs[i] = (char)('0' + list[i]);
            }

            return new string(numchrs);
        }
        static void nextPermutation(List<int> num)
        {
            // Start typing your C/C++ solution below  
            // DO NOT write int main() function  
            //List<int>::iterator it = num.begin();

            int length = num.Count;

            int begin = 0;

            if (length < 2) begin = length - 1;
            int i = length - 1;
            for (; i > 0; i--)
                if (num[i] > num[i - 1]) break;
            begin = i;

            if (begin > 0)
            {
                int tmp = num[begin - 1];
                int j = length - 1;
                for (; j >= begin; j--)
                    if (num[j] > tmp) break;
                num[begin - 1] = num[j];
                num[j] = tmp;
            }

            int end = length - 1;
            while (begin < end)
            {
                int tmp = num[begin];
                num[begin] = num[end];
                num[end] = tmp;
                begin++;
                end--;
            }
        }

    }
}
