using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using dpd_api.Services.ClientServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.WebSockets;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dpd_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : BaseController
    {
        private readonly ILogger<LocationController> _logger;
        private readonly IDpdClient2 _dpdClient;

        public LocationController(
            ILogger<LocationController> logger,
            IConfiguration configuration,
            IDpdClient2 dpdClient)
            : base(configuration)
        {
            _logger = logger;
            _dpdClient = dpdClient;
        }

        //[HttpGet(Name = "Get")]
        //public async Task<IActionResult> GetLocation()
        //{
        //    // Construct the url
        //    var query = new Dictionary<string, string>()
        //    {
        //        ["userName"] = UserName,
        //        ["password"] = Password,
        //        ["country_id"] = "642", // 642 stands for Romania
        //        ["name"] = "alb", // This is the search string, searches in city name, street etc
        //    };

        //    var url = GetUriWithQueryString("location/office", query);

        //    // Construct http client
        //    using HttpClient httpClient = new();
        //    httpClient.BaseAddress = new Uri(BaseUrl);

        //    // Make the call and return the response
        //    var response = await httpClient.GetAsync(url);

        //    if (response.IsSuccessStatusCode)
        //    {

        //        var data = await response.Content.ReadAsStringAsync();
        //        return Content(data, "application/json");
        //    }

        //    return Ok();
        //}

        //[HttpGet(Name = "GetAllCountries")]
        //public async Task<IActionResult> GetAllCountries()
        //{
        //    var request = new FindCountryRequest()
        //    {
        //        UserName = UserName,
        //        Password = Password,
        //    };

        //    var data = await _dpdClient.MakeRequestAsync(request,"location/country");
        //    var deserializedObject = JsonConvert.DeserializeObject<FindCountryResponse>(data);
        //    if (deserializedObject != null)
        //    {
        //        return Content(JsonConvert.SerializeObject(deserializedObject), "application/json");
        //    }

        //    return Ok();
        //}

        [HttpGet(Name = "GetStates")]
        public async Task<IActionResult> GetStates()
        {
            var request = new FindStateRequest()
            {
                UserName = UserName,
                Password = Password,
                CountryId = 642,
                Name = "Bis",
            };

            var data = await _dpdClient.MakeRequestAsync(request, "location/state");
            var deserializedObject = JsonConvert.DeserializeObject<FindCountryResponse>(data);
            if (deserializedObject != null)
            {
                return Content(JsonConvert.SerializeObject(deserializedObject), "application/json");
            }

            return Ok();
        }
    }
}