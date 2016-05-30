using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class SupportOptionMap : ClassMap<SupportOption>
    {
        public SupportOptionMap()
        {
            Table("StarW_SupportOptions");
            LazyLoad();
            Id(x => x.Id).Column("SupOp_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("SupOp_Description");
            Map(x => x.Enable).Column("SupOp_Enable");
            Map(x => x.Name).Column("SupOp_Name");
            HasMany(x => x.Supports).KeyColumn("SupOp_Id").Inverse();
        }
    }
}
