using Newtonsoft.Json;

namespace dpd_api.Domain.Responses
{
    public class CalculationResponse : BaseResponse
    {
        /// <summary>
        /// Calculations for all service ids in request
        /// </summary>
        [JsonProperty(PropertyName = "calculations")]
        public IEnumerable<CalculationResult>? Calculations { get; set; }
    }
}
