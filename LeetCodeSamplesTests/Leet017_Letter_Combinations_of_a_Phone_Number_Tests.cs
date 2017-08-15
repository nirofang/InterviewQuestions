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
    public class Leet017_Letter_Combinations_of_a_Phone_Number_Tests
    {
        // input: 3 5 8


        // output
        //[0]	"djt"	string
        //[1]	"dju"	string
        //[2]	"djv"	string
        //[3]	"dkt"	string
        //[4]	"dku"	string
        //[5]	"dkv"	string
        //[6]	"dlt"	string
        //[7]	"dlu"	string
        //[8]	"dlv"	string
        //[9]	"ejt"	string
        //[10]	"eju"	string
        //[11]	"ejv"	string
        //[12]	"ekt"	string
        //[13]	"eku"	string
        //[14]	"ekv"	string
        //[15]	"elt"	string
        //[16]	"elu"	string
        //[17]	"elv"	string
        //[18]	"fjt"	string
        //[19]	"fju"	string
        //[20]	"fjv"	string
        //[21]	"fkt"	string
        //[22]	"fku"	string
        //[23]	"fkv"	string
        //[24]	"flt"	string
        //[25]	"flu"	string
        //[26]	"flv"	string



[TestMethod()]
        public void LetterCombinations_Test()
        {
            var result = new Leet017_Letter_Combinations_of_a_Phone_Number().LetterCombinations("358");
            Assert.AreEqual(result.Count, 27);
            
        }
    }
}