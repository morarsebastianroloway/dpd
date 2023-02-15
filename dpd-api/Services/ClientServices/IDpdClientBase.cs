using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;

namespace dpd_api.Services.ClientServices
{
    public interface IDpdClientBase<TRequest, TResponse>
        where TRequest : BaseRequest
        where TResponse : BaseResponse
    {
        Task<TResponse?> MakeRequestAsync(TRequest request, string requestUri);
        Task<(TResponse?, byte[]?)> MakeRequestWithFileAsync(TRequest request, string requestUri);
    }
}