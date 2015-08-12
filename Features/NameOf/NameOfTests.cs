using NUnit.Framework;
using static Features.NameOf.VerboseMessageProvider;

namespace Features.NameOf
{
    [TestFixture]
    public class NameOfTests
    {
        [Test]
        public void NameOfParameterIncludedInMessage()
        {
            var paramValue = "'to be passed in'";
            var result = GetMessageWithDetailsOfImplementation(paramValue);

            Assert.AreEqual("Value of passedMessage passed to the method was " + paramValue, result);
        }
    }
}