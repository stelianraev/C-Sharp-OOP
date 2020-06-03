using MilitaryElite.Models;
using System.Collections;
using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface IComando
    {
        IReadOnlyCollection<Mission> Missions { get; }

        void CompleteMission(string codeName);
    }
}
