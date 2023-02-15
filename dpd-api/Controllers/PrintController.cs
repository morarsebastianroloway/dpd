using dpd_api.Domain;
using Microsoft.AspNetCore.Mvc;
//using System.Text.Json;
using System.Text;
using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using Newtonsoft.Json;
using dpd_api.Domain.Print;
using System.Reflection;
using dpd_api.Domain.Enums;

namespace dpd_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrintController : BaseController
    {
        private readonly ILogger<PrintController> _logger;
        private readonly IDpdClient<PrintRequest, PrintResponse> _dpdClient;

        public PrintController(
            ILogger<PrintController> logger,
            IConfiguration configuration,
            IDpdClient<PrintRequest, PrintResponse> dpdClient)
            : base(configuration)
        {
            _logger = logger;
            _dpdClient = dpdClient;
        }

        [HttpGet(Name = "GetPrint")]
        public async Task<IActionResult> GetPrint()
        {
            var fileFormat = Domain.Enums.FileFormat.zpl;
            var request = new PrintRequest()
            {
                UserName = UserName,
                Password = Password,
                PaperSize = Domain.Enums.PaperSize.A6,
                Parcels = new List<ParcelToPrint>()
                {
                    new ParcelToPrint()
                    {
                        Parcel = new ShipmentParcelRef()
                        {
                            Id = "80613928583" // Taken from CreateShipment
                        }
                    }
                },
                Format = fileFormat
            };

            //string jsonData = JsonConvert.SerializeObject(request);
            //// TODO: If we need to save the request here it should be

            //using StringContent jsonContent = new(
            //    jsonData,
            //    Encoding.UTF8,
            //    "application/json");

            //// Construct the url
            //var url = "print";

            //// Construct http client
            //using HttpClient httpClient = new();
            //httpClient.BaseAddress = new Uri(BaseUrl);

            //// Make the call and return the response
            //var response = await httpClient.PostAsync(url, jsonContent);

            //if (response.IsSuccessStatusCode)
            //{
            //    var dataString = await response.Content.ReadAsStringAsync();
            //    // TODO: If we need to save the response here it should be

            //    if (response.Content.Headers.ContentType != null &&
            //        (response.Content.Headers.ContentType.MediaType == "application/pdf" ||
            //        response.Content.Headers.ContentType.MediaType == "text/plain"))
            //    {
            //        // We have a file, let's save it to disk
            //        var outputFile = await response.Content.ReadAsByteArrayAsync();

            //        var fileName = response.Content.Headers.ContentType.MediaType switch
            //        {
            //            "application/pdf" => "testpdf.pdf",
            //            "text/plain" => "testzpl.zpl"
            //        };

            //        var filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
            //        System.IO.File.WriteAllBytes(filePath, outputFile);
            //        return Ok("File downloaded");
            //    }
            //    else
            //    {
            //        var data = JsonConvert.DeserializeObject<PrintResponse>(dataString);
            //        return Content(JsonConvert.SerializeObject(data), "application/json");
            //    }
            //}

            //return Ok();

            var (data, byteFile) = await _dpdClient.MakePrintRequestAsync(request);
            if (data != null)
            {
                return Content(JsonConvert.SerializeObject(data), "application/json");
            }
            else
            {
                //We have a file, let's save it to disk
                var fileName = fileFormat == FileFormat.zpl ? "testzpl.zpl" : "testpdf.pdf";

                var filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
                System.IO.File.WriteAllBytes(filePath, byteFile);
                return Ok("File saved");
            }
        }
    }
}