using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class GlobalizationResourceMap : ClassMap<GlobalizationResource>
    {
        public GlobalizationResourceMap()
        {
            Table("StarW_GlobalizationResources");
            LazyLoad();
            Id(x => x.Id).Column("GlobRes_Id").GeneratedBy.Identity();
            Map(x => x.ResourceName).Column("GlobRes_ResourceName");
            Map(x => x.ResourceValue).Column("GlobRes_ResourceValue");
            Map(x => x.CultureName).Column("GlobRes_CultureName");
            Map(x => x.OperationId).Column("Oper_Id");
        }
    }
}
