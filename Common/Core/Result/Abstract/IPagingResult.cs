using Core.Abstract;

namespace Core.Abstract
{
    public interface IPagingResult<T> : IResult
    {
        IQueryable<T> Data { get; }
        int TotalItemCount { get; }
    }
}
