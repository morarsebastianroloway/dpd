using dpd_api.Domain.Base;
using Newtonsoft.Json;

namespace dpd_api.Domain.Shipment
{
    public class ShipmentContent : BaseContent
    {
        /// <summary>
        /// Shipment content’s description
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "contents")]
        public string? Contents { get; set; }

        /// <summary>
        /// Shipment package
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "package")]
        public string? Package { get; set; }

        /// <summary>
        /// If this flag is true, the shipment is created in pending parcels state.
        /// Shipments in pending parcels state allows adding parcels with addParcel method.
        /// Pending parcels state is closed with finalizePendingShipment method.
        /// </summary>
        [JsonProperty(PropertyName = "pendingParcels")]
        public bool ArePendingParcels { get; set; }

        /// <summary>
        /// Flag shipment contains excise goods
        /// </summary>
        [JsonProperty(PropertyName = "exciseGoods")]
        public bool ContainsExciseGoods { get; set; }
    }
}