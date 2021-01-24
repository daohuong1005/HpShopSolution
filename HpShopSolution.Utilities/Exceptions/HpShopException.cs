using System;
using System.Collections.Generic;
using System.Text;

namespace HpShopSolution.Utilities.Exceptions
{
    public class HpShopException : Exception
    {
        public HpShopException()
        {
        }

        public HpShopException(string message)
            : base(message)
        {
        }

        public HpShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
