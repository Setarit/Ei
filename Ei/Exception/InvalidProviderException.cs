using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Setarit.Ei.Exception
{
    class InvalidProviderException : System.Exception
    {
        public InvalidProviderException(string message) : base(message)
        {

        }
    }
}
