namespace Logger.Models.Contracts
{
    public interface IFile
    {
        string Path { get; }
        long Size { get; }

        string Write(ILayout lauout, IError error);
    }
}
