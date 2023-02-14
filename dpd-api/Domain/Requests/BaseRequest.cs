using Newtonsoft.Json;

namespace dpd_api.Domain.Requests
{
    public class BaseRequest
    {
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "clientSystemId")]
        public long ClientSystemId { get; set; }
    }
}
