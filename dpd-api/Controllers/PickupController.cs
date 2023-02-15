using Microsoft.AspNetCore.Mvc;
//using System.Text.Json;
using System.Text;
using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using Newtonsoft.Json;
using dpd_api.Domain.Shipment;
using System.Net.Sockets;
using dpd_api.Services.ClientServices;

namespace dpd_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PickupController : BaseController
    {
        private readonly ILogger<PickupController> _logger;
        private readonly IDpdClient _dpdClient;

        public PickupController(
            ILogger<PickupController> logger,
            IConfiguration configuration,
            IDpdClient dpdClient)
            : base(configuration)
        {
            _logger = logger;
            _dpdClient = dpdClient;
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
                    "80614367002" // Taken from CreateShipment
                }
            };

            var data = await _dpdClient.MakePickupRequestAsync(request);
            if (data != null)
            {
                return Content(JsonConvert.SerializeObject(data), "application/json");
            }

            return Ok();
        }
    }
}