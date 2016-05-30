using SeenTechnology.Domain.Enums;
using System;

namespace SeenTechnology.Domain.Entities
{
    public class Scheduler : Entity<long>
    {
        public virtual string Description { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual bool Monday { get; set; }
        public virtual bool Tuesday { get; set; }
        public virtual bool Wednesday { get; set; }
        public virtual bool Thursday { get; set; }
        public virtual bool Friday { get; set; }
        public virtual bool Saturday { get; set; }
        public virtual bool Sunday { get; set; }
        public virtual int ExecutionOrder { get; set; }
        public virtual JobTypeEnum JobType { get; set; }
        public virtual TimeSpan? TimeToRun { get; set; }
        public virtual int Periodicity { get; set; }
        public virtual TimeUnitEnum TimeUnit { get; set; }
        public virtual DateTime? LastExecution { get; set; }
        public virtual string AssemblyName { get; set; }
        public virtual string ClassType { get; set; }
        public virtual string MethodName { get; set; }
        public virtual Operation Operation { get; set; }
    }
}
