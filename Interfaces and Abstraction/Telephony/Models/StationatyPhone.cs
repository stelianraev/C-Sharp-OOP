using System.Linq;
using Telephony.Contracts;
using Telephony.Exceptions;

namespace Telephony.Models
{
    public class StationatyPhone : ICallable
    {

        public StationatyPhone()
        {

        }
        public string Call(string number)
        {
            if (!number.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidCallNumber();
            }
            return $"Dialing... {number}";
            
        }
    }
}
