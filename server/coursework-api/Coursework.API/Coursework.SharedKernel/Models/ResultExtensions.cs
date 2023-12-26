using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Coursework.SharedKernel.Models;

// Holds a way to convert a result to an iactionresult
// normally a this operator is the first parameter in a method
// it allows the parameter's type have another method to call, static in nature
public static class ResultExtensions
{
    public static IActionResult ToActionResult<T>(
        this Result<T> result)
    {
        if (result.Error is not null)
        {
            return new ObjectResult(result.Error?.Message ?? result.Error?.Exception?.Message ?? "System error")
            {
                StatusCode = (int?)result.Error?.ErrorCode ?? StatusCodes.Status500InternalServerError
            };
        }

        return result.Value is null
            ? new ObjectResult(result.Value) { StatusCode = StatusCodes.Status404NotFound }
            : new ObjectResult(result.Value) { StatusCode = StatusCodes.Status200OK };
    }
}