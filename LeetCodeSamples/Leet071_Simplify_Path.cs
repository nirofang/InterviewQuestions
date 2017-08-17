using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet071_Simplify_Path
    {
        public string SimplifyPath(string path)
        {
            if (String.IsNullOrEmpty(path))
            {
                return "";
            }

            string[] paths = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (paths.Length == 0)
            {
                return "/";
            }
            if (paths.Length == 1)
            {
                if (paths[0] == "." || paths[0] == "..")
                {
                    return "/";
                }
                else
                {
                    return "/" + paths[0];
                }
            }
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < paths.Length; i++)
            {
                string s = paths[i];
                if (s == ".")
                {
                    continue;
                }
                else if (s == "..")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(s);
                }
            }

            string result = "";
            if (stack.Count == 0)
            {
                return "/";
            }
            while (stack.Count > 0)
            {
                result = "/" + stack.Pop() + result;
            }

            return result;
        }
    }
}
