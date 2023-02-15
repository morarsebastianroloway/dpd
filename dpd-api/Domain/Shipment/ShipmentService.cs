using dpd_api.Domain.Base;
using Newtonsoft.Json;

namespace dpd_api.Domain.Shipment
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