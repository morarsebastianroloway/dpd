using Newtonsoft.Json;

namespace dpd_api.Domain
{
    public class BaseCalculationLocation
    {
        /// <summary>
        /// Client id to refer serving client
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public long ClientId { get; set; }

        /// <summary>
        /// Private person flag.
        /// </summary>
        /// <remarks>If clientId is provided, it is forbidden. Otherwise, it is mandatory.</remarks>
        [JsonProperty(PropertyName = "privatePerson")]
        public bool IsPrivatePerson { get; set; }

        /// <summary>
        /// Address location, implies pickup at client address
        /// </summary>
        /// <remarks>Required if office id and clientId are missing. Otherwise it is forbidden</remarks>
        [JsonProperty(PropertyName = "addressLocation")]
        public AddressLocation AddressLocation { get; set; }

        /// <summary>
        /// Drop-off office id
        /// </summary>
        /// <remarks>Required if address location and clientId are missing. If address location presents it is forbidden</remarks>
        [JsonProperty(PropertyName = "dropoffOfficeId")]
        public int DropoffOfficeId { get; set; }

        /// <summary>
        /// DPD drop off office PUDO id
        /// </summary>
        /// <remarks>Not required. Must be empty if dropoffOfficeId is provided</remarks>
        [JsonProperty(PropertyName = "dropoffGeoPUDOId")]
        public int DropoffGeoPUDOId { get; set; }
    }
}
