using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterview001
{
    public class Algo001_SubString
    {
        public static string RunTest001_ByExtraArray(string input)
        {
            string giStr = input;
            string outArr = string.Empty;
            outArr = GetSub(giStr, outArr);
            Console.WriteLine(outArr);
            return outArr;
        }

        /// <summary>
        /// Given a string, find the length of the longest substring without repeating characters.
        /// </summary>
        /// <returns></returns>
        private static string GetSub(string giStr, string outArr)
        {
            if (string.IsNullOrEmpty(giStr))
                return giStr;

            if (giStr.Length == 1)
                return giStr;

            int i = 1;
            int j = 0;
            string outStr = giStr.Substring(j, i);
            string temStr = string.Empty;
            while (true)
            {
                // 遍历字符串
                string reChar = giStr.Substring(j + i, 1);
                if (outStr.Contains(reChar))
                {
                    int temInt = outStr.IndexOf(reChar);
                    //j = j + i - outStr.Length + temInt + 1;
                    j = j + temInt + 1;
                    i = i - temInt - 1;
                    GetOutArr(ref temStr, ref outStr, ref outArr);
                }
                // 结束字符串遍历并退出循环
                i++;
                outStr = giStr.Substring(j, i);
                if (i + j >= giStr.Length)
                {
                    GetOutArr(ref temStr, ref outStr, ref outArr);
                    break;
                }
            }

            return outArr;
        }

        /// <summary>
        /// Temporary records
        /// </summary>
        /// <param name="temStr"></param>
        /// <param name="outStr"></param>
        /// <param name="outArr"></param>
        /// <returns></returns>
        private static void GetOutArr(ref string temStr, ref string outStr, ref string outArr)
        {
            if (string.IsNullOrEmpty(temStr) || temStr.Length < outStr.Length)
            {
                temStr = outStr;
                outArr = temStr;
            }
            else if (temStr.Length == outStr.Length && !temStr.Equals(outStr))
            {
                outArr = string.Format("{0} And {1}", outArr, outStr);
            }
        }


        public static string RunTest002_ByMultiIndex(string input)
        {
            string giStr = input;
            string outArr = string.Empty;
            int length = 0;
            outArr = GetSub2(giStr, outArr, ref length);
            //Console.WriteLine(string.Format("the answer is {0}, with the length of {1}", outArr, length));
            //Console.ReadKey();
            return outArr;
        }

        /// <summary>
        /// Given a string, find the length of the longest substring without repeating characters.
        /// </summary>
        /// <param name="giStr">原始字符串</param>
        /// <param name="outArr">输出最长无重复字符串</param>
        /// <param name="length">输出最长无重复字符串的长度</param>
        /// <returns></returns>
        private static string GetSub2(string giStr, string outArr, ref int length)
        {
            if (string.IsNullOrEmpty(giStr))
                return giStr;


            if (giStr.Length == 1)
                return giStr;

            int i = 1; // 遍历字符串的长度
            int j = 0; // 遍历字符串在源字符串上的起始位置
            string outStr = giStr.Substring(j, i); // 可使用gistr,j,i替换
            int temMin = 0;
            while (true)
            {


                // 遍历字符串
                string reChar = giStr.Substring(j + i, 1);
                if (outStr.Contains(reChar))
                {
                    int temInt = outStr.IndexOf(reChar);
                    if (i > length)
                        length = GetOutArr(giStr, temMin, length, outStr, ref outArr);

                    j = j + temInt + 1;
                    i = i - temInt - 1;

                }
                // 结束字符串遍历并退出循环
                i++;
                outStr = giStr.Substring(j, i);
                if (i + j >= giStr.Length)
                {
                    length = GetOutArr(giStr, temMin, length, outStr, ref outArr);
                    break;
                }
            }

            return outArr;
        }

        /// <summary>
        /// Temporary records
        /// </summary>
        /// <param name="giStr">原始字符串</param>
        /// <param name="temMin">原前最长无重复字符串在原始字符串上的起始位置</param>
        /// <param name="length">原最长无重复字符串的长度</param>
        /// <param name="outStr">目前最长无重复字符串（可使用j,i替换）</param>
        /// <param name="outArr">输出最长无重复字符串</param>
        /// <returns>目前最长无重复字符串的长度</returns>
        private static int GetOutArr(string giStr, int temMin, int length, string outStr, ref string outArr)
        {
            string temStr = giStr.Substring(temMin, length);
            if (string.IsNullOrEmpty(temStr)
                || temStr.Length < outStr.Length)
                outArr = outStr;
            // 输出多个长度相等的字符串
            //else if (length == outStr.Length && !temStr.Equals(outStr))
            //    outArr = string.Format("{0} And {1}", outArr, outStr);

            return outStr.Length;
        }



        //public static string RuntTest003_ByMulitIndex2(string input)
        //{
        //    string output = GetSub3(input);
        //    Console.WriteLine(output);
        //    return output;
            
        //}

        //private static string GetSub3(string input)
        //{
        //    // k: substring start index
        //    // p: substring length
        //    // m: max length in history

        //    // km: max length' start index in history
        //    int k = 0, p = 0,m = 0, km = 0;

        //    if (string.IsNullOrEmpty(input))
        //        return input;

        //    do
        //    {
        //        // Find if k appear from km to km+1
        //        FindIndexFromRange(k, km, m);

                

        //    } while (k + m > input.Length);



        //}

        private static void FindIndexFromRange(int k, int km, int m)
        {
            
        }
    }
}
