using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class ShipmentPrice
    {
        /// <summary>
        /// Total amount (before VAT) in customer’s currency
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// VAT amount in customer’s currency
        /// </summary>
        [JsonProperty(PropertyName = "vat")]
        public decimal Vat { get; set; }

        /// <summary>
        /// Total amount (amount + vat) in customer’s currency
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public decimal Total { get; set; }

        /// <summary>
        /// Customer currency code
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Total amount before VAT in local system currency
        /// </summary>
        [JsonProperty(PropertyName = "amountLocal")]
        public decimal AmountLocal { get; set; }

        /// <summary>
        /// VAT in local system currency
        /// </summary>
        [JsonProperty(PropertyName = "vatLocal")]
        public decimal VatLocal { get; set; }

        /// <summary>
        /// Total amount in local system currency (amountLocal + vatLocal)
        /// </summary>
        [JsonProperty(PropertyName = "totalLocal")]
        public decimal TotalLocal { get; set; }

        /// <summary>
        /// Local system currency code
        /// </summary>
        [JsonProperty(PropertyName = "currencyLocal")]
        public string CurrencyLocal { get; set; }

        /// <summary>
        /// Currency exchange rate unit for customer currency (1 unit of local system currency is equal to exchangeRateUnit / exchangeRate)
        /// </summary>
        [JsonProperty(PropertyName = "currencyExchangeRateUnit")]
        public int CurrencyExchangeRateUnit { get; set; }

        /// <summary>
        /// Currency exchange rate used for customer currency conversion
        /// </summary>
        [JsonProperty(PropertyName = "currencyExchangeRate")]
        public decimal CurrencyExchangeRate { get; set; }

        /// <summary>
        /// Shipment returns amounts due
        /// </summary>
        [JsonProperty(PropertyName = "returnAmounts")]
        public ReturnAmounts returnAmounts { get; set; }
    }
}