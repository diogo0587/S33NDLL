using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class BiorecycleTemplateMap : ClassMap<BiorecycleTemplate>
    {
        public BiorecycleTemplateMap()
        {
            Table("StarW_BiorecycleTemplate");
            LazyLoad();
            Id(m => m.Id).Column("BcyTp_Id").GeneratedBy.Identity();
            Map(m => m.Filename).Column("BcyTp_FileName");
            Map(m => m.Enable).Column("BcyTp_Enable");
            Map(m => m.Download).Column("BcyTp_Download");
            Map(m => m.Confirm).Column("BcyTp_Confirm");
            References(m => m.Technician).Column("Tech_Id");
            References(m => m.MobileDevice).Column("MobD_Id");
        }
    }
}
