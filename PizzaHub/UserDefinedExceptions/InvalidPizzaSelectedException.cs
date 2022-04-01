using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaHub.UserDefinedExceptions
{
    class InvalidPizzaSelectedException : Exception
    {
        public InvalidPizzaSelectedException(string message) : base(message)
        {

        }
    }
}
