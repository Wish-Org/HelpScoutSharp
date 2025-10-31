﻿using System;
using System.Linq;
using System.Net.Http;

namespace HelpScoutSharp;

public class HelpScoutException : Exception
{
    public HttpResponseMessage Response { get; }

    public string ResponseContent { get; }

    /// <summary>
    /// HTTP 401
    /// </summary>
    public bool IsUnauthorized => (int)Response.StatusCode == 401;

    /// <summary>
    /// HTTP 403
    /// </summary>
    public bool IsForbidden => (int)Response.StatusCode == 403;

    /// <summary>
    /// HTTP 429
    /// </summary>
    public bool IsRateLimit => (int)Response.StatusCode == 429;

    public TimeSpan? RateLimitRetryAfter => Response.Headers.Contains("X-RateLimit-Retry-After") ?
                                                TimeSpan.FromSeconds(int.Parse(Response.Headers.GetValues("X-RateLimit-Retry-After").First())) :
                                                (TimeSpan?)null;

    public HelpScoutException(HttpRequestMessage request, string requestContent, HttpResponseMessage response, string responseContent)
        : base($@"Help Scout API call failed with code: {response.StatusCode}
Response
Reason: {response.ReasonPhrase}
Content: {responseContent}
Headers: {response.Headers}

Request: {request.Method} {request.RequestUri}
Content: {requestContent}
Headers: {request.Headers}")
    {
        this.Response = response;
        this.ResponseContent = responseContent;
    }
}
