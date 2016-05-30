using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AlertOperationMap : ClassMap<AlertOperation>
    {
        public AlertOperationMap()
        {
            Table("StarW_AlertOperation");
            Id(x => x.Id).Column("AlrtOp_Id").GeneratedBy.Identity();
            References(x => x.Alert).Column("Alrt_Id");
            References(x => x.Operation).Column("Oper_Id");
        }
    }
}
