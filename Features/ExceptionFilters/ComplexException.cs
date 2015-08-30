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
        public bool CriticalError { get; }
        public IEnumerable<Exception> NestedExceptions { get; } = new List<Exception>();

        public ComplexException(string message, string otherDetails, bool critical, IEnumerable<Exception> nestedExcpetions = null)
            : base(message)
        {
            AdditionalInfo = otherDetails;
            CriticalError = critical;
            if (nestedExcpetions != null)
            { 
                NestedExceptions = nestedExcpetions;
            }
        }
    }
}