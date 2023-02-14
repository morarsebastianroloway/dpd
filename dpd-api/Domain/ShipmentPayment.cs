using dpd_api.Domain.Enums;
using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class ShipmentPayment
    {
        /// <summary>
        /// Courier service payer.
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonPropertyName("courierServicePayer")]
        public Payer CourierServicePayer { get; set; }

        /// <summary>
        /// Declared value (extended liability) payer. If not provided, the courier service payer is assumed.
        /// </summary>
        [JsonPropertyName("declaredValuePayer")]
        public Payer DeclaredValuePayer { get; set; }

        /// <summary>
        /// Package payer. If not provided, the courier service payer is assumed.
        /// </summary>
        [JsonPropertyName("packagePayer")]
        public Payer PackagePayer { get; set; }

        /// <summary>
        /// Defines shipment third party - used as a payer of any of shipment payable components.
        /// </summary>
        [JsonPropertyName("thirdPartyClientId")]
        public long ThirdPartyClientId { get; set; }

        /// <summary>
        /// Discount card to be used for discount calculation.
        /// </summary>
        [JsonPropertyName("discountCardId")]
        public ShipmentDiscountCardId DiscountCardId { get; set; }

        /// <summary>
        /// Sender COD payout account information.
        /// </summary>
        [JsonPropertyName("senderBankAccount")]
        public BankAccount SenderBankAccount { get; set; }


        /// <summary>
        /// Flag to apply administrative fee on price calculations
        /// </summary>
        [JsonPropertyName("administrativeFee")]
        public bool ApplyAdministrativeFee { get; set; }

    }
}
