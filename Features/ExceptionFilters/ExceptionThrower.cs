using System;

namespace Features.ExceptionFilters
{
    public class ExceptionThrower
    {
        private readonly Exception _throwable;

        public ExceptionThrower(Exception exceptionToThrow)
        {
            _throwable = exceptionToThrow;
        }

        public void Throw()
        {
            throw _throwable;
        }
    }
}