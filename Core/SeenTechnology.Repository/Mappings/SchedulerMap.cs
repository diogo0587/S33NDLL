using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;
using SeenTechnology.Domain.Enums;

namespace SeenTechnology.Repository.Mappings
{
    public class SchedulerMap : ClassMap<Scheduler>
    {
        public SchedulerMap()
        {
            Table("StarW_Scheduler");
            LazyLoad();
            Id(x => x.Id).Column("Schd_Id").GeneratedBy.Identity();
            Map(x => x.Enabled).Column("Schd_Enabled");
            Map(x => x.Monday).Column("Schd_Monday");
            Map(x => x.Tuesday).Column("Schd_Tuesday");
            Map(x => x.Wednesday).Column("Schd_Wednesday");
            Map(x => x.Thursday).Column("Schd_Thursday");
            Map(x => x.Friday).Column("Schd_Friday");
            Map(x => x.Saturday).Column("Schd_Saturday");
            Map(x => x.Sunday).Column("Schd_Sunday");
            Map(x => x.JobType).Column("Schd_Jobtype").CustomType(typeof(JobTypeEnum));
            Map(x => x.Periodicity).Column("Schd_Periodicity");
            Map(x => x.TimeUnit).Column("Schd_Timeunit").CustomType(typeof(TimeUnitEnum));
            Map(x => x.Description).Column("Schd_Description");
            Map(x => x.AssemblyName).Column("Schd_AssemblyName");
            Map(x => x.ClassType).Column("Schd_ClassType");
            Map(x => x.MethodName).Column("Schd_MethodName");
            Map(x => x.LastExecution).Column("Schd_LastExecution");
            Map(x => x.ExecutionOrder).Column("Schd_ExecutionOrder");
            References(x => x.Operation).Column("Oper_Id").Cascade.None();
        }
    }
}
