using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class LayoutParameterMap : ClassMap<LayoutParameter>
    {
        public LayoutParameterMap()
        {
            Table("StarW_LayoutParameter");
            LazyLoad();
            Id(c => c.Id).Column("LayParam_Id").GeneratedBy.Identity();
            Map(c => c.Name).Column("LayParam_Name");
            Map(c => c.NameView).Column("LayParam_NameView");
            HasMany(x => x.ServiceLayoutDetails).KeyColumn("LayParam_Id").Inverse();
        }
    }
}
