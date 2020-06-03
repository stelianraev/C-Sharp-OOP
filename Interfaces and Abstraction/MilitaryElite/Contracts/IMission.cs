using MilitaryElite;
using System.Data;

namespace MilitaryElite.Contracts
{
    public interface IMission
    {
        string CodeName { get; }
        
        string State { get; }
    }
}
