using Newtonsoft.Json;

namespace ShopifyGraphQL.Net.Filters
{
    public class CountryCountFilter : Parameterizable
    {
        /// <summary>
        /// Restrict results to after the specified ID. 
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
    }
}