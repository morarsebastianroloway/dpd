using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class CreatedShipmentParcel
    {
        /// <summary>
        /// Sequence number within the shipment
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "seqNo")]
        public int? SeqNo { get; set; }

        /// <summary>
        /// Generated parcel id
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        /// <summary>
        /// External carrier id in case this parcel is mapped to an external carrier system
        /// </summary>
        [JsonProperty(PropertyName = "externalCarrierId")]
        public int? ExternalCarrierId { get; set; }

        /// <summary>
        /// External carrier parcel number in case this parcel is mapped to an external carrier system
        /// </summary>
        [JsonProperty(PropertyName = "externalCarrierParcelNumber")]
        public string? ExternalCarrierParcelNumber { get; set; }
    }
}