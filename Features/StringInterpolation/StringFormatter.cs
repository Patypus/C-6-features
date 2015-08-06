using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.StringInterpolation
{
    public class StringFormatter
    {
        public string FormatGreeting(string name, string day)
        {
            return $"Hello {name}, how are you this {day}?";
        }
    }
}
