using FluentResults;

namespace Mangarr.Sources.FluentResults;

public static class Extensions
{
    public static bool TryGetError<TError>(this ResultBase result, out TError error)
        where TError : IError
    {
        error = default!;

        if (result.HasError<TError>())
        {
            error = (TError)result.Errors.First(x => x is TError);
        }

        return error is not null;
    }
}
