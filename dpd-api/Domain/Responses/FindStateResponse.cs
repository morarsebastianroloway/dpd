using dpd_api.Domain.Location;
using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class FindStateResponse : BaseResponse
    {
        /// <summary>
        /// Array of sites
        /// </summary>
        [JsonProperty(PropertyName = "states")]
        public IEnumerable<State>? States { get; set; }
    }
}
