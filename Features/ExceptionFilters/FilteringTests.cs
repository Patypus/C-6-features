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
            var exception = new ComplexException("message", "Additional message", true);
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
    }
}
