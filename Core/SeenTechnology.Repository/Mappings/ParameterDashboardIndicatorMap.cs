using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ParameterDashboardIndicatorMap : ClassMap<ParameterDashboardIndicator>
    {
        public ParameterDashboardIndicatorMap()
        {
            Table("StarW_ParameterDashboardIndicator");
            Id(x => x.Id).Column("ParDI_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("ParDI_Description");
            Map(x => x.MinValue).Column("ParDI_MinValue");
            Map(x => x.MinColorValue).Column("ParDI_MinColorValue");
            Map(x => x.MaxValue).Column("ParDI_MaxValue");
            Map(x => x.MaxColorValue).Column("ParDI_MaxColorValue");
            Map(x => x.MiddleColorValue).Column("ParDI_MiddleColorValue");
            Map(x => x.LastUpdate).Column("ParDI_LastUpdate");
            References(x => x.Account).Column("Acct_Id");
            References(x => x.Operation).Column("Oper_Id");
        }
    }
}
