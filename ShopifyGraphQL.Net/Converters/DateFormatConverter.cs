﻿using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifyGraphQL.Net.Converters
{
    /// <summary>
    /// Converts a Date to and from the provided date format string.
    /// In Particular, GiftCard.ExpiresOn only accepts the format 'yyyy-MM-dd'. If the time is included the value is ignored
    /// </summary>
    public class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter(string format)
        {
            base.DateTimeFormat = format;
        }
    }
}
