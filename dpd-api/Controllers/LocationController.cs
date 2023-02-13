using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;

namespace dpd_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : BaseController
    {
        private readonly ILogger<LocationController> _logger;

        public LocationController(ILogger<LocationController> logger, IConfiguration configuration)
            :base(configuration)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get")]
        public async Task<IActionResult> GetLocation()
        {
            // Construct the url
            var query = new Dictionary<string, string>()
            {
                ["userName"] = UserName,
                ["password"] = Password,
                ["country_id"] = "642", // 642 stands for Romania
                ["name"] = "alb", // This is the search string, searches in city name, street etc
            };

            var url = GetUriWithQueryString("location/office", query);

            // Construct http client
            using HttpClient httpClient = new HttpClient();
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

        private string GetUriWithQueryString(string requestUri,
    Dictionary<string, string> queryStringParams)
        {
            bool startingQuestionMarkAdded = false;
            var sb = new StringBuilder();
            sb.Append(requestUri);
            foreach (var parameter in queryStringParams)
            {
                if (parameter.Value == null)
                {
                    continue;
                }

                sb.Append(startingQuestionMarkAdded ? '&' : '?');
                sb.Append(parameter.Key);
                sb.Append('=');
                sb.Append(parameter.Value);
                startingQuestionMarkAdded = true;
            }
            return sb.ToString();
        }
    }
}