using Newtonsoft.Json;

namespace dpd_api.Domain.Shipment
{
    public class ShipmentDiscountCardId
    {
        /// <summary>
        /// Fixed discount card contract id
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "contractId")]
        public long ContractId { get; set; }

        /// <summary>
        /// Fixed discount card id
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "cardId")]
        public long CardId { get; set; }
    }
}