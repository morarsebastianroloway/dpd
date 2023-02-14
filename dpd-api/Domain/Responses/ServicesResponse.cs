using System.Text.Json.Serialization;

namespace dpd_api.Domain.Responses
{
    public class ServicesResponse : BaseResponse
    {
        [JsonPropertyName("services")]
        public List<CourierService> CourierServices { get; set; }
    }
}
