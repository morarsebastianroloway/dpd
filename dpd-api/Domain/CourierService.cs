using System.Text.Json.Serialization;

namespace dpd_api.Domain
{
    public class ServicesResponse
    {
        [JsonPropertyName("services")]
        public List<CourierService> CourierServices { get; set; }

        [JsonPropertyName("error")]
        public Error Error { get; set; }
    }
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
