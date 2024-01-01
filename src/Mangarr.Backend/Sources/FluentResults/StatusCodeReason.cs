using System.Net;
using FluentResults;

namespace Mangarr.Backend.Sources.FluentResults;

public class StatusCodeReason : IReason
{
    public HttpStatusCode? StatusCode { get; }

    public StatusCodeReason(HttpStatusCode? statusCode)
    {
        StatusCode = statusCode;
        Message = $"Status code: {statusCode}";
    }

    public string Message { get; set; }
    public Dictionary<string, object>? Metadata { get; set; }
}
