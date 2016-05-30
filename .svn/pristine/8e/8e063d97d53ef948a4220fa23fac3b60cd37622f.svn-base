using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ContractOperationMap : ClassMap<ContractOperation>
    {
        public ContractOperationMap()
        {
            Table("StarW_ContractXOper");
            LazyLoad();
            Id(x => x.Id).Column("ConOp_Id").GeneratedBy.Identity();
            References(x => x.Operation).Column("Oper_Id");
            HasMany(x => x.OperationServiceTypes).KeyColumn("ConOp_Id").Inverse();
        }
    }
}
