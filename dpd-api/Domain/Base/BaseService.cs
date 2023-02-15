using Newtonsoft.Json;

namespace dpd_api.Domain.Base
{
    public class BaseService
    {
        /// <summary>
        /// The date for shipment pickup.
        /// </summary>
        /// <remarks>Not required (default value is today)</remarks>
        [JsonProperty(PropertyName = "pickupDate")]
        public DateTime? PickupDate { get; set; }

        /// <summary>
        /// To find first available date for pickup starting from pickupDate according to pickup schedule for services
        /// </summary>
        /// <remarks>Not required (default value is false)</remarks>
        [JsonProperty(PropertyName = "autoAdjustPickupDate")]
        public bool AutoAdjustPickupDate { get; set; }

        /// <summary>
        /// Defines sub-services (like COD, Declared value, etc.) associated with the shipment.
        /// </summary>
        [JsonProperty(PropertyName = "additionalServices")]
        public ShipmentAdditionalServices AdditionalServices { get; set; }

        /// <summary>
        /// Services for which calculation is requested
        /// </summary>
        /// <remarks>Not required (default value is 0)</remarks>
        [JsonProperty(PropertyName = "deferredDays")]
        public int DeferredDays { get; set; }

        /// <summary>
        /// This parameter may adjust delivery date to the first business day, if the standard calculated delivery day is a half-working day. If not specified, system will determine this flag based on configured delivery customer working schedule
        /// </summary>
        [JsonProperty(PropertyName = "saturdayDelivery")]
        public bool IsSaturdayDelivery { get; set; }
    }
}