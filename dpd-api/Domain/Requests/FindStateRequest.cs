using Newtonsoft.Json;

namespace dpd_api.Domain.Requests
{
    public class FindStateRequest : BaseRequest
    {
        /// <summary>
        /// Country id
        /// </summary>
        [JsonProperty(PropertyName = "countryId")]
        public int? CountryId { get; set; }

        /// <summary>
        /// Search term for state name. Filters the results by state name prefix or part of state name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
