quartznet-mongo-store
=====================

A MongoDB backend for the Quartz.net job scheduler

## Configuration

Setup the standard `Quartz` config sections in your `web.config` or `app.config` file.  Add the appropriate keys to instantiate the `JobStore` and pass it a valid MongoDb Connection String.

```xml
<configuration>
	<configSections>
		<section name="quartz" 
		type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0,Culture=neutral, PublicKeyToken=b77a5c561934e089" />
	</configSections>

  <quartz>
    <add key="quartz.scheduler.instanceName" value="TestScheduler" />
    <add key="quartz.jobStore.type" value="QuartznetMongoStore.JobStore, QuartznetMongoStore" />
    <add key="quartz.jobStore.connectionString" value="mongodb://localhost:27017/quartz" />
  </quartz>
</configuration>
```

## Starting the Scheduler
When desired, instantiate and start the scheduler.

```csharp
    var factory = new StdSchedulerFactory();
    var scheduler = factory.GetScheduler();
	scheduler.Start();
```
