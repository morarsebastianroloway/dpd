using Newtonsoft.Json;

namespace dpd_api.Domain
{
    public class CalculationService : BaseService
    {
        /// <summary>
        /// Services for which calculation is requested
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "serviceIds")]
        public IEnumerable<int>? ServiceIds { get; set; }
    }
}