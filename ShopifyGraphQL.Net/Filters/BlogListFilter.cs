using Newtonsoft.Json;

namespace ShopifyGraphQL.Net.Filters
{
    public class BlogListFilter : ListFilter<Blog>
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }
    }
}