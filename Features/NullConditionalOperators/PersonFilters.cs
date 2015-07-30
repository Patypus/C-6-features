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
            possitives and don't tell us about the collection of people we are filtering
            */
        }
    }
}
