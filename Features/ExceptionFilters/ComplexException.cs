using System;
using System.Collections.Generic;

namespace Features.ExceptionFilters
{
    public class ComplexException : Exception
    {
        /*
        * This expection type reuses the auto property setup for its contained details.
        */
        public bool CriticalError { get; }
        public IEnumerable<Exception> NestedExceptions { get; } = new List<Exception>();

        public ComplexException(string message, bool critical, IEnumerable<Exception> nestedExcpetions = null) : base(message)
        {
            CriticalError = critical;
            if (nestedExcpetions != null)
            { 
                NestedExceptions = nestedExcpetions;
            }
        }
    }
}