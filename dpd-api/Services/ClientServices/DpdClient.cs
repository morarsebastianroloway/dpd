using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using Newtonsoft.Json;

namespace dpd_api.Services.ClientServices
{
    public class DpdClient : IDpdClient
    {
        public readonly IDpdClientBase<ServicesRequest, ServicesResponse> _dpdServicesClient;
        public readonly IDpdClientBase<CalculationRequest, CalculationResponse> _dpdCalculationClient;
        public readonly IDpdClientBase<ShipmentRequest, CreateShipmentResponse> _dpdShipmentClient;
        public readonly IDpdClientBase<PrintRequest, PrintResponse> _dpdPrintClient;
        public readonly IDpdClientBase<PickupRequest, PickupResponse> _dpdPickupClient;
        public readonly IDpdClientBase<FindCountryRequest, FindCountryResponse> _dpdFindCoutryClient;

        public DpdClient(
            IDpdClientBase<ServicesRequest, ServicesResponse> dpdServicesClient,
            IDpdClientBase<CalculationRequest, CalculationResponse> dpdCalculationClient,
            IDpdClientBase<ShipmentRequest, CreateShipmentResponse> dpdShipmentClient,
            IDpdClientBase<PrintRequest, PrintResponse> dpdPrintClient,
            IDpdClientBase<PickupRequest, PickupResponse> dpdPickupClient,
            IDpdClientBase<FindCountryRequest, FindCountryResponse> dpdFindCoutryClient)
        {
            _dpdServicesClient = dpdServicesClient;
            _dpdCalculationClient = dpdCalculationClient;
            _dpdShipmentClient = dpdShipmentClient;
            _dpdPrintClient = dpdPrintClient;
            _dpdPickupClient = dpdPickupClient;
            _dpdFindCoutryClient = dpdFindCoutryClient;
        }
        public async Task<ServicesResponse?> MakeServicesRequestAsync(ServicesRequest request)
        {
            return await _dpdServicesClient.MakeRequestAsync(request, "services");
        }

        public async Task<CalculationResponse?> MakeCalculationRequestAsync(CalculationRequest request)
        {
            return await _dpdCalculationClient.MakeRequestAsync(request, "calculate");
        }

        public async Task<CreateShipmentResponse?> MakeShipmentRequestAsync(ShipmentRequest request)
        {
            return await _dpdShipmentClient.MakeRequestAsync(request, "shipment");
        }

        public async Task<(PrintResponse?, byte[]?)> MakePrintRequestAsync(PrintRequest request)
        {
           return await _dpdPrintClient.MakeRequestWithFileAsync(request, "print");
        }

        public async Task<PickupResponse?> MakePickupRequestAsync(PickupRequest request)
        {
            return await _dpdPickupClient.MakeRequestAsync(request, "pickup");
        }

        public async Task<FindCountryResponse?> MakeLocationRequestAsync(FindCountryRequest request)
        {
            return await _dpdFindCoutryClient.MakeRequestAsync(request, "location/country");
        }
    }
}
