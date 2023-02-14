using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class BaseCalculationLocation
    {
        /// <summary>
        /// Client id to refer serving client
        /// </summary>
        [JsonPropertyName("clientId")]
        public long ClientId { get; set; }

        /// <summary>
        /// Private person flag.
        /// </summary>
        /// <remarks>If clientId is provided, it is forbidden. Otherwise, it is mandatory.</remarks>
        [JsonPropertyName("privatePerson")]
        public bool IsPrivatePerson { get; set; }

        /// <summary>
        /// Address location, implies pickup at client address
        /// </summary>
        /// <remarks>Required if office id and clientId are missing. Otherwise it is forbidden</remarks>
        [JsonPropertyName("addressLocation")]
        public AddressLocation AddressLocation { get; set; }

        /// <summary>
        /// Drop-off office id
        /// </summary>
        /// <remarks>Required if address location and clientId are missing. If address location presents it is forbidden</remarks>
        [JsonPropertyName("dropoffOfficeId")]
        public int DropoffOfficeId { get; set; }

        /// <summary>
        /// DPD drop off office PUDO id
        /// </summary>
        /// <remarks>Not required. Must be empty if dropoffOfficeId is provided</remarks>
        [JsonPropertyName("dropoffGeoPUDOId")]
        public int DropoffGeoPUDOId { get; set; }
    }
}
