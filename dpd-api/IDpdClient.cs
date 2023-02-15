using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;

namespace dpd_api
{
    public interface IDpdClient<TRequest, TResponse>
        where TRequest : BaseRequest
        where TResponse : BaseResponse
    {
        Task<TResponse?> MakeServicesRequestAsync(TRequest request);
        Task<TResponse?> MakeCalculationRequestAsync(TRequest request);
        Task<TResponse?> MakeShipmentRequestAsync(TRequest request);
        Task<(TResponse?, byte[]?)> MakePrintRequestAsync(TRequest request);
        Task<TResponse?> MakePickupRequestAsync(TRequest request);
    }
}