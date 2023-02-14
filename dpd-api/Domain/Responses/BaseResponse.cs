using System.Text.Json.Serialization;

namespace dpd_api.Domain.Responses
{
    public class BaseResponse
    {
        [JsonPropertyName("error")]
        public Error Error { get; set; }
    }
}
