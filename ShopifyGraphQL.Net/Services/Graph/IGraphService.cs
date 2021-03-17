using Newtonsoft.Json.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifyGraphQL.Net
{
    public interface IGraphService
    {
        Task<JToken> PostAsync(JToken body, CancellationToken cancellationToken = default);
        Task<JToken> PostAsync(string body, CancellationToken cancellationToken = default);
        Task<dynamic> PostAsync(string query, object variables, CancellationToken cancellationToken = default);
    }
}