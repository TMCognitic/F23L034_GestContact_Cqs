namespace Tools.Cqs.Commands
{
    public interface IResult
    {
        static IResult Success()
        {
            return new Result(true, null);
        }

        static IResult Failure(string message)
        {
            return new Result(false, message);
        }

        bool IsFailure { get; }
        bool IsSuccess { get; init; }
        string? Message { get; init; }
    }
}