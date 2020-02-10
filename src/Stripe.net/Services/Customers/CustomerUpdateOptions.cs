namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("balance")]
        public long? Balance { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("invoice_settings")]
        public CustomerInvoiceSettingsOptions InvoiceSettings { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

<<<<<<< HEAD
        [JsonProperty("next_invoice_sequence")]
        public long? NextInvoiceSequence { get; set; }

=======
>>>>>>> Remove all docs from entities, options and services (#1913)
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
