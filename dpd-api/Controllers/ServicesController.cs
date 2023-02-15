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

        public ServicesController(ILogger<ServicesController> logger, IConfiguration configuration)
            :base(configuration)
        {
            _logger = logger;
        }


        [HttpGet(Name = "GetServices")]
        public async Task<IActionResult> GetServices()
        {
            var request = new ServicesRequest()
            {
                UserName = UserName,
                Password = Password,
            };

            string jsonData = JsonConvert.SerializeObject(request);
            // TODO: If we need to save the request here it should be

            using StringContent jsonContent = new(
                jsonData,
                Encoding.UTF8,
                "application/json");

            // Construct the url
            var url = "services";

            // Construct http client
            using HttpClient httpClient = new();
            httpClient.BaseAddress = new Uri(BaseUrl);

            // Make the call and return the response
            var response = await httpClient.PostAsync(url, jsonContent);

            if (response.IsSuccessStatusCode)
            {
                var dataString = await response.Content.ReadAsStringAsync();
                // TODO: If we need to save the response here it should be

                var data = JsonConvert.DeserializeObject<ServicesResponse>(dataString);

                return Content(JsonConvert.SerializeObject(data), "application/json");
            }

            return Ok();
        }
    }
}