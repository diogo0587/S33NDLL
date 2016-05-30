using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ProductTypeMap : ClassMap<ProductType>
    {
        public ProductTypeMap()
        {
            Table("StarW_ProductType");
            LazyLoad();
            Id(x => x.Id).Column("ProdT_Id").GeneratedBy.Identity();
            Map(x => x.ExternalId).Column("ProdT_ExternalId");
            Map(x => x.Description).Column("ProdT_Description");
            HasMany(x => x.Products).KeyColumn("ProdT_Id").Inverse();
            HasMany(x => x.OrderServiceDetails).KeyColumn("ProdT_Id").Inverse();
        }
    }
}
