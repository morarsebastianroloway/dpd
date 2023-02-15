using dpd_api.Domain.Base;
using Newtonsoft.Json;

namespace dpd_api.Domain.Calculation
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