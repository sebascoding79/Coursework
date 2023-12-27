namespace Coursework.SharedKernel.Models;

public record Result(Error? Error = null)
{
    public void Deconstruct(
        out bool success,
        out string? errorMessage,
        out Exception? exception,
        out ErrorCode? errorCode)
    {
        success = this.Success;
        errorMessage = this.Error?.Message;
        exception = this.Error?.Exception;
        errorCode = this.Error?.ErrorCode;
    }
    /// <summary>
    /// If there are no errors then the error is null 
    /// </summary>
    public bool Success => this.Error is null;

    public static implicit operator Result(Exception exception) => 
        new Result(new Error(exception.Message, exception));

    /// <summary>
    /// Converts an Error object to a result
    /// </summary>
    /// <param name="error"></param>
    /// <returns></returns>
    public static implicit operator Result(Error error) => new(error);

    /// <summary>
    /// Converts a Result to a boolean value
    /// </summary>
    /// <returns></returns>
    public static implicit operator bool(Result result)
    {
        return result.Success;
    }
}

// Generic Version

public record Result<T>(Error? Error = null, T? Value = default) : Result(Error)
{
    public void Deconstruct(
        out bool success,
        out string? errorMessage,
        out Exception? exception,
        out ErrorCode? errorCode,
        out T? value)

    {
        success = this.Success;
        errorMessage = this.Error?.Message;
        exception = this.Error?.Exception;
        errorCode = this.Error?.ErrorCode;
        value = this.Value;
    }
    
    public static implicit operator Result<T>(Exception exception) => 
        new Result<T>(new Error(exception.Message, exception));

    /// <summary>
    /// Converts an Error object to a result
    /// </summary>
    /// <param name="error"></param>
    /// <returns></returns>
    public static implicit operator Result<T>(Error error) => new(error);

    public static implicit operator Result<T>(T? value) => new(null, value);
}