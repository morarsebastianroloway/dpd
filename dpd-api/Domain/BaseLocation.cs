using Newtonsoft.Json;

namespace dpd_api.Domain
{
    public class BaseLocation
    {
        /// <summary>
        /// Client id to refer serving client
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public long ClientId { get; set; }

        /// <summary>
        /// Private person flag.
        /// </summary>
        /// <remarks>If clientId is provided, it is forbidden. Otherwise, it is mandatory.</remarks>
        [JsonProperty(PropertyName = "privatePerson")]
        public bool IsPrivatePerson { get; set; }
    }
}
