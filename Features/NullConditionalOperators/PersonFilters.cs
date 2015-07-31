using Features.NullConditionalOperators.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.NullConditionalOperators
{
    public class PersonFilters
    {
        public IEnumerable<string> GetHouseAndRoadDetailsWherePresent(IEnumerable<Person> personCollection)
        {
            return personCollection.Select(p => p?.HomeAddress?.HouseNumber + " " + p?.HomeAddress?.Road)
                                   .Where(result => result != " ");
            /*
            Need the Where clause at the end because if HomeAddress is null the select result is 
            null + " " + null
            so we need to filter out these single space results as these are effectively false
            possitives and don't tell us about the collection of people we are filtering.

            This is true for sting concatenation in this case. String.join behaves differently to joining
            nulls and returns String.Empty. In this case the .Where would need to filter out empty strings.
            */
        }

        public IEnumerable<string> CollectFirstNamesWithNullCoalescing(IEnumerable<Person> personCollection)
        {
            return personCollection.Select(p => p?.Forename ?? "Unknown");
        }

        public IEnumerable<string> CollectNamesByDateWithNullCheckOnParameter(IEnumerable<Person> personCollection, DateTime baseDate)
        {
            return personCollection?.Where(p => p.DateJoined > baseDate)
                                    .Select(p => p?.Forename + " " + p?.Lastname);
        }

        public IEnumerable<string> CollectNamesByDate_ReturningEmptyCollectionFullNullParameter(IEnumerable<Person> personCollection, 
                                                                                                DateTime baseDate)
        {
            var filter = personCollection?.Where(p => p.DateJoined > baseDate)
                                          .Select(p => p?.Forename + " " + p?.Lastname);

            return filter ?? new List<string>();
        }
    }
}
