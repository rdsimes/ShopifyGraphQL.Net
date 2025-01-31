using Xunit.Sdk;

namespace ShopifyGraphQL.Net.Tests
{
    public static class CustomAssert
    {
        /// <summary>
        /// Causes a test to fail.
        /// </summary>
        public static void Fail(string message) => throw new XunitException(message);
    }
}