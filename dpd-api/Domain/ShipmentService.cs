using Newtonsoft.Json;

namespace dpd_api.Domain
{
    public class ShipmentService : BaseService
    {
        /// <summary>
        /// Service to be used for the shipment
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "serviceId")]
        public int? ServiceId { get; set; }
    }
}