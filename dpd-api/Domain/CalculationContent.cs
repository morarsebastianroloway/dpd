using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class CalculationContent
    {
        /// <summary>
        /// Total shipment parcels count. Ignored, if parcels list is not empty.
        /// </summary>
        /// <remarks>Required when parcels list is empty</remarks>
        [JsonPropertyName("parcelsCount")]
        public int ParcelsCount { get; set; }

        /// <summary>
        /// Total weight declared for the shipment. Ignored, if parcels list is not empty. The total weight is the sum of all parcels declaredWeight in that case.
        /// </summary>
        /// <remarks>Required when parcels list is empty</remarks>
        [JsonPropertyName("totalWeight")]
        public decimal TotalWeight { get; set; }

        /// <summary>
        /// Documents flag of the shipment
        /// </summary>
        [JsonPropertyName("documents")]
        public bool AreDocuments { get; set; }

        /// <summary>
        /// Palletized flag of the shipment.
        /// </summary>
        [JsonPropertyName("palletized")]
        public bool ArePalletized { get; set; }

        /// <summary>
        /// List of parcels
        /// </summary>
        /// <remarks>Required for pallet and postal services.</remarks>
        [JsonPropertyName("parcels")]
        public IEnumerable<ShipmentParcel> Parcels { get; set; }
    }
}