using dpd_api.Domain.Base;
using dpd_api.Domain.Shipment;
using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class CalculationResult
    {
        /// <summary>
        /// Service id
        /// </summary>
        [JsonProperty(PropertyName = "serviceId")]
        public int ServiceId { get; set; }

        /// <summary>
        /// Additional services included in calculation
        /// </summary>
        [JsonProperty(PropertyName = "additionalServices")]
        public ShipmentAdditionalServices AdditionalServices { get; set; }

        /// <summary>
        /// Returned, if customer has access to view the amounts of the shipment
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public ShipmentPrice price { get; set; }

        /// <summary>
        /// Pickup date
        /// </summary>
        [JsonProperty(PropertyName = "pickupDate")]
        public DateOnly PickupDate { get; set; }

        /// <summary>
        /// Deadline for delivery. Returned, if available
        /// </summary>
        [JsonProperty(PropertyName = "deliveryDeadline")]
        public DateTime DeliveryDeadline { get; set; }

        /// <summary>
        /// Response error
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }
    }
}