using Newtonsoft.Json;

namespace ShopifyGraphQL.Net.Filters
{
    public class WebhookCountFilter : Parameterizable
    {
        /// <summary>
        /// Restricts results to those with the given address. 
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Restricts results to those with the given topic. 
        /// </summary>
        [JsonProperty("topic")]
        public string Topic { get; set; }
    }
}