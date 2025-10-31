﻿namespace HelpScoutSharp;

public class CreateWebhookRequest
{
    public string url { get; set; }

    public string[] events { get; set; }

    public bool notification { get; set; }

    public string secret { get; set; }

    public string payloadVersion { get; set; }
}
