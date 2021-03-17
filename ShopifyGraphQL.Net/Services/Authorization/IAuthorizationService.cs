using ShopifyGraphQL.Net.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ShopifyGraphQL.Net
{
    public interface IAuthorizationService
    {
        Task<string> Authorize(string code, string myShopifyUrl, string shopifyApiKey, string shopifySecretKey);
        Task<AuthorizationResult> AuthorizeWithResult(string code, string myShopifyUrl, string shopifyApiKey, string shopifySecretKey);
        Uri BuildAuthorizationUrl(IEnumerable<AuthorizationScope> scopes, string myShopifyUrl, string shopifyApiKey, string redirectUrl, string state = null, IEnumerable<string> grants = null);
        Uri BuildAuthorizationUrl(IEnumerable<string> scopes, string myShopifyUrl, string shopifyApiKey, string redirectUrl, string state = null, IEnumerable<string> grants = null);
        bool IsAuthenticProxyRequest(IDictionary<string, string> querystring, string shopifySecretKey);
        bool IsAuthenticProxyRequest(NameValueCollection querystring, string shopifySecretKey);
        bool IsAuthenticProxyRequest(string querystring, string shopifySecretKey);
        bool IsAuthenticRequest(IDictionary<string, string> querystring, string shopifySecretKey);
        bool IsAuthenticRequest(NameValueCollection querystring, string shopifySecretKey);
        bool IsAuthenticRequest(string querystring, string shopifySecretKey);
        bool IsAuthenticWebhook(HttpRequestHeaders requestHeaders, string requestBody, string shopifySecretKey);
        Task<bool> IsAuthenticWebhook(NameValueCollection requestHeaders, Stream inputStream, string shopifySecretKey);
        bool IsAuthenticWebhook(NameValueCollection requestHeaders, string requestBody, string shopifySecretKey);
    }
}