using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.ExceptionFilters
{
    [TestFixture]
    public class FilteringTests
    {
        /*
        * Test class contains filtering examples to keep the structure simple.
        */

        [Test]
        public void BasicFilter()
        {
            var exceptionFiltered = false;
            var exception = new ComplexException("message", true);
            var thrower = new ExceptionThrower(exception);

            try
            {
                thrower.Throw();
            }
            catch (ComplexException caught) when (caught.CriticalError)
            {
                exceptionFiltered = true;
            }

            Assert.IsTrue(exceptionFiltered);
        }

        [Test]
        public void ComplexFilter()
        {
            var uniquePhrase = "Test_For_Uniqueness";
            var exceptionFiltered = false;
            var exceptionCollection = new List<Exception> { new Exception ("exception One"), new Exception(uniquePhrase) };
            var exception = new ComplexException("Message", false, exceptionCollection);
            var thrower = new ExceptionThrower(exception);

            try
            {
                thrower.Throw();
            }
            catch (ComplexException caught) when (!caught.NestedExceptions.Any()) 
            {
                Assert.Fail("Should not get to this part.");
            }
            catch (ComplexException caught) when (caught.NestedExceptions.Any(nested => nested.Message.Contains(uniquePhrase)))
            {
                exceptionFiltered = true;
            }

            Assert.IsTrue(exceptionFiltered);
        }
    }
}
