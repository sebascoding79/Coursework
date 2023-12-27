using Microsoft.AspNetCore.Mvc;

namespace Coursework.SharedKernel.Models;

public static class ResultMapper
{
    private static readonly Result OkResult = new();

    public static Result Ok() => OkResult;

    public static Result<T> Ok<T>(T? value = default) => new Result<T>(default, value);
}