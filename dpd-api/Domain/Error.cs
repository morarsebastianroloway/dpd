using System.Net;
using System.Reflection;
using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class Error
    {
        /// <summary>
        /// Message context, if associated. This refers to an item that is wrong and should be corrected.
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// Error message in language specified in the request.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// System generated unique error id to be used as this error reference.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Error code. See Appendix 3 - Error Codes for more details.
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// The request component, if applicable, relevant to this error in JSONPath format with dot notation.
        /// (For example $.sender.address.siteId refers to siteId property in sender address.)
        /// </summary>
        [JsonPropertyName("component")]
        public string Component { get; set; }
    }
}
