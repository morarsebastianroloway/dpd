using dpd_api.Domain.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dpd_api.Domain.Print
{
    public class ParcelToPrintAdditionalBarcode
    {
        /// <summary>
        /// Barcode value
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }

        /// <summary>
        /// It is printed just below the barcode image
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional barcode format.
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BarcodeFormat? Format { get; set; }
    }
}