using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceDetailMap : ClassMap<OrderServiceDetail>
    {
        public OrderServiceDetailMap()
        {
            Table("StarW_OrderServiceDetail");
            LazyLoad();
            Id(x => x.Id).Column("OrdSD_Id").GeneratedBy.Identity();
            Map(x => x.Quantity).Column("OrdSD_Quantity");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.ProductModel).Column("ProdM_Id");
            References(x => x.ProductType).Column("ProdT_Id");
            References(x => x.Product).Column("Prod_Id");
            HasMany(x => x.OrderServiceDetailComponents).KeyColumn("OrdSD_Id").Inverse();
        }
    }
}
