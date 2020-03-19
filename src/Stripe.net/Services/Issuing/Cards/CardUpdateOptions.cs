namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("authorization_controls")]
        public AuthorizationControlsOptions AuthorizationControls { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("spending_controls")]
        public CardSpendingControlsOptions SpendingControls { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
