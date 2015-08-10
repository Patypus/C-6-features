using NUnit.Framework;
using static Features.IndexInitialisers.InitialisationFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.IndexInitialisers
{
    [TestFixture]
    public class InitialisationTests
    {
        [Test]
        public void TestInitialisedDictionary()
        {
            var createdDictionary = CreateTestRecords();

            Assert.AreEqual("Athos", createdDictionary["muskateerOne"].Name);
            Assert.AreEqual("Porthos", createdDictionary["muskateerTwo"].Name);
            Assert.AreEqual("Aramis", createdDictionary["muskateerThree"].Name);
        }
    }
}
