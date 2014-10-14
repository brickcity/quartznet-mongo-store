namespace QuartznetMongoStore.Tests
{
    using Quartz.Spi;
    using Xunit;

    public class MongoDbJobStoreTests
    {
        [Fact]
        public void ShouldImplementIJobStore()
        {
            var store = new JobStore();
            Assert.True(store is IJobStore);
        }
    }
}
