using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrankBot.Exceptions
{
    internal class NullException: Exception
    {
        public NullException()
        {

        }
        public NullException(string message) : base(message)
        {

        }
    }
}
