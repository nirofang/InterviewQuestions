using AlgoSampleCode.Digit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input= "adDabGEfg";
            string input = "qweQrTtyEuiWoplYkjhgUfdsRazxRcvbnEmQWEaRTYaUIsasOPLKbfJHsGFDafSAaZXCVaBaNaMafertanwerYdfadsfaeNE";
            Console.WriteLine(input);

            //输入一个包含大写字母，小写字母 的字符串，写个方法来保障小写字母都在大写字母的前面
            // 从一侧找小写和前面最左边的大写交换
            string ouput = ConvertLowerToBegin(input.ToCharArray());

            // 冒泡思想，依次比价第一个和后面的只要有小写在后面就交换到前面， 效率最低
            ouput = ConvertLowerToBegin3(input.ToCharArray());

            //input = "AAAFFFEE";
            input = "Aa";
            // 双指针向中间移动 如果小写在后面就交换，结束条件是指针相遇， 效率最高
            ouput = ConvertLowerToBegin2(input.ToCharArray());

            input = "ab3bacgc3cddc4ccdd4effe55ee77kkk";
            char outChr = FindFirstNonRepeatChar(input.ToCharArray());

            // 输出螺旋矩阵
            Console.WriteLine("Spiral array n = 10");
            int[,] a = GetNNSpiralMatrix(10);

            Console.WriteLine("Spiral array n = 4");
            a = GetNNSpiralMatrix(4);


            /// There is a collection "C" which contians numbers between 0 and 9, but not all of them. Given a number T, plesae write a function to return a number K, ensure K is the smallest one that larger than T. (The number "K" will be constitute by any number of "C").
            Combinations.RunSmaple();


            // input {1, 3 ,5}
            // ouput all combinations like {1} {3} {1, 3}
            Console.WriteLine("Find all subsets of an array, solution 1");
            FindSubset.RunSmaple();
            Console.WriteLine("Find all subsets of an array, solution 2");
            FindSubset.RunSample2();


            // Removal of every 'kth' person from a circle. Find the last remaining person
            // http://stackoverflow.com/questions/3810789/removal-of-every-kth-person-from-a-circle-find-the-last-remaining-person

            // http://baike.baidu.com/link?url=59d3xu9IVjs8_zN1DaNhhTXuAgET_Ct0uzVSZeQdssDNHZ45Mg5wdXnJv6rpIM4_xpfgxCYvpuM2oVBcCyPmtR8ylO9dm7hOHZS2GUgoapo_zjq6IwjXnbZitSWPZoiejEjBal-1InnfhYxp-PzS0q

            // Solution 1: Use Mod O(n), hight efficient
            int result = JosephusProblem(6, 3);
            result = JosephusProblem(7, 3);

            // Solution 2: Use circle array, lower efficient
            JosephusProblem2(7, 3);

            // http://stackoverflow.com/questions/727707/finding-all-combinations-of-well-formed-brackets
            PrintValidBrackets(3);

        }

        private static void JosephusProblem2(int n, int k)
        {
            //var loosersLst = new List<bool>(n);
            //for (int i=0; i<n; i++)
            //{
            //    loosersLst.Add(false);
            //}
            bool[] loosers = Enumerable.Repeat<bool>(false, n).ToArray();
            int t = 0, s = 0, l = 0;
            do
            {
                if (t == n)
                {
                    t = 0;
                }
                if (!(loosers[t]))
                {
                    s++;
                }
                if (s == k)
                {
                    s = 0;
                    loosers[t] = true;
                    Console.WriteLine("Looser {0} is kicked out!", t);
                    l++;
                }
                t++;
            } while (l < n);

        }

        private static void PrintValidBrackets(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintValidBrackets("", 0, 0, i);
            }
        }

        private static void PrintValidBrackets(string output, int open, int close, int pairs)
        {
            if ((open == pairs) && (close == pairs))
            {
                Console.WriteLine(output);
            }
            else
            {
                if (open < pairs)
                    PrintValidBrackets(output + "(", open + 1, close, pairs);
                if (close < open)
                    PrintValidBrackets(output + ")", open, close + 1, pairs);
            }
        }

        static int JosephusProblem(int n, int k)
        {
            int r = 0;
            for (int i = 2; i <= n; i++)
                r = (r + k) % i;
            Console.WriteLine("{0} is the winner of n:{1} k:{2}", r, n ,k);
            return r;
        }


        static string ConvertLowerToBegin(char[] content)
        {
            int upperPos = 0;
            bool firstUppoer = false;
            int count = 0;

            for (int i = 0; i < content.Length; i++)
            {
                if (char.IsLetter(content[i]) && char.IsUpper(content[i]) && !firstUppoer)
                {
                    upperPos = i;
                    firstUppoer = true;
                }
                else if (char.IsLetter(content[i]) && char.IsLower(content[i]) && firstUppoer)
                {
                    if (upperPos < i)
                    {
                        char tmp = content[i];
                        content[i] = content[upperPos];
                        content[upperPos] = tmp;

                        upperPos++;
                    }
                }
                count++;
            }



            return content.ToString();
        }
        static string ConvertLowerToBegin3(char[] content)
        {
            int count = 0;
            for (int m = 0; m < content.Length; m++)
            {
                for (int n = m + 1; n < content.Length; n++)
                {
                    if (char.IsUpper(content[m]) && char.IsLower(content[n]))
                    {
                        char temp = content[m];
                        content[m] = content[n];
                        content[n] = temp;
                        break;
                    }
                    count++;
                }
            }

            return content.ToString();
        }


        static string ConvertLowerToBegin2(char[] content)
        {

            int start = 0;
            int end = content.Length - 1;
            int count = 0;

            while (start<end)
            {
                //while (content[start] >= 'a') {
                while (char.IsLower(content[start]))
                {
                    if (start >= end) break;
                    start++;

                    count++;
                }
                //while (content[end] >= 'A' && content[end] < 'a') {
                while (char.IsUpper(content[end]))
                {
                    if (start >= end) break;
                    end--;

                    count++;
                }
                if (start < end)
                {
                    char tmp = content[start];
                    content[start] = content[end];
                    content[end] = tmp;
                }
                start++;
                end--;
            }

            return content.ToString();
        }


        static char FindFirstNonRepeatChar(char[] content)
        {
            if (content == null)
            {
                throw new ArgumentException("Input array cannot be null!");
            }
            Dictionary<char, int> chDic = new Dictionary<char, int>();
            for (int i = 0; i < content.Length; i++)
            {
                if (!chDic.ContainsKey(content[i]))
                    chDic[content[i]] = 1;
                else
                    chDic[content[i]]++;
            }
            //var chCol = chDic.Where(c => c.Value == 1);
            //if (chCol.Count() > 0)
            //    return chCol.First().Key;
            //else
            //    throw new ArgumentException("input parameter doesn't contain non-repeat char!");

            for (int i = 0; i < content.Length; i++)
            {
                if (chDic[content[i]]==1)
                {
                    return content[i];
                }
            }
            throw new ArgumentException("input parameter doesn't contain non-repeat char!");
        }

        /// <summary>
        /// 1   2   3   4
        /// 12  13  14  5
        /// 11  16  15  6 
        /// 10  9   8   7
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int[,]GetNNSpiralMatrix(int n)
        {
            int[,] a = new int[n, n];

            int c = 0, i = 0, j = 0, o= 1,z;

            z = n * n;
            while (o <= z)
            {
                i = 0; /*每轮后初始化下i,j */
                j = 0;
                for (i += c, j += c; j < n - c; j++)
                {
                    if (o > z) break; a[i, j] = o++;
                }/* 从左至右的循环 */
                for (j--, i = i + 1; i < n - c; i++)
                {
                    if (o > z) break; a[i, j] = o++;
                }/* 从上至下的循环 */
                for (i--, j = j - 1; j >= c; j--)
                { if (o > z) break; a[i, j] = o++; }/* 从右至左的循环 */
                for (j++, i = i - 1; i > c; i--)
                { if (o > z) break; a[i, j] = o++; }/* 从下至上的循环 */
                c++;
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine();
            }
            return a;
        }
    }
}
