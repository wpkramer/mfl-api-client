using System;

namespace Mfl.Api.Common
{

    /// <summary>
    /// Represents the outcome of an operation, indicating success or failure and providing an optional message and
    /// exception.
    /// </summary>
    /// <remarks>Use the static methods <see cref="Success"/> and <see cref="Failure"/> to create instances
    /// representing successful or failed results. This struct is commonly used to return operation status without
    /// throwing exceptions, enabling callers to inspect the result and handle errors in a consistent manner.</remarks>
    public readonly struct Result
    {
        public bool IsSuccess { get; }
        public string Message { get; }  // or ErrorMessage
        public Exception? Exception { get; }

        private Result(bool isSuccess, string message, Exception? exception = null)
        {
            IsSuccess = isSuccess;
            Message = message;
            Exception = exception;
        }

        public static Result Success() => new(true, "Success");
        public static Result Failure(string message, Exception? exception = null) =>
            new(false, message, exception);
    }

    /// <summary>
    /// Represents the outcome of an operation, containing either a successful result value or error information.
    /// </summary>
    /// <remarks>A Result<T> instance indicates whether an operation succeeded or failed. On success, the
    /// Value property contains the result; on failure, Message and optionally Exception provide error details.
    /// This type is commonly used to avoid exceptions for control flow and to make error handling explicit.</remarks>
    /// <typeparam name="T">The type of the value returned on success.</typeparam>
    public readonly struct Result<T>
    {
        public bool IsSuccess { get; }
        public T? Value { get; }
        public string? Message { get; }
        public Exception? Exception { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSuccess"></param>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        /// <param name="exception"></param>
        private Result(bool isSuccess, T? value, string? errorMessage, Exception? exception)
        {
            IsSuccess = isSuccess;
            Value = value;
            Message = errorMessage;
            Exception = exception;
        }

        /// <summary>
        /// Creates a successful result containing the specified value.
        /// </summary>
        /// <param name="value">The value to associate with the successful result. This value will be accessible from the returned <see
        /// cref="Result{T}"/> instance.</param>
        /// <returns>A <see cref="Result{T}"/> instance representing a successful operation with the specified value.</returns>
        public static Result<T> Success(T value) =>
            new(true, value, null, null);

        /// <summary>
        /// Creates a failed result with the specified error message and optional exception.
        /// </summary>
        /// <param name="errorMessage">The error message that describes the reason for the failure. Cannot be null or empty.</param>
        /// <param name="exception">An optional exception that provides additional details about the failure. May be null if no exception is
        /// associated with the failure.</param>
        /// <returns>A <see cref="Result{T}"/> instance representing a failed operation, containing the specified error message
        /// and exception.</returns>
        public static Result<T> Failure(string errorMessage, Exception? exception = null) =>
            new(false, default, errorMessage, exception);

        /// <summary>
        /// Creates a failed result that encapsulates the specified exception.
        /// </summary>
        /// <param name="exception">The exception that describes the failure. Cannot be null.</param>
        /// <returns>A <see cref="Result{T}"/> representing a failed operation, containing the provided exception information.</returns>
        public static Result<T> Failure(Exception exception) =>
            Failure(exception.Message, exception);
    }
}
