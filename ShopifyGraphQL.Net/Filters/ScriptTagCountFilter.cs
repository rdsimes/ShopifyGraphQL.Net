using Newtonsoft.Json;

namespace ShopifyGraphQL.Net.Filters
{
    public class ScriptTagCountFilter : Parameterizable
    {
        /// <summary>
        /// Restricts results to those with the given src value.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }
    }
}