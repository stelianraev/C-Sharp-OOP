using System;

namespace Telephony.Exceptions
{
    public class InvalidUrlException : Exception
    {
        private const string URL_MSG_EXCEPTION = "Invalid URL!";
        public InvalidUrlException()
            :base(URL_MSG_EXCEPTION)
        {
        }

        public InvalidUrlException(string message) 
            : base(message)
        {
        }
    }
}
