using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("StarW_Product");
            LazyLoad();
            Id(x => x.Id).Column("Prod_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("Prod_Description");
            Map(x => x.Protocol).Column("Prod_Protocol");
            Map(x => x.SerialNumber).Column("Prod_SerialNumber");
            Map(x => x.ExternalId).Column("Prod_ExternalId");
            References(x => x.ProductType).Column("ProdT_Id");
            References(x => x.ProductModel).Column("ProdM_Id");
            References(x => x.Operation).Column("Oper_Id");
            References(x => x.ProductCategory).Column("ProdCt_Id");
            HasMany(x => x.ProductComponents).KeyColumn("Prod_Id").Inverse();
            HasMany(x => x.OrderServiceDetails).KeyColumn("Prod_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflowProducts).KeyColumn("Prod_Id").Inverse();
            HasMany(x => x.RouteProducts).KeyColumn("Prod_Id").Inverse();
        }
    }
}
