using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class CustomAlternativeMap : ClassMap<CustomAlternative>
    {
        public CustomAlternativeMap()
        {
            Table("StarW_CustomAlternatives");
            LazyLoad();
            Id(x => x.Id).Column("CstAlt_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("CstAlt_Description");
            Map(x => x.Enable).Column("CstAlt_Enable");
            Map(x => x.IsJustify).Column("CstAlt_IsJustify");
            Map(x => x.JustifyText).Column("CstAlt_JustifyText");
            Map(x => x.Sequence).Column("CstAlt_Sequence");
            Map(x => x.FromTo).Column("CstAlt_FromTo");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.Question).Column("Quest_Id");
            HasMany(x => x.OrderServiceWorkflowQuestionResponses).KeyColumn("CstAlt_Id").Inverse();
        }
    }
}
