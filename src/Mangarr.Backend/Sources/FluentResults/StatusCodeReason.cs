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

    public override string ToString() => new ReasonStringBuilder()
        .WithReasonType(GetType())
        .WithInfo("Status Code", StatusCode.ToString())
        .WithInfo("Message", Message)
        .Build();
}
