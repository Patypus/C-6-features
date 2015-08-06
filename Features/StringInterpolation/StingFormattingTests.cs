using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.StringInterpolation
{
    [TestFixture]
    public class StingFormattingTests
    {
        private StringFormatter _formatter;

        [TestFixtureSetUp]
        public void Setup()
        {
            _formatter = new StringFormatter();
        }

        [Test]
        public void FormatGreetingInsertsParameters()
        {
            var name = "Fred";
            var day = "Thursday";

            var result = _formatter.FormatGreeting(name, day);
            Assert.AreEqual("Hello Fred, how are you this Thursday?", result);
        }

        [Test]
        public void FormateWithMoreComplexParameter()
        {
            var name = "Mr \"Alias\"";
            var day = "day";

            var result = _formatter.FormatGreeting(name, day);
            Assert.AreEqual("Hello Mr \"Alias\", how are you this day?", result);
        }
    }
}
