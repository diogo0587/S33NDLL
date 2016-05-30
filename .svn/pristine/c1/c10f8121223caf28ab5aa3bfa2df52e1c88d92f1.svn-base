using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceExportCteMap : ClassMap<OrderServiceExportCte>
    {
        public OrderServiceExportCteMap()
        {
            Table("StarW_OrderServiceExportCte");
            LazyLoad();
            Id(x => x.Id).Column("OrdSEC_Id").GeneratedBy.Identity();
            References(x => x.Account).Column("Acct_Id");
            HasMany(x => x.OrderServiceExportCteDetails).KeyColumn("OrdSEC_Id").Inverse();
        }
    }
}
