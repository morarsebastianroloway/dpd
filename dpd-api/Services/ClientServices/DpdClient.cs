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

        public DpdClient(
            IDpdClientBase<ServicesRequest, ServicesResponse> dpdServicesClient,
            IDpdClientBase<CalculationRequest, CalculationResponse> dpdCalculationClient,
            IDpdClientBase<ShipmentRequest, CreateShipmentResponse> dpdShipmentClient,
            IDpdClientBase<PrintRequest, PrintResponse> dpdPrintClient,
            IDpdClientBase<PickupRequest, PickupResponse> dpdPickupClient)
        {
            _dpdServicesClient = dpdServicesClient;
            _dpdCalculationClient = dpdCalculationClient;
            _dpdShipmentClient = dpdShipmentClient;
            _dpdPrintClient = dpdPrintClient;
            _dpdPickupClient = dpdPickupClient;
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
    }
}
