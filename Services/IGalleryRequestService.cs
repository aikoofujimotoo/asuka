using System.Collections.Generic;
using System.Threading.Tasks;
using asuka.Api.Queries;
using asuka.Models;

namespace asuka.Services
{
    public interface IGalleryRequestService
    {
        Task<GalleryResult> FetchSingleAsync(string url);
        Task<IReadOnlyList<GalleryResult>> FetchRecommendedAsync(string url);
        Task<IReadOnlyList<GalleryResult>> SearchAsync(SearchQuery query);
        Task<int> GetTotalGalleryCountAsync();
    }
}