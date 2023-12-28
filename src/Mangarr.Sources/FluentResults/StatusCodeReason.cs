using System.Net;
using FluentResults;

namespace Mangarr.Sources.FluentResults;

public class StatusCodeReason : IReason
{
    public StatusCodeReason(HttpStatusCode? statusCode)
    {
        StatusCode = statusCode;
        Message = $"Status code: {statusCode}";
    }

    public HttpStatusCode? StatusCode { get; }
    public string Message { get; set; }
    public Dictionary<string, object>? Metadata { get; set; }
}
