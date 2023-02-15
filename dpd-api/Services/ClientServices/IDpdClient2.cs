using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;

namespace dpd_api.Services.ClientServices
{
    public interface IDpdClient2
    {
        Task<string?> MakeRequestAsync(object request, string requestUri);
        Task<(string?, byte[]?)> MakeRequestWithFileAsync(object request, string requestUri);
    }
}