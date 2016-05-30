using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AlertTypeDetailMap : ClassMap<AlertTypeDetail>
    {
        public AlertTypeDetailMap()
        {
            Table("StarW_AlertTypeDetail");
            LazyLoad();
            Id(x => x.Id).Column("AlrtTd_Id").GeneratedBy.Identity();
            Map(x => x.Content).Column("AlrtTd_Content");
            Map(x => x.Value).Column("AlrtTd_Value");
        }
    }
}
