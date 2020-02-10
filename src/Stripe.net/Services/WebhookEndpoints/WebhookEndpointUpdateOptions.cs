namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class WebhookEndpointUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }

        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

<<<<<<< HEAD
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

=======
>>>>>>> Remove all docs from entities, options and services (#1913)
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
