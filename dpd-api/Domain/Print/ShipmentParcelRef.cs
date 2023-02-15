using Newtonsoft.Json;

namespace dpd_api.Domain.Print
{
    public class ShipmentParcelRef
    {
        /// <summary>
        /// Parcel id
        /// </summary>
        /// <remarks>Not required. If externalCarrierParcelNumber is not provided, it is mandatory.</remarks>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        /// <summary>
        /// External carrier parcel number used to create parcels.
        /// </summary>
        [JsonProperty(PropertyName = "externalCarrierParcelNumber")]
        public string? ExternalCarrierParcelNumber { get; set; }

        /// <summary>
        /// External carrier parcel number used to create parcels.
        /// </summary>
        /// <remarks>Not required. If id or externalCarrierParcelNumber is not provided, it is mandatory.</remarks>
        [JsonProperty(PropertyName = "fullBarcode")]
        public string? FullBarcode { get; set; }
    }
}