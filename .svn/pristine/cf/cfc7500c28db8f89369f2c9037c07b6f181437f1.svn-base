using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class SendWorkflowToCustomerMap : ClassMap<SendWorkflowToCustomer>
    {
        public SendWorkflowToCustomerMap()
        {
            Table("StarW_SendWorkflowToCustomer");
            LazyLoad();
            Id(x => x.Id).Column("SdWC_Id").GeneratedBy.Identity();
            Map(x => x.LastUpdate).Column("SdWC_LastUpdate");
            Map(x => x.Attempts).Column("SdWC_Attempts");
            Map(x => x.Response).Column("SdWC_Response");
            References(x => x.Operation).Column("Oper_Id");
            References(x => x.OrderServiceAttendance).Column("OsAttd_Id");
            References(x => x.RecordStatus).Column("RecSt_Id");
        }
    }
}
