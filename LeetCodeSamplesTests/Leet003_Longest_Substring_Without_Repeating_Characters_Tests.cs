using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples.Tests
{
    [TestClass()]
    public class Leet003_Longest_Substring_Without_Repeating_Characters_Tests
    {
        [TestMethod()]
        public void Length_Of_Longest_Substring_Test()
        {
            int length;
            // longest sub string of "abcdef" is "abcdef", length is 6
            length = new Leet003_Longest_Substring_Without_Repeating_Characters().Length_Of_Longest_Substring("abcdef");
            Assert.AreEqual(length, 6);

            // longest sub string of "abcdefabcdezxjqlmbcde" is "fabcdezxjqlm", length is 12
            length = new Leet003_Longest_Substring_Without_Repeating_Characters().Length_Of_Longest_Substring("abcdefabcdezxjqlmbcde");
            Assert.AreEqual(length, 12);

            // "ababcdacabde" "cabde"
            length = new Leet003_Longest_Substring_Without_Repeating_Characters().Length_Of_Longest_Substring("ababcdacabde");

            Assert.AreEqual(length, 5);


            length = new Leet003_Longest_Substring_Without_Repeating_Characters().Length_Of_Longest_Substring_Own("abcdef");
            Assert.AreEqual(length, 6);

            // longest sub string of "abcdefabcdezxjqlmbcde" is "fabcdezxjqlm", length is 12
            length = new Leet003_Longest_Substring_Without_Repeating_Characters().Length_Of_Longest_Substring_Own("abcdefabcdezxjqlmbcde");
            Assert.AreEqual(length, 12);

            // "ababcdacabde" "cabde"
            length = new Leet003_Longest_Substring_Without_Repeating_Characters().Length_Of_Longest_Substring_Own("ababcdacabde");

            Assert.AreEqual(length, 5);

            length = new Leet003_Longest_Substring_Without_Repeating_Characters().Length_Of_Longest_Substring_Own("a");
            Assert.AreEqual(length, 1);
        }
    }
}