using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class QuestionTypeMap : ClassMap<QuestionType>
    {
        public QuestionTypeMap()
        {
            Table("StarW_QuestionType");
            LazyLoad();
            Id(c => c.Id).Column("QuestT_Id").GeneratedBy.Identity();
            Map(c => c.Description).Column("QuestT_Description");
            Map(c => c.Name).Column("QuestT_Name");
            Map(c => c.Scan).Column("QuestT_Scan");
            HasMany(x => x.Questions).KeyColumn("QuestT_Id").Inverse();
        }
    }
}
