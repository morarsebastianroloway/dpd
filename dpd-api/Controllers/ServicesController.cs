using dpd_api.Domain;
using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using dpd_api.Domain.Shipment;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Text;

namespace dpd_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicesController : BaseController
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly IDpdClient<ServicesRequest, ServicesResponse> _dpdClient;

        public ServicesController(ILogger<ServicesController> logger, IConfiguration configuration, IDpdClient<ServicesRequest, ServicesResponse> dpdClient)
            : base(configuration)
        {
            _logger = logger;
            _dpdClient = dpdClient;
        }


        [HttpGet(Name = "GetServices")]
        public async Task<IActionResult> GetServices()
        {
            var request = new ServicesRequest()
            {
                UserName = UserName,
                Password = Password,
            };

            var data = await _dpdClient.MakeServicesRequestAsync(request);
            if (data != null)
            {
                return Content(JsonConvert.SerializeObject(data), "application/json");
            }

            return Ok();
        }
    }
}