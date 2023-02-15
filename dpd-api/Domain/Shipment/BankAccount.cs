using Newtonsoft.Json;

namespace dpd_api.Domain.Shipment
{
    public class BankAccount
    {
        /// <summary>
        /// IBAN
        /// </summary>
        [JsonProperty(PropertyName = "iban")]
        public string Iban { get; set; }

        /// <summary>
        /// Bank account holder
        /// </summary>
        [JsonProperty(PropertyName = "accountHolder")]
        public string AccountHolder { get; set; }
    }
}