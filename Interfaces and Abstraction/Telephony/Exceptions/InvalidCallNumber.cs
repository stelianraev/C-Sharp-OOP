using System;

namespace Telephony.Exceptions
{
    public class InvalidCallNumber : Exception
    {
        private const string CALLING_MSG_EXCEPTION = "Invalid number!";
        public InvalidCallNumber()
            :base(CALLING_MSG_EXCEPTION)
        {
        }

        public InvalidCallNumber(string message) 
            : base(message)
        {
        }
    }
}
