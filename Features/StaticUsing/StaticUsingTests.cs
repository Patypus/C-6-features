using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Features.StaticUsing.StaticUtilities;
using static Features.StaticUsing.Mood;

namespace Features.StaticUsing
{
    [TestFixture]
    public class StaticUsingTests
    {
        /**
        * There is nothing really that special to test here, it is just mainly to see how it compiles.
        */

        [Test]
        public void CheckPositiveMoods()
        {
            var mood = Cheerful;
            var positiveMoods = PositiveMoodsCollection();

            Assert.IsTrue(positiveMoods.Contains(mood));
        }

        [Test]
        public void CheckNeutralList()
        {
            var mood = Meh;
            var neutralMoods = NeutralMoodsCollection();

            Assert.IsTrue(neutralMoods.Contains(mood));
        }
    }
}
