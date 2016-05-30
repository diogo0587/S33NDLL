using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceScheduleParameterMap : ClassMap<OrderServiceScheduleParameter>
    {
        public OrderServiceScheduleParameterMap()
        {
            Table("StarW_OrderServiceScheduleParameter");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("OsSchP_Id");            
            Map(x => x.Amountagents).Column("OsSchP_AmountAgents");
            Map(x => x.Amountcall).Column("OsSchP_AmountCall");
            Map(x => x.RangeserviceInMinutes).Column("OsSchP_RangeServiceInMinutes");
            Map(x => x.LunchscheduleInMinutes).Column("OsSchP_LunchScheduleInMinutes");
            Map(x => x.StartHourScheduleInMinutes).Column("OsSchP_StartHourScheduleInMinutes");
            Map(x => x.FinalHourScheduleInMinutes).Column("OsSchP_FinalHourScheduleInMinutes");
            Map(x => x.LimitScheduleInMinutes).Column("OsSchP_LimitSchedulerInMinutes");
            References(x => x.StartPointOperation).Column("StpxOp_Id");
        }
    }
}
