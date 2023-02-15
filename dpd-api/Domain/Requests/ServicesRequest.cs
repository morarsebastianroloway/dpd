using dpd_api.Domain.Shipment;
using Newtonsoft.Json;

namespace dpd_api.Domain.Requests
{
    public class ServicesRequest : BaseRequest
    {
        /// <summary>
        /// Date. Current date is assumed if not provided
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateOnly? Date { get; set; }
    }
}
