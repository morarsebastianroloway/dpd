using Microsoft.AspNetCore.Mvc;
using System.Text;
using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using Newtonsoft.Json;
using dpd_api.Domain.Calculation;
using dpd_api.Domain.Shipment;
using System.Net.Sockets;

namespace dpd_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : BaseController
    {
        private readonly ILogger<CalculationController> _logger;
        private readonly IDpdClient<CalculationRequest, CalculationResponse> _dpdClient;

        public CalculationController(
            ILogger<CalculationController> logger,
            IConfiguration configuration,
            IDpdClient<CalculationRequest, CalculationResponse> dpdClient)
            : base(configuration)
        {
            _logger = logger;
            _dpdClient = dpdClient;
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
                        //2005, // CARGO NATIONAL // Weight > 31.5Kg < 50Kg
                        //2412, // PALLET ONE RO // Weight > 50Kg
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

            var data = await _dpdClient.MakeCalculationRequestAsync(request);
            if (data != null)
            {
                return Content(JsonConvert.SerializeObject(data), "application/json");
            }

            return Ok();
        }
    }
}