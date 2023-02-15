using dpd_api.Domain.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dpd_api.Domain
{
    public class MoneyTransferPremium
    {
        /// <summary>
        /// Amount due in client currency
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Amount due in local currency
        /// </summary>
        [JsonProperty(PropertyName = "amountLocal")]
        public decimal AmountLocal { get; set; }

        /// <summary>
        /// The payer of money transfer premium
        /// </summary>
        [JsonProperty(PropertyName = "payer")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Payer payer { get; set; }
    }
}