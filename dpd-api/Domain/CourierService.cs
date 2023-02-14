using Newtonsoft.Json;
using dpd_api.Domain.Responses;

namespace dpd_api.Domain
{
    public class CourierService
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "nameEn")]
        public string NameEn { get; set; }
        [JsonProperty(PropertyName = "cargoType")]
        public string CargoType { get; set; }
        [JsonProperty(PropertyName = "requireParcelWeight")]
        public bool RequireParcelWeight { get; set; }
        [JsonProperty(PropertyName = "requireParcelSize")]
        public bool RequireParcelSize { get; set; }
    }
}
