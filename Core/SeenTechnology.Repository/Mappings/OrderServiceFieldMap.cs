using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OrderServiceFieldMap : ClassMap<OrderServiceField>
    {
        public OrderServiceFieldMap()
        {
            Table("StarW_OrderServiceFields");
            Id(x => x.Id).Column("OrdSFd_ID").GeneratedBy.Identity();
            Map(x => x.Name).Column("OrdSFd_Name");
            Map(x => x.Enable).Column("OrdSFd_Enable");
            Map(x => x.Size).Column("OrdSFd_Size");
            Map(x => x.Description).Column("OrdSFd_Description");
            Map(x => x.Required).Column("OrdSFd_Required");
            Map(x => x.CreationDate).Column("OrdSFd_CreationDate");
        }
    }
}
