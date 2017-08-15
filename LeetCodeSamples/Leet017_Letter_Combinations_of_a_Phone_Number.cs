using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet017_Letter_Combinations_of_a_Phone_Number
    {
        public IList<string> LetterCombinations(string digits)
        {
            
            List<string> list = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return list;
            }

            Dictionary<char, List<string>> map = new Dictionary<char, List<string>>();
            map.Add('2', new List<string>() { "a", "b", "c" });
            map.Add('3', new List<string>() { "d", "e", "f" });
            map.Add('4', new List<string>() { "g", "h", "i" });
            map.Add('5', new List<string>() { "j", "k", "l" });
            map.Add('6', new List<string>() { "m", "n", "o" });
            map.Add('7', new List<string>() { "p", "q", "r", "s" });
            map.Add('8', new List<string>() { "t", "u", "v" });
            map.Add('9', new List<string>() { "w", "x", "y", "z" });
            generateString(digits, 0, "", list, map);
            return list;
        }

        private void generateString(string digits, int index, string s, List<string> list, Dictionary<char, List<string>> map)
        {
            if (index == digits.Length)
            {
                list.Add(s);
            }
            else
            {
                char c = digits[index];
                foreach (string ch in map[c])
                {
                    generateString(digits, index + 1, s + ch, list, map);
                }
            }
        }
    }
}
