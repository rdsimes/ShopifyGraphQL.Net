using Newtonsoft.Json;
using ShopifyGraphQL.Net.Converters;
using Xunit;

namespace ShopifyGraphQL.Net.Tests
{
    [Trait("Category", "FalseToNullConverter")]
    public class FalseToNullConverter_Tests
    {
        public FalseToNullConverter_Tests()
        {

        }

        [Fact]
        public void SerializeTrue()
        {
            string serializedJson = JsonConvert.SerializeObject(new TestObject()
            {
                Value = true
            }, new FalseToNullConverter());
            var deserialized = JsonConvert.DeserializeObject<TestObject>("{ \"Value\" : \"true\" }", new FalseToNullConverter());

            Assert.Equal(serializedJson, "{\"Value\":true}");
            Assert.True(deserialized.Value);
        }

        [Fact]
        public void SerializeFalse()
        {
            string serializedJson = JsonConvert.SerializeObject(new TestObject()
            {
                Value = false
            }, new FalseToNullConverter());
            var deserialized = JsonConvert.DeserializeObject<TestObject>("{ \"Value\" : \"\" }", new FalseToNullConverter());

            Assert.Equal(serializedJson, "{\"Value\":null}");
            Assert.False(deserialized.Value);
        }

        class TestObject
        {
            public bool Value { get; set; }
        }
    }
}
