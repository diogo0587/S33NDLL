using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceMap : ClassMap<OrderService>
    {
        public OrderServiceMap()
        {
            Table("StarW_OrderService");
            LazyLoad();
            Id(x => x.Id).Column("OrdS_ID").GeneratedBy.Identity();
            Map(x => x.DateTimeScheduling).Column("OrdS_DateTimeScheduling");
            Map(x => x.Protocol).Column("OrdS_Protocol");
            Map(x => x.Reference).Column("OrdS_Reference");
            Map(x => x.Auxiliary1).Column("OrdS_Auxiliary1");
            Map(x => x.Auxiliary2).Column("OrdS_Auxiliary2");
            Map(x => x.Auxiliary3).Column("OrdS_Auxiliary3");
            Map(x => x.Auxiliary4).Column("OrdS_Auxiliary4");
            Map(x => x.Auxiliary5).Column("OrdS_Auxiliary5");
            Map(x => x.WorkDay).Column("OrdS_WorkDay");
            Map(x => x.WoD).Column("OrdS_WoD");
            Map(x => x.ExternalId).Column("OrdS_ExternalId");
            Map(x => x.CustomerReference).Column("OrdS_CustomerReference");
            Map(x => x.CorporateName).Column("OrdS_CorporateName");
            Map(x => x.PhoneNumber1).Column("OrdS_PhoneNumber1");
            Map(x => x.PhoneNumber2).Column("OrdS_PhoneNumber2");
            Map(x => x.Email).Column("OrdS_Email");
            References(x => x.RequestTraking).Column("ReqT_Id");
            References(x => x.Address).Column("Addr_Id");
            References(x => x.OrderServiceType).Column("OrdST_ID");
            References(x => x.StartPointOperation).Column("StpxOp_Id");
            References(x => x.Groupaddress).Column("GrpAddr_Id");
            HasMany(x => x.ConsultProspectAccounts).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.AlertTracks).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.ClusteredWorkflows).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.ClusteredWorkflowDetails).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.CustomAlternatives).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.DashboardEvents).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.Images).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.ImportOrderServices).KeyColumn("OrdS_ID").Inverse();
            //HasMany(x => x.NotSendServiceEventsAgains).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.OrderServiceAttendances).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.OrderServiceCustomers).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.OrderServiceDetails).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.OrderServiceExportCteDetails).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.OrderServiceLayouts).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.OrderServiceStatuses).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.OrderServiceTrackings).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.OrderServiceWorkFlowAgains).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.OrderServiceWorkflowTokens).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.RouteDetails).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.ScanAuditings).KeyColumn("OrdS_ID").Inverse();
            HasMany(x => x.Supports).KeyColumn("OrdS_ID").Inverse();
        }
    }
}
