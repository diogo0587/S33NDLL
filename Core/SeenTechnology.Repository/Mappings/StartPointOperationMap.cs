using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class StartPointOperationMap : ClassMap<StartPointOperation>
    {
        public StartPointOperationMap()
        {
            Table("StarW_StartPointXOper");
            LazyLoad();
            Id(x => x.Id).Column("StpXOp_Id").GeneratedBy.Identity();
            References(x => x.StartPoint).Column("StrP_Id").Cascade.None();
            References(x => x.Operation).Column("Oper_Id").Cascade.None();
            HasMany(x => x.AccountStartPointOperations).KeyColumn("StpxOp_Id").Inverse();
            HasMany(x => x.OrderServices).KeyColumn("StpxOp_Id").Inverse();
            HasMany(x => x.OrderServiceScheduleParameters).KeyColumn("StpxOp_Id").Inverse();
            HasMany(x => x.Routes).KeyColumn("StpxOp_Id").Inverse();
            HasMany(x => x.ZipCodeRangeStartPointOperations).KeyColumn("StpxOp_Id").Inverse();
        }
    }
}
