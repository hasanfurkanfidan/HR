namespace Core.Abstract
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}