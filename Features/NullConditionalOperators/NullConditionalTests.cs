using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Features.NullConditionalOperators.DataStructures;

namespace Features.NullConditionalOperators
{
    [TestFixture]
    public class NullConditionalTests
    {
        [Test]
        public void GetRoadAndNumberDetails_ReturnsExpectedElementsFromTestData()
        {
            var testDataCollection = CreateTestPeople();
            var filters = new PersonFilters();

            var result = filters.GetHouseAndRoadDetailsWherePresent(testDataCollection);
            var expected = new List<string> { "25 Somewhere Street", "12 Another Road" };

            CollectionAssert.AreEquivalent(expected, result);
        }

        private IEnumerable<Person> CreateTestPeople()
        {
            return new List<Person>
            {
                new Person { Forename = "Fred", Lastname = "Bloggs" },
                new Person { Lastname = "Smith", HomeAddress = new Address { HouseNumber = 25, Road = "Somewhere Street" } },
                new Person { Lastname = "Oates", HomeAddress = new Address { HouseNumber = 12, Road = "Another Road"  } }
            };
        }
    }
}
