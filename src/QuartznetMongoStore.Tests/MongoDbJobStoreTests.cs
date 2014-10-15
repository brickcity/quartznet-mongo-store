namespace QuartznetMongoStore.Tests
{
    using Quartz.Impl;
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

        [Fact]
        public void ShouldBeInstantiableFromConfig()
        {
            Assert.Equal(0, JobStore.InstanceCount);
            var factory = new StdSchedulerFactory();
            var scheduler = factory.GetScheduler();
            Assert.IsType<StdScheduler>(scheduler);
            Assert.Equal(1, JobStore.InstanceCount); 
            /*
             * remove 
             * <add key="quartz.jobStore.type" value="QuartznetMongoStore.JobStore, QuartznetMongoStore" />
             * from the app.config to make this test fail
             */
        }

        [Fact]
        public void ShouldBeStartable()
        {
            var sched = StdSchedulerFactory.GetDefaultScheduler();
            Assert.False(sched.IsStarted);
            sched.Start();
            Assert.True(sched.IsStarted);
            Assert.False(sched.IsShutdown);
            sched.Shutdown();
        }
    }
}
