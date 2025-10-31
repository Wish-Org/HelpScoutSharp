﻿namespace HelpScoutSharp;

public class WebhookPage : IPage<Webhook>
{
    public class Embedded
    {
        public Webhook[] webhooks { get; set; }
    }

    public Embedded _embedded { get; set; }

    public Page page { get; set; }

    public Webhook[] entities => _embedded.webhooks;
}
