using dpd_api.Domain.Enums;
using dpd_api.Domain.Shipment;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dpd_api.Domain.Requests
{
    public class PickupRequest : BaseRequest
    {
        /// <summary>
        /// Pickup datetime. If not provided, it is assumed now. Seconds and milliseconds are ignored
        /// </summary>
        [JsonProperty(PropertyName = "pickupDateTime")]
        public DateTime? PickupDateTime { get; set; }

        /// <summary>
        /// To find first available date for pickup starting from pickupDate according to pickup schedule for services
        /// </summary>
        /// <remarks>Not required. Default value is false</remarks>
        [JsonProperty(PropertyName = "autoAdjustPickupDate")]
        public bool? AutoAdjustPickupDate { get; set; }

        /// <summary>
        /// Scope of shipments to order
        /// </summary>
        /// <remarks>Not required. Default is EXPLICIT_SHIPMENT_ID_LIST</remarks>
        [JsonProperty(PropertyName = "pickupScope")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PickupScope? PickupScope { get; set; }

        /// <summary>
        /// List of ExplicitShipmentId
        /// </summary>
        /// <remarks>Not required. Required when pickup scope is EXPLICIT_SHIPMENT_ID_LIST</remarks>
        [JsonProperty(PropertyName = "explicitShipmentIdList")]
        public IEnumerable<string>? ExplicitShipmentIdList { get; set; }

        /// <summary>
        /// The last possible time when the address could be visited on the pickup date
        /// </summary>
        /// <remarks>Required. Example 9:30, or 11:35</remarks>
        [JsonProperty(PropertyName = "visitEndTime")]
        public string? VisitEndTime { get; set; }

        /// <summary>
        /// Contact name
        /// </summary>
        [JsonProperty(PropertyName = "contactName")]
        public string? ContactName { get; set; }

        /// <summary>
        /// Customer’s phone number
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string? PhoneNumber { get; set; }
    }
}
