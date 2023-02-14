using System.Text.Json.Serialization;

namespace dpd_api.Domain.Requests
{
    public class BaseRequest
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("clientSystemId")]
        public long ClientSystemId { get; set; }
    }
}
