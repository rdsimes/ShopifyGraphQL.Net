namespace ShopifyGraphQL.Net.Factories
{
    public static class GraphServiceFactory
    {
        public static IGraphService CreateGraphService(string myShopifyUrl,  string shopAccessToken)
        {
            return new GraphService(myShopifyUrl, shopAccessToken);
        }
    }

    public static class AuthorizationServiceFactory
    {
        public static IAuthorizationService CreateAuthorizationService()
        {
            return new AuthorizationService();
        }
    }
}
