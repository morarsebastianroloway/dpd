using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class ShipmentParcel
    {
        /// <summary>
        /// Parcel identifier - barcode (if it is known).
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Parcel sequence number in the shipment.
        /// </summary>
        /// <remarks>Required in createShipment method. Ignored in addParcel (auto-generated in this case)</remarks>
        [JsonPropertyName("seqNo")]
        public int SeqNo { get; set; }

        /// <summary>
        /// Package number associated with parcel
        /// </summary>
        [JsonPropertyName("packageUniqueNumber")]
        public long packageUniqueNumber { get; set; }

        /// <summary>
        /// Parcel size (width, height, depth) in cm.
        /// </summary>
        /// <remarks>Required for pallet and postal services</remarks>
        [JsonPropertyName("size")]
        public ShipmentParcelSize Size { get; set; }

        /// <summary>
        /// Parcel weight in kg
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }

        /// <summary>
        /// External carrier parcel id
        /// </summary>
        [JsonPropertyName("externalCarrierParcelNumber")]
        public string ExternalCarrierParcelNumber { get; set; }

        /// <summary>
        /// Reference number or text.
        /// </summary>
        [JsonPropertyName("ref1")]
        public string Ref1 { get; set; }

        /// <summary>
        /// Reference number or text.
        /// </summary>
        [JsonPropertyName("ref2")]
        public string Ref2 { get; set; }
    }
}