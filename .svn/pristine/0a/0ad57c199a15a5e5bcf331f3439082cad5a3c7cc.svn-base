using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Table("StarW_Customer");
            LazyLoad();
            Id(x => x.Id).Column("Cust_Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("Cust_Name");
        }
    }
}
