using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class ShipmentParcelSize
    {
        /// <summary>
        /// Parcel width in cm
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Parcel depth in cm
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonPropertyName("depth")]
        public int Depth { get; set; }

        /// <summary>
        /// Parcel height in cm
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
}