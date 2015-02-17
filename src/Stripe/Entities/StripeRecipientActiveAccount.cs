﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRecipientActiveAccount : StripeObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("default_for_currency")]
        public bool DefaultForCurrency { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        #region Obsolete
        [JsonProperty("disabled")]
        [Obsolete("Doesn't show in the latest documentation. May need to check with Stripe.")]
        public bool? Disabled { get; set; }

        [JsonProperty("metadata")]
        [Obsolete("Doesn't show in the latest documentation. May need to check with Stripe.")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("validated")]
        [Obsolete("Doesn't show in the latest documentation. May need to check with Stripe.")]
        public bool? Validated { get; set; }
        #endregion
    }
}