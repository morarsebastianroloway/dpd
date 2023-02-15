using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class BaseResponse
    {
        /// <summary>
        /// Response error
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }
    }
}
