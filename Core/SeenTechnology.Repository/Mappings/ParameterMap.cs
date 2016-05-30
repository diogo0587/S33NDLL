using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ParameterMap : ClassMap<Parameter>
    {
        public ParameterMap()
        {
            Table("StarW_Parameter");
            LazyLoad();
            Id(x => x.Id).Column("Param_Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("Param_Name");
            Map(x => x.Value).Column("Param_Value");
            Map(x => x.Description).Column("Param_Description");
        }
    }
}
