using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class ServicesResponse : BaseResponse
    {
        [JsonProperty(PropertyName = "services")]
        public List<CourierService> CourierServices { get; set; }
    }
}
