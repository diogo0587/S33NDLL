using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OperationEventRepiqueMap : ClassMap<OperationEventRepique>
    {
        public OperationEventRepiqueMap()
        {
            Table("StarW_OperationEventRepique");
            LazyLoad();
            Id(x => x.Id).Column("OperER_Id").GeneratedBy.Identity();
            References(x => x.Operation).Column("Oper_Id");
            References(x => x.ServiceEvent).Column("SerE_Id");
        }
    }
}
