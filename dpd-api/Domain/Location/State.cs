using Newtonsoft.Json;

namespace dpd_api.Domain.Location
{
    public class State
    {
        /// <summary>
        /// State id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        /// <summary>
        /// State name in requested language
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        /// <summary>
        /// State name in English
        /// </summary>
        [JsonProperty(PropertyName = "nameEn")]
        public string? NameEn { get; set; }

        /// <summary>
        /// State name in English
        /// </summary>
        [JsonProperty(PropertyName = "stateAlpha")]
        public string? StateAlpha { get; set; }

        /// <summary>
        /// State country id
        /// </summary>
        [JsonProperty(PropertyName = "countryId")]
        public int? CountryId { get; set; }
    }
}