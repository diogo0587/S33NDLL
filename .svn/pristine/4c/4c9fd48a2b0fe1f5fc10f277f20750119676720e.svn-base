using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ProductComponentMap : ClassMap<ProductComponent>
    {
        public ProductComponentMap()
        {
            Table("StarW_ProductComponent");
            LazyLoad();
            Id(m => m.Id).Column("ProdC_Id").GeneratedBy.Identity();
            References(x => x.Component).Column("Comp_Id");
            References(x => x.Product).Column("Prod_Id");
        }
    }
}
