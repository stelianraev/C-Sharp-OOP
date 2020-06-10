using Logger.Models.Enumeration;
using System.Dynamic;

namespace Logger.Models.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }
        Level Level { get; }
        long MessagesAppend { get; }
        void Append(IError error);
    }
}
