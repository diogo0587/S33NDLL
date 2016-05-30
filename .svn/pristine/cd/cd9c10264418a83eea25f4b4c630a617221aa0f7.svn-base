using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ConsultProspectAccountMap : ClassMap<ConsultProspectAccount>
    {
        public ConsultProspectAccountMap()
        {
            Table("BcoOrg_ConsultProspectAccount");
            LazyLoad();
            Id(x => x.Id).Column("Cap_Id").GeneratedBy.Identity();
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.RecordStatus).Column("RecSt_Id");
        }
    }
}
