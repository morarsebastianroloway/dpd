using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using Newtonsoft.Json;
using System.Text;

namespace dpd_api.Services.ClientServices
{
    public class DpdClientBase<TRequest, TResponse> : IDpdClientBase<TRequest, TResponse>
        where TRequest : BaseRequest
        where TResponse : BaseResponse
    {
        //#region Constants

        //private const string ServicesRequestUri = "services";
        //private const string CalculationRequestUri = "calculate";
        //private const string ShipmentRequestUri = "shipment";
        //private const string PrintRequestUri = "print";
        //private const string PickupRequestUri = "pickup";

        //#endregion Constants

        #region Public Methods

        public async Task<TResponse?> MakeRequestAsync(TRequest request, string requestUri)
        {
            StringContent jsonContent = GetJsonContent(request);

            // Construct http client
            using HttpClient httpClient = new();
            httpClient.BaseAddress = new Uri("https://api.dpd.ro/v1/");

            // Make the call and return the response
            var response = await httpClient.PostAsync(requestUri, jsonContent);

            if (response.IsSuccessStatusCode)
            {
                var dataString = await response.Content.ReadAsStringAsync();
                // TODO: If we need to save the response here it should be

                //var data = await response.Content.ReadFromJsonAsync<CalculationResponse>();
                var data = JsonConvert.DeserializeObject<TResponse>(dataString);

                return data;
            }

            return null;
        }

        public async Task<(TResponse?, byte[]?)> MakeRequestWithFileAsync(TRequest request, string requestUri)
        {
            StringContent jsonContent = GetJsonContent(request);

            // Construct http client
            using HttpClient httpClient = new();
            httpClient.BaseAddress = new Uri("https://api.dpd.ro/v1/");

            // Make the call and return the response
            var response = await httpClient.PostAsync(requestUri, jsonContent);

            if (response.IsSuccessStatusCode)
            {
                var dataString = await response.Content.ReadAsStringAsync();
                // TODO: If we need to save the response here it should be

                if (response.Content.Headers.ContentType != null &&
                    (response.Content.Headers.ContentType.MediaType == "application/pdf" ||
                    response.Content.Headers.ContentType.MediaType == "text/plain"))
                {
                    // We have a file, let's save it to disk
                    var outputFile = await response.Content.ReadAsByteArrayAsync();

                    return (null, outputFile);
                }
                else
                {
                    var data = JsonConvert.DeserializeObject<TResponse>(dataString);
                    return (data, null);
                }
            }

            return (null, null);
        }
        #endregion Public Methods

        #region Utilities

        private static StringContent GetJsonContent(TRequest request)
        {
            string jsonData = JsonConvert.SerializeObject(request);
            // TODO: If we need to save the request here it should be

            return new(
                jsonData,
                Encoding.UTF8,
                "application/json");
        }

        #endregion Utilities
    }
}
