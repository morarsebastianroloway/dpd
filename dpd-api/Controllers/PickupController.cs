using Microsoft.AspNetCore.Mvc;
//using System.Text.Json;
using System.Text;
using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using Newtonsoft.Json;
using dpd_api.Domain.Shipment;

namespace dpd_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PickupController : BaseController
    {
        private readonly ILogger<PickupController> _logger;

        public PickupController(ILogger<PickupController> logger, IConfiguration configuration)
            : base(configuration)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPickup")]
        public async Task<IActionResult> GetPickup()
        {
            var request = new PickupRequest()
            {
                UserName = UserName,
                Password = Password,
                VisitEndTime = "17:00",
                PickupScope = Domain.Enums.PickupScope.EXPLICIT_SHIPMENT_ID_LIST,
                ExplicitShipmentIdList = new[]
                {
                    "80613928583" // Taken from CreateShipment
                }
            };

            string jsonData = JsonConvert.SerializeObject(request);
            // TODO: If we need to save the request here it should be

            using StringContent jsonContent = new(
                jsonData,
                Encoding.UTF8,
                "application/json");

            // Construct the url
            var url = "pickup";

            // Construct http client
            using HttpClient httpClient = new();
            httpClient.BaseAddress = new Uri(BaseUrl);

            // Make the call and return the response
            var response = await httpClient.PostAsync(url, jsonContent);

            if (response.IsSuccessStatusCode)
            {
                var dataString = await response.Content.ReadAsStringAsync();
                // TODO: If we need to save the response here it should be

                //var data = await response.Content.ReadFromJsonAsync<CalculationResponse>();
                var data = JsonConvert.DeserializeObject<PickupResponse>(dataString);

                return Content(JsonConvert.SerializeObject(data), "application/json");
            }

            return Ok();
        }
    }
}