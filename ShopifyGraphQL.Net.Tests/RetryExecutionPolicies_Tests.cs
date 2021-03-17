using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ShopifyGraphQL.Net.Tests
{
    [Trait("Category", "Retry policies")]
    public class RetryExecutionPolicies_Tests
    {
        private GraphService GraphService { get; } = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);
                
        [Fact]
        public async Task NonLeakyBucketBreachShouldNotAttemptRetry()
        {
            GraphService.SetExecutionPolicy(new SmartRetryExecutionPolicy());
            bool caught = false;
            try
            {
                //trip the 5 orders per minute limit on dev stores
                foreach (var i in Enumerable.Range(0, 10))
                {
                    await GraphService.PostAsync("");
                }
            }
            catch (ShopifyRateLimitException ex)
            {
                caught = true;
                Assert.True(ex.Reason != ShopifyRateLimitReason.BucketFull);
            }
            Assert.True(caught);
        }

        [Fact]
        public async Task NonLeakyBucketBreachShouldRetryWhenConstructorBoolIsFalse()
        {
            GraphService.SetExecutionPolicy(new SmartRetryExecutionPolicy(false));
            
            bool caught = false;
            
            try
            {
                //trip the 5 orders per minute limit on dev stores
                foreach (var i in Enumerable.Range(0, 10))
                {
                    await GraphService.PostAsync("");
                }
            }
            catch (ShopifyRateLimitException)
            {
                caught = true;
            }
            
            Assert.False(caught);
        }

        [Fact]
        public async Task LeakyBucketBreachShouldAttemptRetry()
        {
            GraphService.SetExecutionPolicy(new SmartRetryExecutionPolicy());
            
            bool caught = false;
            
            try
            {
                //trip the 40/seconds bucket limit
                await Task.WhenAll(Enumerable.Range(0, 45).Select(async _ => await GraphService.PostAsync("")));
            }
            catch (ShopifyRateLimitException)
            {
                caught = true;
            }
            
            Assert.False(caught);
        }
    }
}
