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
                sums = UTIMCOSample.Parser.Parsing(UTIMCOSample.input.String1);

                Assert.AreEqual(sums.First(), 46);
                Assert.AreEqual(sums.Last(), 248);
            }
        }
    }
}
