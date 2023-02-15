using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;

namespace dpd_api
{
    public interface IDpdClient<TRequest, TResponse>
        where TRequest : BaseRequest
        where TResponse : BaseResponse
    {
        Task<TResponse?> MakeShipmentRequest(TRequest request);
    }
}