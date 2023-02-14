using Newtonsoft.Json;

namespace dpd_api.Domain
{
    public class ShipmentAddress : AddressLocation
    {
        /// <summary>
        /// Street identifier. If not provided, but street type and street name are provided - the system will try to find unique match by them in site. Used for addresses of type 1 (local address).
        /// </summary>
        [JsonProperty(PropertyName = "streetId")]
        public long StreetId { get; set; }

        /// <summary>
        /// Street  type. Used for addresses of type 1 (local address)
        /// </summary>
        /// <remarks>Not required. Forbidden, if streetId is provided.</remarks>
        [JsonProperty(PropertyName = "streetType")]
        public string? StreetType { get; set; }

        /// <summary>
        /// Street Name. Used for addresses of type 1 (local address)
        /// </summary>
        /// <remarks>Not required. Forbidden, if streetId is provided.</remarks>
        [JsonProperty(PropertyName = "streetName")]
        public string? StreetName { get; set; }

        /// <summary>
        /// Street Number. Used for addresses of type 1 (local address)
        /// </summary>
        [JsonProperty(PropertyName = "streetNo")]
        public string? StreetNo { get; set; }

        /// <summary>
        /// Complex identifier. If not provided, but complex type and complex name are provided - the system will try to find unique match by them in site. Used for addresses of type 1 (local address)
        /// </summary>
        [JsonProperty(PropertyName = "complexId")]
        public long ComplexId { get; set; }

        /// <summary>
        /// Complex type. Used for addresses of type 1 (local address)
        /// </summary>
        /// <remarks>Not required. Forbidden, if complexId is provided.</remarks>
        [JsonProperty(PropertyName = "complexType")]
        public string? ComplexType { get; set; }

        /// <summary>
        /// Complex name. Used for addresses of type 1 (local address)
        /// </summary>
        /// <remarks>Not required. Forbidden, if complexId is provided.</remarks>
        [JsonProperty(PropertyName = "complexName")]
        public string? ComplexName { get; set; }

        /// <summary>
        /// Block No. Used for addresses of type 1 (local address)
        /// </summary>
        [JsonProperty(PropertyName = "blockNo")]
        public string? BlockNo { get; set; }

        /// <summary>
        /// Entrance. Used for addresses of type 1 (local address)
        /// </summary>
        [JsonProperty(PropertyName = "entranceNo")]
        public string? EntranceNo { get; set; }

        /// <summary>
        /// Floor. Used for addresses of type 1 (local address)
        /// </summary>
        [JsonProperty(PropertyName = "floorNo")]
        public string? FloorNo { get; set; }

        /// <summary>
        /// Apartment. Used for addresses of type 1 (local address)
        /// </summary>
        [JsonProperty(PropertyName = "apartmentNo")]
        public string? ApartmentNo { get; set; }

        /// <summary>
        /// Point of interest identifier. Used for addresses of type 1 (local address)
        /// </summary>
        [JsonProperty(PropertyName = "poiId")]
        public long PoiId { get; set; }

        /// <summary>
        /// Address note. Used for addresses of type 1 (local address)
        /// </summary>
        [JsonProperty(PropertyName = "addressNote")]
        public string? AddressNote { get; set; }

        /// <summary>
        /// Address line 1. Used for addresses of type 2 (foreign address)
        /// </summary>
        /// <remarks>Required for address type 2</remarks>
        [JsonProperty(PropertyName = "addressLine1")]
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2. Used for addresses of type 2 (foreign address)
        /// </summary>
        [JsonProperty(PropertyName = "addressLine2")]
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// GIS coordinates - X. Used for all address types
        /// </summary>
        [JsonProperty(PropertyName = "x")]
        public decimal X { get; set; }

        /// <summary>
        /// GIS coordinates - Y. Used for all address types
        /// </summary>
        [JsonProperty(PropertyName = "y")]
        public decimal Y { get; set; }
    }
}