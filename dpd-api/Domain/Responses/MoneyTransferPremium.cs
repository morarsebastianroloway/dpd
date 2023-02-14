using dpd_api.Domain.Enums;
using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
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
        public Payer payer { get; set; }
    }
}