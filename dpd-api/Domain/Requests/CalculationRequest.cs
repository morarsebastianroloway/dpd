using System.Text.Json.Serialization;

namespace dpd_api.Domain.Requests
{
    public class CalculationRequest : BaseRequest
    {
        [JsonPropertyName("sender")]
        public CalculationSender Sender { get; set; }

        [JsonPropertyName("recipient")]
        public CalculationRecipient Recipient { get; set; }

        [JsonPropertyName("service")]
        public CalculationService Service { get; set; }

        [JsonPropertyName("content")]
        public CalculationContent Content { get; set; }

        [JsonPropertyName("payment")]
        public ShipmentPayment Payment { get; set; }
    }
}
