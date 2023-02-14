using Newtonsoft.Json;

namespace dpd_api.Domain.Requests
{
    public class CalculationRequest : BaseRequest
    {
        [JsonProperty(PropertyName = "sender")]
        public CalculationSender Sender { get; set; }

        [JsonProperty(PropertyName = "recipient")]
        public CalculationRecipient Recipient { get; set; }

        [JsonProperty(PropertyName = "service")]
        public CalculationService Service { get; set; }

        [JsonProperty(PropertyName = "content")]
        public CalculationContent Content { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public ShipmentPayment Payment { get; set; }
    }
}
