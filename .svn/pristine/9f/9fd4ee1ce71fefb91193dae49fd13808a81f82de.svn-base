using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceWorkflowProductMap : ClassMap<OrderServiceWorkflowProduct>
    {
        public OrderServiceWorkflowProductMap()
        {
            Table("StarW_OrderServiceWorkflowXProduct");
            LazyLoad();
            Id(x => x.Id).Column("OrdSWP_Id").GeneratedBy.Identity();
            References(x => x.Product).Column("Prod_Id");
            HasMany(x => x.OrderServiceWorkflowProductComponents).KeyColumn("OrdSWP_Id").Inverse();
        }
    }
}
