using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class UiConfigurationMobileMap : ClassMap<UiConfigurationMobile>
    {
        public UiConfigurationMobileMap()
        {
            Table("StarW_UIConfigurationMobile");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("UiCfg_Id");
            References(x => x.Operation).Column("Oper_Id");
            Map(x => x.Name).Column("UiCfg_Name");
            Map(x => x.Type).Column("UiCfg_Type");
            Map(x => x.Label).Column("UiCfg_Label");
            Map(x => x.Visible).Column("UiCfg_Visible");
        }
    }
}
