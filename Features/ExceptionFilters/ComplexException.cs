using System;
using System.Collections.Generic;

namespace Features.ExceptionFilters
{
    public class ComplexException : Exception
    {
        /*
        * This expection type reuses the auto property setup for its contained details.
        */
        public string AdditionalInfo { get; }
        public IEnumerable<Exception> NestedExceptions { get; } = new List<Exception>();

        public ComplexException(string message, string otherDetails, IEnumerable<Exception> nestedExcpetions) : base(message)
        {
            AdditionalInfo = otherDetails;
            NestedExceptions = nestedExcpetions;
        }
    }
}