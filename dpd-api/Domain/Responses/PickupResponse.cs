using dpd_api.Domain.Pickup;
using dpd_api.Domain.Shipment;
using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class PickupResponse : BaseResponse
    {
        /// <summary>
        /// Pickup orders created
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "orders")]
        public IEnumerable<PickupOrder>? orders { get; set; }
    }
}
