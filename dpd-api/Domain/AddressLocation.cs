using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class AddressLocation
    {
        /// <summary>
        /// Country ISO code. If not provided, local country is assumed. Used for all address types.
        /// </summary>
        [JsonPropertyName("countryId")]
        public int CountryId { get; set; }

        /// <summary>
        /// Country state. Used for addresses of type 2 (foreign address).
        /// </summary>
        /// <remarks>Required, if country supports states</remarks>
        [JsonPropertyName("stateId")]
        public string stateId { get; set; }

        /// <summary>
        /// Site id. Used for all address types.
        /// </summary>
        /// <remarks>Required, if country has full site nomenclature and pair (siteType, siteName) is not provided</remarks>
        [JsonPropertyName("siteId")]
        public string SiteId { get; set; }

        /// <summary>
        /// Site type can be used in conjunction with countryId and siteName to find unique site. Used for addresses of type 1 (local address).
        /// </summary>
        /// <remarks>Forbidden, if siteId is provided. Otherwise, is not mandatory</remarks>
        [JsonPropertyName("siteType")]
        public string SiteType { get; set; }

        /// <summary>
        /// Site type can be used in conjunction with countryId and siteName to find unique site. Used for all address types.
        /// </summary>
        /// <remarks>Forbidden, if siteId is provided. Otherwise, is not mandatory</remarks>
        [JsonPropertyName("siteName")]
        public string SiteName { get; set; }

        /// <summary>
        /// Can be used in conjunction with countryId to find unique site. Used for all address types.
        /// </summary>
        /// <remarks>Required if country requires postcode for addresses</remarks>
        [JsonPropertyName("postCode")]
        public string PostCode { get; set; }
    }
}