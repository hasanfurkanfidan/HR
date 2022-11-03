namespace Core.Abstract
{
    public interface IResult
    {
        bool IsSuccessful { get; }
        string Message { get; }
    }
}