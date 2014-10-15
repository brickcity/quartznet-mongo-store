namespace QuartznetMongoStore
{
    using System;
    using System.Collections.Generic;

    using Quartz.Spi;

    public class JobStore : IJobStore
    {
        private string instanceId;

        private string instanceName;

        private int threadPoolSize;

        public static int InstanceCount
        {
            get; 
            private set;
        }
        public JobStore()
        {
            InstanceCount++;
        }

        public IList<IOperableTrigger> AcquireNextTriggers(DateTimeOffset noLaterThan, int maxCount, TimeSpan timeWindow)
        {
            throw new NotImplementedException();
        }

        public bool CheckExists(Quartz.TriggerKey triggerKey)
        {
            throw new NotImplementedException();
        }

        public bool CheckExists(Quartz.JobKey jobKey)
        {
            throw new NotImplementedException();
        }

        public void ClearAllSchedulingData()
        {
            throw new NotImplementedException();
        }

        public bool Clustered
        {
            get
            {
                return true;
            }
        }

        public long EstimatedTimeToReleaseAndAcquireTrigger
        {
            get { throw new NotImplementedException(); }
        }

        public IList<string> GetCalendarNames()
        {
            throw new NotImplementedException();
        }

        public IList<string> GetJobGroupNames()
        {
            throw new NotImplementedException();
        }

        public Quartz.Collection.ISet<Quartz.JobKey> GetJobKeys(Quartz.Impl.Matchers.GroupMatcher<Quartz.JobKey> matcher)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfCalendars()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfJobs()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfTriggers()
        {
            throw new NotImplementedException();
        }

        public Quartz.Collection.ISet<string> GetPausedTriggerGroups()
        {
            throw new NotImplementedException();
        }

        public IList<string> GetTriggerGroupNames()
        {
            throw new NotImplementedException();
        }

        public Quartz.Collection.ISet<Quartz.TriggerKey> GetTriggerKeys(Quartz.Impl.Matchers.GroupMatcher<Quartz.TriggerKey> matcher)
        {
            throw new NotImplementedException();
        }

        public Quartz.TriggerState GetTriggerState(Quartz.TriggerKey triggerKey)
        {
            throw new NotImplementedException();
        }

        public IList<IOperableTrigger> GetTriggersForJob(Quartz.JobKey jobKey)
        {
            throw new NotImplementedException();
        }

        public void Initialize(ITypeLoadHelper loadHelper, ISchedulerSignaler signaler)
        {
            
        }

        public string InstanceId
        {
            set
            {
                this.instanceId = value;
            }
        }

        public string InstanceName
        {
            set
            {
                this.instanceName = value;
            }
        }

        public bool IsJobGroupPaused(string groupName)
        {
            throw new NotImplementedException();
        }

        public bool IsTriggerGroupPaused(string groupName)
        {
            throw new NotImplementedException();
        }

        public void PauseAll()
        {
            throw new NotImplementedException();
        }

        public void PauseJob(Quartz.JobKey jobKey)
        {
            throw new NotImplementedException();
        }

        public IList<string> PauseJobs(Quartz.Impl.Matchers.GroupMatcher<Quartz.JobKey> matcher)
        {
            throw new NotImplementedException();
        }

        public void PauseTrigger(Quartz.TriggerKey triggerKey)
        {
            throw new NotImplementedException();
        }

        public Quartz.Collection.ISet<string> PauseTriggers(Quartz.Impl.Matchers.GroupMatcher<Quartz.TriggerKey> matcher)
        {
            throw new NotImplementedException();
        }

        public void ReleaseAcquiredTrigger(IOperableTrigger trigger)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCalendar(string calName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveJob(Quartz.JobKey jobKey)
        {
            throw new NotImplementedException();
        }

        public bool RemoveJobs(IList<Quartz.JobKey> jobKeys)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTrigger(Quartz.TriggerKey triggerKey)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTriggers(IList<Quartz.TriggerKey> triggerKeys)
        {
            throw new NotImplementedException();
        }

        public bool ReplaceTrigger(Quartz.TriggerKey triggerKey, IOperableTrigger newTrigger)
        {
            throw new NotImplementedException();
        }

        public void ResumeAll()
        {
            throw new NotImplementedException();
        }

        public void ResumeJob(Quartz.JobKey jobKey)
        {
            throw new NotImplementedException();
        }

        public Quartz.Collection.ISet<string> ResumeJobs(Quartz.Impl.Matchers.GroupMatcher<Quartz.JobKey> matcher)
        {
            throw new NotImplementedException();
        }

        public void ResumeTrigger(Quartz.TriggerKey triggerKey)
        {
            throw new NotImplementedException();
        }

        public IList<string> ResumeTriggers(Quartz.Impl.Matchers.GroupMatcher<Quartz.TriggerKey> matcher)
        {
            throw new NotImplementedException();
        }

        public Quartz.ICalendar RetrieveCalendar(string calName)
        {
            throw new NotImplementedException();
        }

        public Quartz.IJobDetail RetrieveJob(Quartz.JobKey jobKey)
        {
            throw new NotImplementedException();
        }

        public IOperableTrigger RetrieveTrigger(Quartz.TriggerKey triggerKey)
        {
            throw new NotImplementedException();
        }

        public void SchedulerPaused()
        {

        }

        public void SchedulerResumed()
        {
            throw new NotImplementedException();
        }

        public void SchedulerStarted()
        {
 
        }

        public void Shutdown()
        {

        }

        public void StoreCalendar(string name, Quartz.ICalendar calendar, bool replaceExisting, bool updateTriggers)
        {
            throw new NotImplementedException();
        }

        public void StoreJob(Quartz.IJobDetail newJob, bool replaceExisting)
        {
            throw new NotImplementedException();
        }

        public void StoreJobAndTrigger(Quartz.IJobDetail newJob, IOperableTrigger newTrigger)
        {
            throw new NotImplementedException();
        }

        public void StoreJobsAndTriggers(IDictionary<Quartz.IJobDetail, Quartz.Collection.ISet<Quartz.ITrigger>> triggersAndJobs, bool replace)
        {
            throw new NotImplementedException();
        }

        public void StoreTrigger(IOperableTrigger newTrigger, bool replaceExisting)
        {
            throw new NotImplementedException();
        }

        public bool SupportsPersistence
        {
            get
            {
                return true;
            }
        }

        public int ThreadPoolSize
        {
            set
            {
                this.threadPoolSize = value;
            }
        }

        public void TriggeredJobComplete(IOperableTrigger trigger, Quartz.IJobDetail jobDetail, Quartz.SchedulerInstruction triggerInstCode)
        {
            throw new NotImplementedException();
        }

        public IList<TriggerFiredResult> TriggersFired(IList<IOperableTrigger> triggers)
        {
            throw new NotImplementedException();
        }

        public string ConnectionString
        {
            set
            {
                this.connectionString = value;
            }
        }

        private string connectionString;
    }
}
