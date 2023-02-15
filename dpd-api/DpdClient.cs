using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using Newtonsoft.Json;
using System.Text;

namespace dpd_api
{
    public class DpdClient<TRequest, TResponse> : IDpdClient<TRequest, TResponse>
        where TRequest : BaseRequest
        where TResponse : BaseResponse
    {
        #region Constants

        private const string ShipmentRequestUri = "shipment";

        #endregion Constants

        #region Private Methods

        private async Task<TResponse?> MakeRequest(TRequest request, string requestUri)
        {
            string jsonData = JsonConvert.SerializeObject(request);
            // TODO: If we need to save the request here it should be

            using StringContent jsonContent = new(
                jsonData,
                Encoding.UTF8,
                "application/json");

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

        #endregion Private Methods

        #region Public Methods

        public async Task<TResponse?> MakeShipmentRequest(TRequest request)
        {
            return await MakeRequest(request, DpdClient<TRequest, TResponse>.ShipmentRequestUri);
        }

        #endregion Public Methods
    }
}
