using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class PACTemplateMap : ClassMap<PACTemplate>
    {
        public PACTemplateMap()
        {
            Table("BcoOrg_PACTemplate");
            LazyLoad();
            Id(x => x.Id).Column("PacT_Id").GeneratedBy.Identity();
            Map(x => x.TemplateCode).Column("PacT_TemplateCode");
            Map(x => x.TemplateName).Column("PacT_TemplateName");
            References(x => x.RecordStatus).Column("RecSt_Id");
        }
    }
}
