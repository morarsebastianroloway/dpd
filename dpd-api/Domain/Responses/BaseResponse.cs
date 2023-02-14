using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class BaseResponse
    {
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }
    }
}
