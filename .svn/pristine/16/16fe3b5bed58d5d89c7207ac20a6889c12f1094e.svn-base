using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class MessageTypeMap : ClassMap<MessageType>
    {
        public MessageTypeMap()
        {
            Table("StarW_MessageType");
            LazyLoad();
            Id(x => x.Id).Column("MsgTp_Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("MsgTp_Name");
            Map(x => x.Description).Column("MsgTp_Description");
            HasMany(x => x.Sockettrackings).KeyColumn("MsgTp_Id").Inverse();
        }
    }
}
