using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace problemDetails.Exceptions
{
    public class KeyNotFoundException : Exception
    {

        public KeyNotFoundException(string message) : base(message)
        { }
    }
}