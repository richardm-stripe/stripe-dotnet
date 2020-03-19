namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DisputeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("disputed_transaction")]
        public string DisputedTransaction { get; set; }
    }
}
