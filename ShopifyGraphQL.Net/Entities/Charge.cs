using Newtonsoft.Json;
using ShopifyGraphQL.Net.Converters;
using ShopifyGraphQL.Net.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifyGraphQL.Net
{
    /// <summary>
    /// An object representing an application charge.
    /// </summary>
    public class Charge : ShopifyObject
    {
        /// <summary>
        /// The URL that the customer should be sent to, to accept or decline the application charge.
        /// </summary>
        [JsonProperty("confirmation_url")]
        public string ConfirmationUrl { get; set; }

        /// <summary>
        /// The date and time when the application charge was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The name of the application charge.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The price of the application charge.
        /// </summary>
        /// <remarks>Shopify returns this as a string, but JSON.net should be able to convert it to a decimal.</remarks>
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// The URL the customer is sent to once they accept/decline a charge.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The status of the charged. Known values are 'pending', 'accepted', 'active', 'cancelled', 'declined' and 'expired'.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// States whether or not the application charge is a test transaction.
        /// </summary>
        /// <remarks>Valid values are 'true' or null. Needs a special converter to convert null to false and vice-versa.</remarks>
        [JsonProperty("test"), JsonConverter(typeof(FalseToNullConverter))]
        public bool? Test { get; set; }

        /// <summary>
        /// The date and time when the recurring application charge was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
