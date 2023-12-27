namespace Coursework.SharedKernel.Models;

public record Error(
    string Message,
    Exception? Exception = null,
    ErrorCode? ErrorCode = null)
{
    public static readonly Error NotFound = new(
        "Not Found",
        null,
        Models.ErrorCode.NotFound
    );
}

// Record properties are init only when made this way as seen above
// this means that we can make a new record but cannot change a property
// after its creation


// Records allow you to define methods as normal