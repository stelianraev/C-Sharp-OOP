using System.Linq;
using Telephony.Contracts;
using Telephony.Exceptions;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public Smartphone()
        {

        }
        public string Browse(string url)
        {
            if(url.Any(ch => char.IsDigit(ch)))
            {
                throw new InvalidUrlException();
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if(!number.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidCallNumber();
            }
            return $"Calling... {number}";
        } 
    }
}
