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
    public class ShipmentController : BaseController
    {
        private readonly ILogger<ShipmentController> _logger;

        public ShipmentController(ILogger<ShipmentController> logger, IConfiguration configuration)
            : base(configuration)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetShipment")]
        public async Task<IActionResult> GetShipment()
        {
            var request = new ShipmentRequest()
            {
                UserName = UserName,
                Password = Password,
                Recipient = new ShipmentRecipient()
                {
                    Address = new ShipmentAddress()
                    {
                        CountryId = 642, //100 - BG, 642 - RO
                        SiteId = "642101026", // 642101026 - Alba Iulia (oficiu dpd); 68314 - Vitosha BG
                        StreetName = "P-ta Horea",
                        StreetNo = "8",
                        ApartmentNo = "7",

                    },
                    ClientName = "Dpd Test",
                    Phone1 = new ShipmentPhoneNumber()
                    {
                        Number = "0740123456"
                    },
                    IsPrivatePerson = true,
                },
                Service = new ShipmentService()
                {
                    AutoAdjustPickupDate = true,
                    ServiceId = 2505, // DPD STANDARD // Weight < 31.5Kg
                },
                Content = new ShipmentContent()
                {
                    ParcelsCount = 1,
                    TotalWeight = 1,
                    Contents = "Shopping cart from Malio",
                    Package = "Ambalare simpla"
                },
                Payment = new ShipmentPayment()
                {
                    CourierServicePayer = Domain.Enums.Payer.SENDER
                }
            };

            string jsonData = JsonConvert.SerializeObject(request);
            // TODO: If we need to save the request here it should be

            using StringContent jsonContent = new(
                jsonData,
                Encoding.UTF8,
                "application/json");

            // Construct the url
            var url = "shipment";

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
                var data = JsonConvert.DeserializeObject<CreateShipmentResponse>(dataString);

                return Content(JsonConvert.SerializeObject(data), "application/json");
            }

            return Ok();
        }
    }
}