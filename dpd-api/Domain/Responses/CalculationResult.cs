using System.Text.Json.Serialization;

namespace dpd_api.Domain.Responses
{
    public class CalculationResult
    {
        /// <summary>
        /// Service id
        /// </summary>
        [JsonPropertyName("serviceId")]
        public int ServiceId { get; set; }

        /// <summary>
        /// Additional services included in calculation
        /// </summary>
        [JsonPropertyName("additionalServices")]
        public ShipmentAdditionalServices AdditionalServices { get; set; }

        /// <summary>
        /// Returned, if customer has access to view the amounts of the shipment
        /// </summary>
        [JsonPropertyName("price")]
        public ShipmentPrice price { get; set; }

        /// <summary>
        /// Pickup date
        /// </summary>
        [JsonPropertyName("pickupDate")]
        public DateOnly PickupDate { get; set; }

        /// <summary>
        /// Deadline for delivery. Returned, if available
        /// </summary>
        [JsonPropertyName("deliveryDeadline")]
        public DateTime DeliveryDeadline { get; set; }

        /// <summary>
        /// Response error
        /// </summary>
        [JsonPropertyName("error")]
        public Error Error { get; set; }
    }
}