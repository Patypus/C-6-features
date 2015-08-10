using NUnit.Framework;
using System;

namespace Features.ExpressionBodies
{
    [TestFixture]
    public class BodiedFunctionCallingTests
    {
        [Test]
        public void BodiedGetterReturnsUpdatedValue()
        {
            var now = DateTime.Now;
            var testItem = new BodiedFunctions(now, "Phillip");

            var result = testItem.FiveDaysLater;
            Assert.AreEqual(now.AddDays(5), result);
        }

        [Test]
        public void BodiedFunctionReturnsFormattedString()
        {
            var testData = new BodiedFunctions(DateTime.Now, "Bernard");

            var result = testData.GetNameInMessage();
            Assert.AreEqual("Welcome Bernard. Have a nice day!", result);
        }
    }
}
