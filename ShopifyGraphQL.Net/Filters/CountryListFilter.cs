﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifyGraphQL.Net.Filters
{
    /// <summary>
    /// Options for filtering lists of Countries. 
    /// </summary>
    public class CountryListFilter : ListFilter<Country>
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
    }
}
