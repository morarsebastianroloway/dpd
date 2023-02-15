using dpd_api.Domain.Shipment;
using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class CreateShipmentResponse : BaseResponse
    {
        /// <summary>
        /// Generated shipment id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? id { get; set; }

        /// <summary>
        /// Generated parcels
        /// </summary>
        [JsonProperty(PropertyName = "parcels")]
        public IEnumerable<CreatedShipmentParcel>? Parcels { get; set; }

        /// <summary>
        /// Returned, if customer has access to view the amounts of the shipment
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public ShipmentPrice? Price { get; set; }

        /// <summary>
        /// Shipment pickup date
        /// </summary>
        [JsonProperty(PropertyName = "pickupDate")]
        public DateOnly? PickupDate { get; set; }

        /// <summary>
        /// Deadline for delivery. Returned, if available
        /// </summary>
        [JsonProperty(PropertyName = "deliveryDeadline")]
        public DateTime? DeliveryDeadline { get; set; }
    }
}
