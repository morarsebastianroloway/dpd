using dpd_api.Domain.Shipment;
using Newtonsoft.Json;

namespace dpd_api.Domain.Requests
{
    public class FindCountryRequest : BaseRequest
    {
        /// <summary>
        /// Country search term. Filters the results by country name prefix or part of country name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        /// <summary>
        /// Country iso alpha 2. Filters result by exact match if presents. ISO alpha 2 value uniquely identifies country and other criterias are not needed if this one presents
        /// </summary>
        [JsonProperty(PropertyName = "isoAlpha2")]
        public string? IsoAlpha2 { get; set; }

        /// <summary>
        /// Country iso alpha 3. Filters result by exact match if presents. ISO alpha 3 value uniquely identifies country and other criterias are not needed if this one presents
        /// </summary>
        [JsonProperty(PropertyName = "isoAlpha3")]
        public string? IsoAlpha3 { get; set; }
    }
}
