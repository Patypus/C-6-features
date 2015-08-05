using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Features.StaticUsing.Mood;

namespace Features.StaticUsing
{
    public static class StaticUtilities
    {
        /**
        * The static using is in here to refer to enum values directly though it looses some context.
        */

        public static IEnumerable<Mood> PositiveMoodsCollection()
        {
            return new List<Mood>
            {
                Ecstatic,
                Happy,
                Cheerful
            };
        }

        public static IEnumerable<Mood> NeutralMoodsCollection()
        {
            return new List<Mood>
            {
                Alright,
                YeahYouKnow,
                Meh
            };
        }
    }
}
