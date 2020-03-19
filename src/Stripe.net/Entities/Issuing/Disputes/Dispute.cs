namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Dispute : StripeEntity<Dispute>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Disputed Transaction
        [JsonIgnore]
        public string DisputedTransactionId
        {
            get => this.InternalDisputedTransaction?.Id;
            set => this.InternalDisputedTransaction = SetExpandableFieldId(value, this.InternalDisputedTransaction);
        }

        [JsonIgnore]
        public Transaction DisputedTransaction
        {
            get => this.InternalDisputedTransaction?.ExpandedObject;
            set => this.InternalDisputedTransaction = SetExpandableFieldObject(value, this.InternalDisputedTransaction);
        }

        [JsonProperty("disputed_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transaction>))]
        internal ExpandableField<Transaction> InternalDisputedTransaction { get; set; }
        #endregion

        [JsonProperty("evidence")]
        public Evidence Evidence { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
