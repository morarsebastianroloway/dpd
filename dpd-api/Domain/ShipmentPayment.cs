using dpd_api.Domain.Enums;
using Newtonsoft.Json;

namespace dpd_api.Domain
{
    public class ShipmentPayment
    {
        /// <summary>
        /// Courier service payer.
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "courierServicePayer")]
        public Payer CourierServicePayer { get; set; }

        /// <summary>
        /// Declared value (extended liability) payer. If not provided, the courier service payer is assumed.
        /// </summary>
        [JsonProperty(PropertyName = "declaredValuePayer")]
        public Payer DeclaredValuePayer { get; set; }

        /// <summary>
        /// Package payer. If not provided, the courier service payer is assumed.
        /// </summary>
        [JsonProperty(PropertyName = "packagePayer")]
        public Payer PackagePayer { get; set; }

        /// <summary>
        /// Defines shipment third party - used as a payer of any of shipment payable components.
        /// </summary>
        [JsonProperty(PropertyName = "thirdPartyClientId")]
        public long ThirdPartyClientId { get; set; }

        /// <summary>
        /// Discount card to be used for discount calculation.
        /// </summary>
        [JsonProperty(PropertyName = "discountCardId")]
        public ShipmentDiscountCardId DiscountCardId { get; set; }

        /// <summary>
        /// Sender COD payout account information.
        /// </summary>
        [JsonProperty(PropertyName = "senderBankAccount")]
        public BankAccount SenderBankAccount { get; set; }


        /// <summary>
        /// Flag to apply administrative fee on price calculations
        /// </summary>
        [JsonProperty(PropertyName = "administrativeFee")]
        public bool ApplyAdministrativeFee { get; set; }

    }
}
