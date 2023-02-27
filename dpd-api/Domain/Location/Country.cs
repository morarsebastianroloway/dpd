using Newtonsoft.Json;

namespace dpd_api.Domain.Location
{
    public class Country
    {
        /// <summary>
        /// Country ISO
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Country name in requested language
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        /// <summary>
        /// Country name in English
        /// </summary>
        [JsonProperty(PropertyName = "nameEn")]
        public string? NameEn { get; set; }

        /// <summary>
        /// Country ISO alpha 2 code
        /// </summary>
        [JsonProperty(PropertyName = "isoAlpha2")]
        public string? IsoAlpha2 { get; set; }

        /// <summary>
        /// Country ISO alpha 3 code
        /// </summary>
        [JsonProperty(PropertyName = "isoAlpha3")]
        public string? IsoAlpha3 { get; set; }

        /// <summary>
        /// Allowed postcode format patterns.
        /// If empty string presents in allowed patterns this means - postcode format is not restricted and post code validation is not applied on addresses in this country.
        /// For non-empty patterns, the following characters are placeholders for:
        /// N - digit
        /// A - letter
        /// ? - digit or letter
        /// B - letter
        /// O - digit
        /// </summary>
        [JsonProperty(PropertyName = "postCodeFormats")]
        public List<string>? PostCodeFormats { get; set; }

        /// <summary>
        /// Require state flag
        /// </summary>
        [JsonProperty(PropertyName = "requireState")]
        public string? RequireState { get; set; }

        /// <summary>
        /// Address type for this country (1 or 2)
        /// </summary>
        [JsonProperty(PropertyName = "addressType")]
        public int? AddressType { get; set; }

        /// <summary>
        /// Currency code used for COD in this country
        /// </summary>
        [JsonProperty(PropertyName = "currencyCode")]
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// Default office id
        /// </summary>
        [JsonProperty(PropertyName = "defaultOfficeId")]
        public int? DefaultOfficeId { get; set; }

        /// <summary>
        /// Valid street types for country (applicable if addressType is equal to 1)
        /// </summary>
        [JsonProperty(PropertyName = "streetTypes")]
        public IEnumerable<AddressNomenclatureType>? StreetTypes { get; set; }

        /// <summary>
        /// Valid complex types for country (applicable if addressType is equal to 1)
        /// </summary>
        [JsonProperty(PropertyName = "complexTypes")]
        public IEnumerable<AddressNomenclatureType>? ComplexTypes { get; set; }

        /// <summary>
        /// Specifies site nomenclature (sites) for this country. Values can be:
        /// 0 - No site nomenclature for this country.
        /// 1 - Full site nomenclature for this country.
        /// 2 - Partial site nomenclature for this country.
        /// </summary>
        [JsonProperty(PropertyName = "siteNomen")]
        public int? SiteNomen { get; set; }
    }
}