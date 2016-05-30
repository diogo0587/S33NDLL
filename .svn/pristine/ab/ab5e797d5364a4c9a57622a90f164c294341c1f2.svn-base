using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class SocketTrackingMap : ClassMap<SocketTracking>
    {
        public SocketTrackingMap()
        {
            Table("StarW_SocketTracking");
            LazyLoad();
            Id(x => x.Id).Column("ScktT_Id").GeneratedBy.Identity();
            Map(x => x.ReceivedContent).Column("ScktT_ReceivedContent");
            Map(x => x.SentContent).Column("ScktT_SentContent");
            Map(x => x.ReceivedBytes).Column("ScktT_ReceivedBytes");
            Map(x => x.SentBytes).Column("ScktT_SentBytes");
            References(x => x.MobileDevice).Column("MobD_Id");
            References(x => x.MessageType).Column("MsgTp_Id");
        }
    }
}
