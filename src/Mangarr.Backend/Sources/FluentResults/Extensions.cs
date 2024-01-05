using System.Diagnostics.CodeAnalysis;
using FluentResults;

namespace Mangarr.Backend.Sources.FluentResults;

public static class Extensions
{
    public static bool TryGetError<TError>(this ResultBase result, [NotNullWhen(true)] out TError error)
        where TError : IError
    {
        error = default!;

        if (result.HasError<TError>())
        {
            error = (TError)result.Errors.First(x => x is TError);
        }

        return error is not null;
    }

    public static bool TryGetReason<TReason>(this ResultBase result, [NotNullWhen(true)] out TReason? reason)
        where TReason : IReason
    {
        reason = (TReason)result.Reasons.FirstOrDefault(x => x is TReason);
        return reason is not null;
    }
}
