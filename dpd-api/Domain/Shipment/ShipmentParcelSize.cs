using Newtonsoft.Json;

namespace dpd_api.Domain.Shipment
{
    public class ShipmentParcelSize
    {
        /// <summary>
        /// Parcel width in cm
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Parcel depth in cm
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "depth")]
        public int Depth { get; set; }

        /// <summary>
        /// Parcel height in cm
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
    }
}