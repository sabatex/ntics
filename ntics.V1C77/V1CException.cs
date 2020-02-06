using System;
using System.Collections.Generic;
using System.Text;

namespace ntics.V1C77
{
    public class V1CException : Exception
    {
        public V1CException(){}
        public V1CException(string message) : base(message) { }
    }
}
