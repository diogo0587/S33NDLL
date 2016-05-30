using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class QuestionMap : ClassMap<Question>
    {
        public QuestionMap()
        {
            Table("StarW_Question");
            LazyLoad();
            Id(c => c.Id).Column("Quest_Id").GeneratedBy.Identity();
            Map(c => c.Description).Column("Quest_Description");
            Map(c => c.Enable).Column("Quest_Enable");
            Map(c => c.Required).Column("Quest_Required");
            Map(c => c.Sequence).Column("Quest_Sequence");
            References(c => c.QuestionType).Column("QuestT_Id");
            References(c => c.Operation).Column("Oper_Id");
            HasMany(c => c.Alternatives).KeyColumn("Quest_Id").Inverse();
            HasMany(x => x.CustomAlternatives).KeyColumn("Quest_Id").Inverse();
            HasMany(x => x.OrderServiceWorkflowQuestionResponse).KeyColumn("Quest_Id").Inverse();
        }
    }
}
