using Newtonsoft.Json;

namespace dpd_api.Domain.Pickup
{
    public class PickupOrder
    {
        /// <summary>
        /// Order id
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// The list of all shipments associated with the order
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "shipmentIds")]
        public IEnumerable<string>? ShipmentIds { get; set; }

        /// <summary>
        /// Estimated period start for courier pickup visit
        /// </summary>
        [JsonProperty(PropertyName = "pickupPeriodFrom")]
        public DateTime? PickupPeriodFrom { get; set; }

        /// <summary>
        /// Estimated period end for courier pickup visit
        /// </summary>
        [JsonProperty(PropertyName = "pickupPeriodTo")]
        public DateTime? PickupPeriodTo { get; set; }
    }
}