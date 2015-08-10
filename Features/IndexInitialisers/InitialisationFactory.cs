using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.IndexInitialisers
{
    public static class InitialisationFactory
    {
        /*
        * This example uses the dictionary as the indexed collection.
        */
        public static IDictionary<string, Record> CreateTestRecords()
        {
            var recordOne = new Record { Name = "Athos", DateOfBirth = new DateTime(1615, 12, 3), Email = "athos@kingsguard.fr" };
            var recordTwo = new Record { Name = "Porthos", DateOfBirth = new DateTime(1620, 7, 14), Email = "porthos@kingsguard.fr" };
            var recordThree = new Record { Name = "Aramis", DateOfBirth = new DateTime(1618, 8, 23), Email = "aramis@kingsguard.fr" };

            return new Dictionary<string, Record>
            {
                ["muskateerOne"] = recordOne,
                ["muskateerTwo"] = recordTwo,
                ["muskateerThree"] = recordThree
            };
        }
    }
}
