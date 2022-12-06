using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop_3.Custom_Exception
{
    public class NumberOutOfRange : ArgumentOutOfRangeException
    {
        public NumberOutOfRange(string? paramName, string? message) : base(paramName, message)
        {

        }
    }
}
