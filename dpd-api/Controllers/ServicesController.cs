using dpd_api.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using System.Text.Json;

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
            // Construct the url
            var query = new Dictionary<string, string>()
            {
                ["userName"] = UserName,
                ["password"] = Password,
            };

            var url = GetUriWithQueryString("services", query);

            // Construct http client
            using HttpClient httpClient = new();
            httpClient.BaseAddress = new Uri(BaseUrl);

            // Make the call and return the response
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {

                var data = await response.Content.ReadAsStringAsync();
                return Content(data, "application/json");
            }

            return Ok();
        }
        [HttpPost(Name = "PostServices")]
        public async Task<IActionResult> PostServices()
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    userName = UserName,
                    password = Password,
                }),
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
                var data = await response.Content.ReadFromJsonAsync<ServicesResponse>();
                return Content(JsonSerializer.Serialize(data), "application/json");
            }

            return Ok();
        }
    }
}