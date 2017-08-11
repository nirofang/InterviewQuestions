using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoInterview001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterview001.Tests
{
    [TestClass()]
    public class Algo001_SubStringTests
    {
        [TestMethod()]
        public void RunTestTest()
        {
            string expText;

            expText = DemoInterview001.Algo001_SubString.RunTest001_ByExtraArray("abcabeabc");
            Assert.AreEqual(expText, "cabe And eabc");

            expText = DemoInterview001.Algo001_SubString.RunTest001_ByExtraArray("a");
            Assert.AreEqual(expText, "a");

            expText = DemoInterview001.Algo001_SubString.RunTest001_ByExtraArray("ab");
            Assert.AreEqual(expText, "ab");

            expText = DemoInterview001.Algo001_SubString.RunTest001_ByExtraArray(null);
            Assert.IsNull(expText);

            expText = DemoInterview001.Algo001_SubString.RunTest001_ByExtraArray("你好中国中国人你好么");
            Assert.AreEqual(expText, "中国人你好么");



            expText = DemoInterview001.Algo001_SubString.RunTest002_ByMultiIndex("abcabeabc");
            Assert.AreEqual(expText, "cabe");

            expText = DemoInterview001.Algo001_SubString.RunTest002_ByMultiIndex("a");
            Assert.AreEqual(expText, "a");

            expText = DemoInterview001.Algo001_SubString.RunTest002_ByMultiIndex("ab");
            Assert.AreEqual(expText, "ab");

            expText = DemoInterview001.Algo001_SubString.RunTest002_ByMultiIndex(null);
            Assert.IsNull(expText);

            expText = DemoInterview001.Algo001_SubString.RunTest002_ByMultiIndex("你好中国中国人你好么");
            Assert.AreEqual(expText, "中国人你好么");

        }
    }
}