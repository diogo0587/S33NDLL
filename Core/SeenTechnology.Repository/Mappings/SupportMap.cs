using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class SupportMap : ClassMap<Support>
    {
        public SupportMap()
        {
            Table("StarW_Support");
            Id(m => m.Id).Column("Supt_Id").GeneratedBy.Identity();
            Map(m => m.Enable).Column("Supt_Enable");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.SupportOption).Column("SupOp_Id");
            HasMany(x => x.SupportDetails).KeyColumn("Supt_Id").Inverse();
        }
    }
}
