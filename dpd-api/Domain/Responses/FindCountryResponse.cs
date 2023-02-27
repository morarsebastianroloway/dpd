using dpd_api.Domain.Location;
using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class FindCountryResponse : BaseResponse
    {
        /// <summary>
        /// Array of countries
        /// </summary>
        [JsonProperty(PropertyName = "countries")]
        public List<Country>? Countries { get; set; }
    }
}
