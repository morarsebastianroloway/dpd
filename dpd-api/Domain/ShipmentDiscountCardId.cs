using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class ShipmentDiscountCardId
    {
        /// <summary>
        /// Fixed discount card contract id
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonPropertyName("contractId")]
        public long ContractId { get; set; }

        /// <summary>
        /// Fixed discount card id
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonPropertyName("cardId")]
        public long CardId { get; set; }
    }
}