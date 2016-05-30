using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class RequestTrackingDetailMap : ClassMap<RequestTrackingDetail>
    {
        public RequestTrackingDetailMap()
        {
            Table("StarW_RequestTrackingDetail");
            LazyLoad();
            Id(m => m.Id).Column("ReqTD_Id").GeneratedBy.Identity();
            Map(m => m.Error).Column("ReqTD_Error");
            References(x => x.RecordStatus).Column("RecSt_Id");
            References(x => x.Route).Column("Rout_Id");
            References(x => x.RequestTracking).Column("ReqT_Id");
        }
    }
}
