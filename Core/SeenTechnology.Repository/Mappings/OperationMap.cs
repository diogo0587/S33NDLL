using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OperationMap : ClassMap<Operation>
    {
        public OperationMap()
        {
            Table("StarW_Operation");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Oper_Id");
            References(x => x.Segment).Column("Segm_Id");
            References(x => x.Customer).Column("Cust_Id");
            Map(x => x.Description).Column("Oper_Description").Length(50);
            Map(x => x.Expiration).Column("Oper_Expiration");
            Map(x => x.CreateOccurProceda).Column("Oper_CreateOccurProceda").Not.Nullable();
            Map(x => x.DeliveryAttempts).Column("Oper_DeliveryAttempts").Precision(10);
            Map(x => x.CheckMinimunDistanceToStartJob).Column("Oper_CheckMinimunDistanceToStartJob");
            Map(x => x.MinimunDistanceToStartJob).Column("Oper_MinimunDistanceToStartJob").Precision(10);
            Map(x => x.NextWorkAlertMessage).Column("Oper_NextWorkAlertMessage").Length(100);
            Map(x => x.IssueCte).Column("Oper_IssueCte");
            Map(x => x.AddrLevel).Column("Oper_AddrLevel").Precision(10);
            Map(x => x.OrderBy).Column("Oper_OrderBy").Length(80);
            Map(x => x.OsInLoco).Column("Oper_OsInLoco");
            Map(x => x.SchedulingRoute).Column("Oper_SchedulingRoute");
            Map(x => x.NetworkType).Column("Oper_NetworkType").Length(10);
            HasMany(x => x.AlertOperations).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.ApplicationFlowSetups).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.Components).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.ContractOperations).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.DashQualityIndicators).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.DashSafetyIndicators).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.ImportOrderServices).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.OperationEventsRepiques).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.OrderServiceTypes).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.ParameterDashboardIndicators).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.Products).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.Questions).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.Questionnaries).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.Schedulers).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.SendWorkflowToCustomers).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.ServiceWorkflowConfigurations).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.StartPointOperations).KeyColumn("Oper_Id").Inverse();
            HasMany(x => x.UiConfigurationMobiles).KeyColumn("Oper_Id").Inverse();
        }
    }
}
