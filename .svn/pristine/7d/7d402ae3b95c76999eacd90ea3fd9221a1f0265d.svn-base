using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ImportOrderServiceMap : ClassMap<ImportOrderService>
    {
        public ImportOrderServiceMap()
        {
            Table("StarW_ImportOrderService");
            LazyLoad();
            Id(x => x.Id).Column("ImpOs_Id").GeneratedBy.Identity();
            Map(x => x.LastUpdate).Column("ImpOs_LastUpdate");
            Map(x => x.Response).Column("ImpOs_Response");
            Map(x => x.CorporateName).Column("ImpOs_CorporateName");
            Map(x => x.DateTimeScheduling).Column("ImpOs_DateTimeScheduling");
            Map(x => x.ExternalId).Column("ImpOs_ExternalId");
            Map(x => x.PhoneNumber1).Column("ImpOs_PhoneNumber1");
            Map(x => x.PhoneNumber2).Column("ImpOs_PhoneNumber2");
            Map(x => x.Protocol).Column("ImpOs_Protocol");
            Map(x => x.Reference).Column("ImpOs_Reference");
            Map(x => x.WorkDay).Column("ImpOs_WorkDay");
            Map(x => x.City).Column("ImpOs_City");
            Map(x => x.Complement).Column("ImpOs_Complement");
            Map(x => x.Neighborhood).Column("ImpOs_Neighborhood");
            Map(x => x.Number).Column("ImpOs_Number");
            Map(x => x.Street).Column("ImpOs_Street");
            Map(x => x.ZipCode).Column("ImpOs_ZipCode");
            Map(x => x.UF).Column("ImpOs_UF");
            Map(x => x.CustomerReference).Column("ImpOs_CustomerReference");
            Map(x => x.Email).Column("ImpOs_Email");
            References(x => x.Operation).Column("Oper_Id");
            References(x => x.Status).Column("RecSt_Id");
            References(x => x.OrderService).Column("OrdS_Id");
            References(x => x.Account).Column("Acct_Id");
            HasMany(x => x.ImportOrderServiceFileDetail).KeyColumn("ImpOs_Id").Inverse();
        }
    }
}
