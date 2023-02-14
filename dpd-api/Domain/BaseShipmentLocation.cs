using Newtonsoft.Json;

namespace dpd_api.Domain
{
    public class BaseShipmentLocation : BaseLocation
    {
        /// <summary>
        /// Recipient phone number (for example: +40799123456, 0040799123456, +359999123456 - international format numbers or 0799123456, 0999123456 - local numers).
        /// </summary>
        /// <remarks>Required, if shipment is with the same day delivery or delivery date is a half-working day or delivery country is abroad</remarks>
        [JsonProperty(PropertyName = "phone1")]
        public ShipmentPhoneNumber? Phone1 { get; set; }

        /// <summary>
        /// Recipient phone number 2
        /// </summary>
        [JsonProperty(PropertyName = "phone2")]
        public ShipmentPhoneNumber? Phone2 { get; set; }

        /// <summary>
        /// Recipient phone number 3
        /// </summary>
        [JsonProperty(PropertyName = "phone3")]
        public ShipmentPhoneNumber? Phone3 { get; set; }

        /// <summary>
        /// Recipient customer name
        /// </summary>
        /// <remarks>If clientId is provided, it is forbidden. Otherwise, it is mandatory.</remarks>
        [JsonProperty(PropertyName = "clientName")]
        public string? ClientName { get; set; }

        /// <summary>
        /// Recipient contact name
        /// </summary>
        /// <remarks>Not required. Forbidden for private persons. Required for companies</remarks>
        [JsonProperty(PropertyName = "contactName")]
        public string? ContactName { get; set; }

        /// <summary>
        /// Recipient email
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }

        /// <summary>
        /// Recipient or sender address
        /// </summary>
        /// <remarks>If clientId is provided or pickup office is provided, it is forbidden. Otherwise, it is mandatory</remarks>
        [JsonProperty(PropertyName = "address")]
        public ShipmentAddress Address { get; set; }

        /// <summary>
        /// Pickup office id
        /// </summary>
        /// <remarks>Required, if the recipient is an internal DPD customer. If address is provided, it is forbidden</remarks>
        [JsonProperty(PropertyName = "pickupOfficeId")]
        public int? PickupOfficeId { get; set; }

        /// <summary>
        /// DPD pickup office PUDO id
        /// </summary>
        /// <remarks>Not required. Must be empty if pickupOfficeId is provided</remarks>
        [JsonProperty(PropertyName = "pickupGeoPUDOId")]
        public int? PickupGeoPUDOId { get; set; }
    }
}
