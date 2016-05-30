using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ProductModelMap : ClassMap<ProductModel>
    {
        public ProductModelMap()
        {
            Table("StarW_ProductModel");
            LazyLoad();
            Id(x => x.Id).Column("ProdM_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("ProdM_Description");
            Map(x => x.ExternalId).Column("ProdM_ExternalId");
            HasMany(x => x.Products).KeyColumn("ProdM_Id").Inverse();
            HasMany(x => x.OrderServiceDetails).KeyColumn("ProdM_Id").Inverse();
        }
    }
}
