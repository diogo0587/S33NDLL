using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class QuestionnarieMap : ClassMap<Questionnarie>
    {
        public QuestionnarieMap()
        {
            Table("StarW_Questionnarie");
            LazyLoad();
            Id(x => x.Id).Column("Qstn_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("Qstn_Description");
            Map(x => x.Enable).Column("Qstn_Enable");
            References(x => x.Operation).Column("Oper_Id");
            HasMany(x => x.Questions).KeyColumn("Qstn_Id").Inverse();
            HasMany(x => x.ServiceWorkflowConfigurationQuestionnarie).KeyColumn("Qstn_Id").Inverse();
        }
    }
}
