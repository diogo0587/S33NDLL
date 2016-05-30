using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceTypeMap : ClassMap<OrderServiceType>
    {
        public OrderServiceTypeMap()
        {
            Table("StarW_OrderServiceType");
            LazyLoad();
            Id(x => x.Id).Column("OrdST_ID").GeneratedBy.Identity();
            Map(x => x.Description).Column("OrdST_Description");
            Map(x => x.Auxiliary1).Column("OrdST_Auxiliary1");
            Map(x => x.Auxiliary2).Column("OrdST_Auxiliary2");
            Map(x => x.TimeAttendance).Column("OrdST_TimeAttendance");
            References(x => x.Operation).Column("Oper_Id").Cascade.None();
        }
    }
}
