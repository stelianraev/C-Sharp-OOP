using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Contracts
{
    interface ICallable
    {
        string Call(string number);
    }
}
