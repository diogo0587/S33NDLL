using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class PACMap : ClassMap<PAC>
    {
        public PACMap()
        {
            Table("BcoOrg_PAC");
            LazyLoad();
            Id(x => x.Id).Column("Pac_Id").GeneratedBy.Identity();
            Map(x => x.Json).Column("Pac_Json").CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.TemplateCode).Column("Pac_TemplateCode");
            Map(x => x.FileName).Column("Pac_FileName");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.OrderServiceCustomer).Column("OrdSC_Id");
        }
    }
}
