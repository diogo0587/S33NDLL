using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceEventMap : ClassMap<ServiceEvent>
    {
        public ServiceEventMap()
        {
            Table("StarW_ServiceEvent");
            LazyLoad();
            Id(x => x.Id).Column("SerE_Id").GeneratedBy.Identity();
            Map(x => x.DescriptionBefore).Column("SerE_DescriptionBeforeWork");
            Map(x => x.DescriptionAfter).Column("SerE_DescriptionAfterWork");
            Map(x => x.Enable).Column("SerE_Enable");
            Map(x => x.LastEvent).Column("SerE_LastEvent");
            Map(x => x.FixedMenu).Column("SerE_FixedMenu");
            Map(x => x.Auxiliary1).Column("SerE_Auxiliary1");
            Map(x => x.SendOnline).Column("SerE_SendOnline");
            References(x => x.ServiceTypeOrderServiceType).Column("SrOsT_Id");
            References(x => x.OrderServiceType).Column("OrdST_ID");
            References(x => x.ServiceEventType).Column("SerET_Id");
            References(x => x.ServiceEventGroup).Column("SerEG_Id");
            HasMany(x => x.ServiceEventWorkflows).KeyColumn("SerE_Id").Inverse();
            HasMany(x => x.AlertAlternativeServiceEvents).KeyColumn("SerE_Id");
            HasMany(x => x.ApplicationFlowSetups).KeyColumn("SerE_Id");
            HasMany(x => x.NotSendServiceEventsAgainDetails).KeyColumn("SerE_Id");
            HasMany(x => x.OperationEventRepiques).KeyColumn("SerE_Id");
            HasMany(x => x.OrderServiceAttendances).KeyColumn("SerE_Id");
            HasMany(x => x.RouteDetails).KeyColumn("SerE_Id");
        }
    }
}
