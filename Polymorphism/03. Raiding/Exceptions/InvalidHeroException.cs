using System;

namespace Raiding.Exceptions
{
    public class InvalidHeroException : Exception
    {
        private const string INVALID_HERO_EXC = "Invalid hero!";
        public InvalidHeroException()
            :base(INVALID_HERO_EXC)
        {
        }

        public InvalidHeroException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
