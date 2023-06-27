namespace Tools.Cqs.Commands
{
    internal class Result : IResult
    {
        public static Result Success()
        {
            return new Result(true, null);
        }

        public static Result Failure(string message)
        {
            return new Result(false, message);
        }

        public bool IsSuccess { get; init; }
        public bool IsFailure { get { return !IsSuccess; } }
        public string? Message { get; init; }

        internal Result(bool isSuccess, string? message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}