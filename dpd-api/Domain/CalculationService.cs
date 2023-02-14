using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class CalculationService
    {
        /// <summary>
        /// The date for shipment pickup.
        /// </summary>
        /// <remarks>Not required (default value is today)</remarks>
        [JsonPropertyName("pickupDate")]
        public DateTime? PickupDate { get; set; }

        /// <summary>
        /// To find first available date for pickup starting from pickupDate according to pickup schedule for services
        /// </summary>
        /// <remarks>Not required (default value is false)</remarks>
        [JsonPropertyName("autoAdjustPickupDate")]
        public bool AutoAdjustPickupDate { get; set; }

        /// <summary>
        /// Services for which calculation is requested
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonPropertyName("serviceIds")]
        public IEnumerable<int> ServiceIds { get; set; }

        /// <summary>
        /// Defines sub-services (like COD, Declared value, etc.) associated with the shipment.
        /// </summary>
        [JsonPropertyName("additionalServices")]
        public ShipmentAdditionalServices AdditionalServices { get; set; }

        /// <summary>
        /// Services for which calculation is requested
        /// </summary>
        /// <remarks>Not required (default value is 0)</remarks>
        [JsonPropertyName("deferredDays")]
        public int DeferredDays { get; set; }

        /// <summary>
        /// This parameter may adjust delivery date to the first business day, if the standard calculated delivery day is a half-working day. If not specified, system will determine this flag based on configured delivery customer working schedule
        /// </summary>
        [JsonPropertyName("saturdayDelivery")]
        public bool IsSaturdayDelivery { get; set; }
    }
}