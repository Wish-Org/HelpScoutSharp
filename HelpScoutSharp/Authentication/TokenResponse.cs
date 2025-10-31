﻿using System;
using System.Text.Json.Serialization;

namespace HelpScoutSharp;

public class TokenResponse
{
    /// <summary>
    /// "bearer"
    /// </summary>
    public string token_type { get; set; }

    public string access_token { get; set; }

    public string refresh_token { get; set; }

    /// <summary>
    /// duration in seconds
    /// </summary>
    [JsonConverter(typeof(NumberTimespanConverter))]
    public TimeSpan expires_in { get; set; }
}
