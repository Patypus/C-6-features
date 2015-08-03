using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.AutoProperties
{
    [TestFixture]
    public class AutoPropertiesTests
    {
        [Test]
        public void ConstructorSetterSetsPropertyValue()
        {
            var customerName = "Clark Kent";
            var item = new AutoPropertyOrderItem(customerName, 12, 1);

            Assert.AreEqual(customerName, item.Customer);
        }

        [Test]
        public void DefaultValueIsReturnedByGetIfOtherValueIsNotSet()
        {
            var item = new AutoPropertyOrderItem();

            Assert.AreEqual("unknown", item.Customer);
        }

        // This is a compile failure too as Customer only exposes a getter and has no setter outside the 
        // automatically added one available to the constructor of AutoPropertyOrderItem.
        //
        //[Test]
        //public void CannotGiveValueToPropertyWithNoSetter()
        //{
        //    var item = new AutoPropertyOrderItem();

        //    item.Customer = "illegal update";
        //}
    }
}
