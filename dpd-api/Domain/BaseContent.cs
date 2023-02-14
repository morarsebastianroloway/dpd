using Newtonsoft.Json;

namespace dpd_api.Domain
{
    public class BaseContent
    {
        /// <summary>
        /// Total shipment parcels count. Ignored, if parcels list is not empty.
        /// </summary>
        /// <remarks>Required when parcels list is empty</remarks>
        [JsonProperty(PropertyName = "parcelsCount")]
        public int? ParcelsCount { get; set; }

        /// <summary>
        /// Total weight declared for the shipment. Ignored, if parcels list is not empty. The total weight is the sum of all parcels declaredWeight in that case.
        /// </summary>
        /// <remarks>Required when parcels list is empty</remarks>
        [JsonProperty(PropertyName = "totalWeight")]
        public decimal? TotalWeight { get; set; }

        /// <summary>
        /// Documents flag of the shipment
        /// </summary>
        [JsonProperty(PropertyName = "documents")]
        public bool? AreDocuments { get; set; }

        /// <summary>
        /// Palletized flag of the shipment.
        /// </summary>
        [JsonProperty(PropertyName = "palletized")]
        public bool? ArePalletized { get; set; }

        /// <summary>
        /// List of parcels
        /// </summary>
        /// <remarks>Required for pallet and postal services.</remarks>
        [JsonProperty(PropertyName = "parcels")]
        public IEnumerable<ShipmentParcel>? Parcels { get; set; }
    }
}