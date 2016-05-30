using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ProductCategoryMap : ClassMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
            Table("StarW_ProductCategory");
            LazyLoad();
            Id(c => c.Id).Column("ProdCt_Id").GeneratedBy.Identity();
            Map(c => c.Description).Column("ProdCt_Description");
            Map(c => c.Name).Column("ProdCt_Name");
            HasMany(x => x.Products).KeyColumn("ProdCt_Id").Inverse();
        }
    }
}
