using dpd_api.Domain;
using Microsoft.AspNetCore.Mvc;
//using System.Text.Json;
using System.Text;
using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace dpd_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : BaseController
    {
        private readonly ILogger<CalculationController> _logger;

        public CalculationController(ILogger<CalculationController> logger, IConfiguration configuration)
            : base(configuration)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCalculation")]
        public async Task<IActionResult> GetCalculation()
        {
            var request = new CalculationRequest()
            {
                UserName = UserName,
                Password = Password,
                Recipient = new CalculationRecipient()
                {
                    AddressLocation = new AddressLocation()
                    {
                        CountryId = 642, //100 - BG, 642 - RO
                        SiteId = "642101026"// 642101026 - Alba Iulia (oficiu dpd); 68314 - Vitosha BG
                    }
                },
                Service = new CalculationService()
                {
                    AutoAdjustPickupDate = true,
                    ServiceIds = new List<int> 
                    {
                        2505, // DPD STANDARD // Weight < 31.5Kg
                        2005, // CARGO NATIONAL // Weight > 31.5Kg < 50Kg
                        2412, // PALLET ONE RO // Weight > 50Kg
                        //2113, // CLASIC NATIONAL LOCO
                        //2002, // CLASIC NATIONAL
                        //2323, // CERERE DE COLECTARE INTERNATIONALA (RUTIER)
                        //2212, // EXPRESS REGIONAL
                        //2214, // CARGO REGIONAL
                        //2303, // CLASIC INTERNATIONAL (RUTIER)
                    }
                },
                Content = new CalculationContent() 
                { 
                    ParcelsCount = 1,
                    TotalWeight = 1
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
            var url = "calculate";

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
                var data = JsonConvert.DeserializeObject<CalculationResponse>(dataString);

                return Content(JsonConvert.SerializeObject(data), "application/json");
            }

            return Ok();
        }
    }
}