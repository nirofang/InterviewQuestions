using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSampleCode.Digit
{
    class FindSubset
    {
        internal static void RunSmaple()
        {
            int[] c = new int[] { 1, 2, 3, 5, 9 };


            //HashSet<string> subsetC = new HashSet<string>();
            //System.Collections.Queue q = new System.Collections.Queue();
            List<string> subsets = new List<string>();


            for (int i = 1; i < c.Length; i++)
            {

                subsets.Add(c[i-1].ToString());
                List<string> newSubsets = new List<string>();


                for (int j = 0; j < subsets.Count; j++)
                {
                    string newSubset = subsets[j] + c[i].ToString();
                    newSubsets.Add(newSubset);
                }
                subsets.AddRange(newSubsets);


            }
            subsets.Add(c[c.Length - 1].ToString());

            Console.WriteLine(string.Join(Environment.NewLine, subsets));
        }

        internal static void RunSample2()
        {
            int[] c = new int[] { 1, 2, 3, 5, 9 };

            int target = 1 << c.Length;
            Console.WriteLine(target);
            int temp = 1;
            string dstring = string.Empty;
            string substring = string.Empty;
            List<String> result = new List<string>();
            while (temp < target)
            {
                substring = string.Empty;
                dstring = Convert.ToString(temp, 2).PadLeft(5, '0');
                string dstring1 = string.Format("%b", temp);
                for (int i = 0; i < dstring.Length; i++)
                {
                    if (dstring[i].ToString() == "1")
                    {
                        substring += c[i].ToString();
                    }
                }
                result.Add(substring);

                temp++;
            }

            Console.WriteLine(string.Join("\r\n", result));
        }

    }
}
