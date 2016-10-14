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
            int[] c = new int[] { 1, 2, 3, 5 ,9 };


            HashSet<string> subsetC = new HashSet<string>();
            System.Collections.Queue q = new System.Collections.Queue();
            bool foundDup = false;

            for (int i = 0; i < c.Length; i++)
            {
                
                foreach (string cv in subsetC)
                {
                    if (cv.IndexOf(c[i].ToString()) > 0)
                    {
                        foundDup = true;
                        continue;
                    }
                    foreach(char cvv in cv.ToCharArray())
                    {
                        Console.Write("{0} ", cvv);
                    }
                    Console.Write(c[i]);
                    q.Enqueue(cv + c[i].ToString());
                    Console.WriteLine();
                }
                if (!foundDup)
                {
                    while(q.Count!= 0 ){
                        subsetC.Add(q.Dequeue() as string);
                    }
                }
                string cs = c[i].ToString();
                if (!subsetC.Contains(cs))
                {
                    Console.WriteLine(cs);
                    subsetC.Add(cs);
                }
            }
        }

        internal static void RunSample2()
        {
            string abc = "12359";
            int target = 1 << abc.Length;
            Console.WriteLine(target);
            int temp = 0;
            string dstring = string.Empty;
            string substring = string.Empty;
            List<String> result = new List<string>();
            while (temp < target)
            {
                substring = string.Empty;
                dstring = Convert.ToString(temp, 2).PadLeft(5, '0');
                for (int i = 0; i < dstring.Length; i++)
                {
                    if (dstring[i].ToString() == "1")
                    {
                        substring += abc[i];
                    }
                }
                result.Add(substring);

                temp++;
            }

            Console.WriteLine(string.Join("\r\n", result));
        }
        
    }
}
