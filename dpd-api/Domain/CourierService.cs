using System.Text.Json.Serialization;
using dpd_api.Domain.Responses;

namespace dpd_api.Domain
{
    public class CourierService
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("nameEn")]
        public string NameEn { get; set; }
        [JsonPropertyName("cargoType")]
        public string CargoType { get; set; }
        [JsonPropertyName("requireParcelWeight")]
        public bool RequireParcelWeight { get; set; }
        [JsonPropertyName("requireParcelSize")]
        public bool RequireParcelSize { get; set; }
    }
}
