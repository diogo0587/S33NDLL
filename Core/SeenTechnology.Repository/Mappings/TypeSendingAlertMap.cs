using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class TypeSendingAlertMap : ClassMap<TypeSendingAlert>
    {
        public TypeSendingAlertMap()
        {
            Table("StarW_TypeSendingAlert");
            LazyLoad();
            Id(c => c.Id).Column("TypSd_Id").GeneratedBy.Identity();
            Map(c => c.Name).Column("TypSd_Name");
            HasMany(x => x.AlertDetails).KeyColumn("TypSd_Id").Inverse();
            HasMany(x => x.AlertTrackings).KeyColumn("TypSd_Id").Inverse();
        }
    }
}
