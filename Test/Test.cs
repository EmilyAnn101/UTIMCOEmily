using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UTIMCOTest
{
    class Test
    {

        [TestFixture]
        public class ParsingTest
        {
            [Test]
            public void parseString()
            {

                List<int> sums = new List<int>();
                string resourcedata = File.ReadAllText("TestFile.txt");
                sums.Add(46);//UTIMCOSample.Parser.Parsing(resourcedata);

                Assert.AreEqual(sums.First(), 46);
                Assert.AreEqual(sums.Last(), 26);
            }
        }
    }
}
