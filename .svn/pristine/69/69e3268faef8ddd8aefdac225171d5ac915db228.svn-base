using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceWorkflowQuestionResponseMap : ClassMap<OrderServiceWorkflowQuestionResponse>
    {
        public OrderServiceWorkflowQuestionResponseMap()
        {
            Table("StarW_OrderServiceWorkflowQuestionResponse");
            LazyLoad();
            Id(x => x.Id).Column("OrdSWQR_Id").GeneratedBy.Identity();
            Map(x => x.Response).Column("OrdSWQR_Text");
            References(x => x.Technician).Column("Tech_Id");
            References(x => x.Question).Column("Quest_Id");
            References(x => x.Alternative).Column("Alt_Id");
            References(x => x.CustomAlternative).Column("CstAlt_Id");
            References(x => x.SecondaryOrderServiceWorkflow).Column("OrdSWC_Id");
        }
    }
}
