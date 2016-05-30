using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ServiceLayoutDetailMap : ClassMap<ServiceLayoutDetail>
    {
        public ServiceLayoutDetailMap()
        {
            Table("StarW_ServiceLayoutDetail");
            LazyLoad();
            Id(m => m.Id).Column("SerLD_Id").GeneratedBy.Identity();
            Map(m => m.FieldName).Column("SerLD_FieldName");
            Map(m => m.FieldType).Column("SerLD_FieldType");
            Map(m => m.ShowGrid).Column("SerLD_ShowGrid");
            Map(m => m.Description).Column("SerLD_Description");
            Map(m => m.Sequence).Column("SerLD_Sequence");
            Map(m => m.GridColumn).Column("SerLD_GridColumn");
            Map(m => m.Enable).Column("SerLD_Enable");
            References(m => m.LayoutParameter).Column("LayParam_Id");
            HasMany(x => x.OrderServiceLayouts).KeyColumn("SerLD_Id").Inverse();
        }
    }
}
