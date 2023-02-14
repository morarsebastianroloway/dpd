using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class ReturnAmounts
    {
        /// <summary>
        /// Shipment money transfer premium
        /// </summary>
        [JsonProperty(PropertyName = "moneyTransfer")]
        public MoneyTransferPremium MoneyTransfer { get; set; }
    }
}