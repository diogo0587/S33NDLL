using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class OperationServiceTypeMap : ClassMap<OperationServiceType>
    {
        public OperationServiceTypeMap()
        {
            Table("StarW_OperXServTp");
            Id(m => m.Id).Column("OpSTp_Id").GeneratedBy.Identity();
            References(x => x.ServiceType).Column("SerT_Id");
            HasMany(x => x.ServiceTypeOrderServiceTypes).KeyColumn("OpSTp_Id").Inverse();
        }
    }
}
