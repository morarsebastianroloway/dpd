using Newtonsoft.Json;

namespace dpd_api.Domain.Shipment
{
    public class ShipmentRecipient : BaseShipmentLocation
    {
        /// <summary>
        /// Recipient  customer object
        /// </summary>
        /// <remarks>If clientId is provided, it is forbidden. Otherwise, it is not mandatory</remarks>
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
    }
}