using NUnit.Framework;

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

        [Test]
        public void FormatWorksWithPathSlashes()
        {
            var path = @"C:\Somewhere\over\the\rainbow.txt";
            var result = _formatter.FormatFileLocationMessage(path);

            Assert.AreEqual(@"The file you want is located at: C:\Somewhere\over\the\rainbow.txt", result);
        }

        [Test]
        public void FormatWorksWithBracketsInString()
        {
            var message = "hello world";
            var result = _formatter.FormatMessageWithBrackets(message);

            Assert.AreEqual("Your message hello world, {these are escaped}", result);
        }
    }
}
