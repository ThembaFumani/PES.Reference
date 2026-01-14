namespace PES.Core
{
    public sealed class Result<T>
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public T Value { get; }
        public Error? Error { get; }

        protected Result(bool isSuccess, T value, Error error)
        {
            if (isSuccess && error != null) 
                throw new InvalidOperationException();
            if (!isSuccess && value != null) 
                throw new InvalidOperationException();

            IsSuccess = isSuccess;
            Value = value;
            Error = error;
        }

        public static Result<T> Success(T value) => new Result<T>(true, value, null);
        public static Result<T> Failure(Error error) => new Result<T>(false, default, error);
    }
}