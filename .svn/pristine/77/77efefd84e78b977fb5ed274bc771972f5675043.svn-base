using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ApplicationMap : ClassMap<Application>
    {
        public ApplicationMap()
        {
            Table("StarW_Application");
            LazyLoad();
            Id(x => x.Id).Column("App_Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("App_Name");
            HasMany(x => x.ApplicationFlows).KeyColumn("App_Id").Inverse();
        }
    }
}
