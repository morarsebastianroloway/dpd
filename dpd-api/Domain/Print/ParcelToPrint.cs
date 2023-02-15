using Newtonsoft.Json;

namespace dpd_api.Domain.Print
{
    public class ParcelToPrint
    {
        /// <summary>
        /// Parcel reference
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "parcel")]
        public ShipmentParcelRef? Parcel { get; set; }

        /// <summary>
        /// Additional barcode to be added in the label
        /// </summary>
        [JsonProperty(PropertyName = "additionalBarcode")]
        public ParcelToPrintAdditionalBarcode? AdditionalBarcode { get; set; }
    }
}