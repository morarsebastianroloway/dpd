using Newtonsoft.Json;

namespace dpd_api.Domain
{
    public class ShipmentPhoneNumber
    {
        /// <summary>
        /// Phone number
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "number")]
        public string? Number { get; set; }

        /// <summary>
        /// Extension
        /// </summary>
        [JsonProperty(PropertyName = "extension")]
        public string? Extension { get; set; }
    }
}