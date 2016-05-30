using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ContractServiceMap : ClassMap<ContractService>
    {
        public ContractServiceMap()
        {
            Table("StarW_ContractService");
            LazyLoad();
            Id(m => m.Id).Column("ConS_ID").GeneratedBy.Identity();
            Map(m => m.Description).Column("ConS_Description");
            Map(m => m.Expiration).Column("ConS_Expiration");
            Map(m => m.Auxiliary1).Column("ConS_Auxiliary1");
            Map(m => m.Auxiliary2).Column("ConS_Auxiliary2");
            Map(m => m.Auxiliary3).Column("ConS_Auxiliary3");
            Map(m => m.Auxiliary4).Column("ConS_Auxiliary4");
            Map(m => m.Auxiliary5).Column("ConS_Auxiliary5");
            References(x => x.Customer).Column("Cust_ID");
            HasMany(x => x.ContractOperations).KeyColumn("ConS_ID").Inverse();
        }
    }
}
