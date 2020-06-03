using MilitaryElite.Models;
using System.Collections;
using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
   public interface IEngineer
    {
        IReadOnlyCollection<Repair> Repairs { get; }
    }
}
