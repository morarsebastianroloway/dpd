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
        private readonly IDpdClient<ShipmentRequest, CreateShipmentResponse> _dpdClient;

        public ShipmentController(
            ILogger<ShipmentController> logger, 
            IConfiguration configuration,
            IDpdClient<ShipmentRequest, CreateShipmentResponse> dpdClient)
            : base(configuration)
        {
            _logger = logger;
            _dpdClient = dpdClient;
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

            var data = await _dpdClient.MakeShipmentRequest(request);
            if(data!=null)
            {
                return Content(JsonConvert.SerializeObject(data), "application/json");
            }

            return Ok();
        }
    }
}