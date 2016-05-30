using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AlertTypeMap : ClassMap<AlertType>
    {
        public AlertTypeMap()
        {
            Table("StarW_AlertType");
            LazyLoad();
            Id(c => c.Id).Column("AlrtT_Id").GeneratedBy.Identity();
            Map(c => c.Name).Column("AlrtT_Name");
        }
    }
}
