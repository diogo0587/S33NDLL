using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ImportOrderServiceFileMap : ClassMap<ImportOrderServiceFile>
    {
        public ImportOrderServiceFileMap()
        {
            Table("StarW_ImportOrderServiceFile");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("ImpOsF_Id");
            Map(x => x.Response).Column("ImpOsF_Response");
            Map(x => x.FileName).Column("ImpOsF_FileName");
            Map(x => x.BytesReceived).Column("ImpOsF_BytesReceived");
            Map(x => x.TotalOrderServices).Column("ImpOsF_TotalOrderServices");
            Map(x => x.LastUpdate).Column("ImpOsF_LastUpdate");
            References(x => x.Operation).Column("Oper_Id");
            References(x => x.Account).Column("Acct_Id");
            References(x => x.RecordStatus).Column("RecSt_Id");
            HasMany(x => x.ImportOrderServiceFileDetails).KeyColumn("ImpOsF_Id").Inverse();           
        }
    }
}
