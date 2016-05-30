using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class TechnicianMap : ClassMap<Technician>
    {
        public TechnicianMap()
        {
            Table("StarW_Technician");
            LazyLoad();
            Id(x => x.Id).Column("Tech_Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("Tech_Name");
            Map(x => x.ExternalId).Column("Tech_ExternalId");
            Map(x => x.Enable).Column("Tech_Enable");
            Map(x => x.CPF).Column("Tech_Cpf");
            References(x => x.Account).Column("Acct_Id");
            HasMany(x => x.BiorecycleTemplates).KeyColumn("Tech_Id").Inverse();
            HasMany(x => x.DashboardEvents).KeyColumn("Tech_Id").Inverse();
            HasMany(x => x.DeviceAllocateds).KeyColumn("Tech_Id").Inverse();
            HasMany(x => x.GpsPositions).KeyColumn("Tech_Id").Inverse();
            HasMany(x => x.Images).KeyColumn("Tech_Id").Inverse();
            HasMany(x => x.OrderServiceAttendances).KeyColumn("Tech_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflowQuestionResponses).KeyColumn("Tech_Id").Inverse();
            HasMany(x => x.Routes).KeyColumn("Tech_Id").Inverse();
        }
    }
}
