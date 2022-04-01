using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaHub.UserDefinedExceptions
{
    class InvalidToppingSelectedException : Exception
    {
        public InvalidToppingSelectedException(string message) : base(message)
        {

        }
    }
}
