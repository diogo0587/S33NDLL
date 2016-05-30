using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ApplicationFlowMap : ClassMap<ApplicationFlow>
    {
        public ApplicationFlowMap()
        {
            Table("StarW_ApplicationFlow");
            Id(x => x.Id).Column("AppF_Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("AppF_Name");
            Map(x => x.Description).Column("AppF_Description");
            HasMany(x => x.ApplicationFlowSetups).KeyColumn("AppF_Id").Inverse();
            HasMany(x => x.AlertTracks).KeyColumn("AppF_Id").Inverse();
        }
    }
}
