﻿using Injectio.Attributes;

namespace Mangarr.Stack.Sources.Clients;

[RegisterTransient]
public class GenericHttpClient : CustomHttpClient
{
    protected override string ClientName => "Generic";

    public GenericHttpClient(IHttpClientFactory httpClientFactory)
        : base(httpClientFactory)
    {
    }
}
