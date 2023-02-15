using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;

namespace dpd_api.Services.ClientServices
{
    public interface IDpdClient
    {
        Task<ServicesResponse?> MakeServicesRequestAsync(ServicesRequest request);
        Task<CalculationResponse?> MakeCalculationRequestAsync(CalculationRequest request);
        Task<CreateShipmentResponse?> MakeShipmentRequestAsync(ShipmentRequest request);
        Task<(PrintResponse?, byte[]?)> MakePrintRequestAsync(PrintRequest request);
        Task<PickupResponse?> MakePickupRequestAsync(PickupRequest request);
    }
}
