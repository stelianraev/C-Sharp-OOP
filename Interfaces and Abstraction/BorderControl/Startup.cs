using BorderControl.Contracts;
using BorderControl.Core;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace BorderControl
{
    public class Startup
    {
       public static void Main()
        {
            MofiedEngineFoodShortage foodShortage = new MofiedEngineFoodShortage();
            foodShortage.Run();
        }
    }
}
