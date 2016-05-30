using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ImportOrderServiceFileDetailMap : ClassMap<ImportOrderServiceFileDetail>
    {
        public ImportOrderServiceFileDetailMap()
        {
            Table("StarW_ImportOrderServiceFileDetail");
            LazyLoad();
            Id(x => x.Id).Column("ImpOsFD_Id").GeneratedBy.Identity();
            References(x => x.ImportOrderService).Column("ImpOs_Id");
            References(x => x.ImportOrderServiceFile).Column("ImpOsF_Id");
        }
    }
}
