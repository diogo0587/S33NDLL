using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class RequestTrackingMap : ClassMap<RequestTracking>
    {
        public RequestTrackingMap()
        {
            Table("StarW_RequestTracking");
            LazyLoad();
            Id(m => m.Id).Column("ReqT_Id").GeneratedBy.Identity();
            Map(m => m.Method).Column("ReqT_Method");
            Map(m => m.Quantity).Column("ReqT_Qt");
            Map(m => m.Protocol).Column("ReqT_Protocol");
            Map(m => m.Error).Column("ReqT_Error");
            Map(m => m.TimeStart).Column("ReqT_TmStart");
            Map(m => m.TimeEnd).Column("ReqT_TmTerm");
            References(x => x.RecordStatus).Column("RecSt_Id");
            HasMany(x => x.RequestTrackingDetails).KeyColumn("ReqT_Id").Inverse();
            HasMany(x => x.OrderServices).KeyColumn("ReqT_Id").Inverse();
        }

    }
}
