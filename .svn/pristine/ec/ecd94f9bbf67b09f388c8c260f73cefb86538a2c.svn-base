using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AlertDetailMap : ClassMap<AlertDetail>
    {
        public AlertDetailMap()
        {
            Table("StarW_AlertDetail");
            LazyLoad();
            Id(x => x.Id).Column("AlrtD_Id").GeneratedBy.Identity();
            Map(x => x.Enable).Column("AlrtD_Enable");
            Map(x => x.Message).Column("AlrtD_Message");
            References(x => x.TypeSendingAlert).Column("TypSd_Id");
        }
    }
}
