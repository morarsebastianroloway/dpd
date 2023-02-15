using dpd_api.Domain.Shipment;
using Newtonsoft.Json;

namespace dpd_api.Domain.Requests
{
    public class ShipmentRequest : BaseRequest
    {
        [JsonProperty(PropertyName = "sender")]
        public ShipmentSender Sender { get; set; }

        [JsonProperty(PropertyName = "recipient")]
        public ShipmentRecipient Recipient { get; set; }

        [JsonProperty(PropertyName = "service")]
        public ShipmentService Service { get; set; }

        [JsonProperty(PropertyName = "content")]
        public ShipmentContent Content { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public ShipmentPayment Payment { get; set; }
    }
}
