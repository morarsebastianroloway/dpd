using System.Text.Json.Serialization;

namespace dpd_api.Domain.Responses
{
    public class CalculationResponse : BaseResponse
    {
        /// <summary>
        /// Calculations for all service ids in request
        /// </summary>
        [JsonPropertyName("calculations")]
        public IEnumerable<CalculationResult> Calculations { get; set; }
    }
}
