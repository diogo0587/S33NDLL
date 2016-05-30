using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class TypePersonMap : ClassMap<TypePerson>
    {
        public TypePersonMap()
        {
            Table("StarW_TypePerson");
            LazyLoad();
            Id(x => x.Id).Column("Tp_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("Tp_Description");
            References(x => x.OrderServiceType).Column("OrdST_ID");
        }
    }
}
