using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class BankAccount
    {
        /// <summary>
        /// IBAN
        /// </summary>
        [JsonPropertyName("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// Bank account holder
        /// </summary>
        [JsonPropertyName("accountHolder")]
        public string AccountHolder { get; set; }
    }
}