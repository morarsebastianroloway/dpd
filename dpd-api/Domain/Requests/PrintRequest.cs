using dpd_api.Domain.Enums;
using dpd_api.Domain.Print;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Intrinsics.Arm;

namespace dpd_api.Domain.Requests
{
    public class PrintRequest : BaseRequest
    {
        /// <summary>
        /// Output format
        /// </summary>
        /// <remarks>Not required, default is pdf</remarks>
        [JsonProperty(PropertyName = "format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FileFormat Format { get; set; }

        /// <summary>
        /// Print paper size
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "paperSize")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaperSize PaperSize { get; set; }


        /// <summary>
        /// Parcels to print
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "parcels")]
        public IEnumerable<ParcelToPrint>? Parcels { get; set; }

        /// <summary>
        /// Printer name to be used for direct printing.
        /// </summary>
        [JsonProperty(PropertyName = "printerName")]
        public string? PrinterName { get; set; }

        /// <summary>
        /// Dpi used for rendering. Makes sense for zpl format, otherwise ignored
        /// </summary>
        /// <remarks>Not required. Default is dpi203</remarks>
        [JsonProperty(PropertyName = "dpi")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Dpi? Dpi { get; set; }

        /// <summary>
        /// Defines whether and how to print additional waybill copy for sender.
        /// </summary>
        /// <remarks>Not required. Default is NONE</remarks>
        [JsonProperty(PropertyName = "additionalWaybillSenderCopy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AdditionalWaybillSenderCopy? AdditionalWaybillSenderCopy { get; set; }
    }
}
