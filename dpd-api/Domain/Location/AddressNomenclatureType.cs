using Newtonsoft.Json;

namespace dpd_api.Domain.Location
{
    public class AddressNomenclatureType
    {
        /// <summary>
        /// Address nomenclature type name in requested language
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        /// <summary>
        /// Address nomenclature type name in English
        /// </summary>
        [JsonProperty(PropertyName = "nameEn")]
        public string? NameEn { get; set; }
    }
}