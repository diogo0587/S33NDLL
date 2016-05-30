using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AlternativeMap : ClassMap<Alternative>
    {
        public AlternativeMap()
        {
            Table("StarW_Alternatives");
            LazyLoad();
            Id(x => x.Id).Column("Alt_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("Alt_Description");
            Map(x => x.Enable).Column("Alt_Enable");
            Map(x => x.IsJustify).Column("Alt_IsJustify");
            Map(x => x.JustifyText).Column("Alt_JustifyText");
            Map(x => x.Sequence).Column("Alt_Sequence");
            Map(x => x.Required).Column("Alt_Required");
            Map(x => x.FromTo).Column("Alt_FromTo");
            References(x => x.Question).Column("Quest_Id");
            References(x => x.ServiceWorkflowConfiguration).Column("WflwCfg_Id");
            HasMany(x => x.ScanAuditingDetails).KeyColumn("Alt_Id").Inverse();
            HasMany(x => x.ScanAuditingDetailTrackings).KeyColumn("Alt_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflowQuestionResponses).KeyColumn("Alt_Id").Inverse();

        }
    }
}
