using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceCustomerMap : ClassMap<OrderServiceCustomer>
    {
        public OrderServiceCustomerMap()
        {
            Table("StarW_OrderServiceCustomer");
            LazyLoad();
            Id(x => x.Id).Column("OrdSC_Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("OrdSC_Name");
            Map(x => x.CPF).Column("OrdSC_CPF");
            Map(x => x.RG).Column("OrdSC_RG");
            Map(x => x.Email).Column("OrdSC_Email");
            Map(x => x.Gender).Column("OrdSC_Gender");
            Map(x => x.Phone).Column("OrdSC_Phone");
            Map(x => x.CellPhone).Column("OrdSC_CellPhone");
            Map(x => x.Income).Column("OrdSC_Income");
            Map(x => x.IncomeType).Column("OrdSC_IncomeType");
            Map(x => x.DateRegister).Column("OrdSC_DateRegister");
            References(x => x.OrderService).Column("OrdS_Id");
        }
    }
}
