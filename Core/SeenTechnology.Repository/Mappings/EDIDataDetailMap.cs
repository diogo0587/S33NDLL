using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class EDIDataDetailMap : ClassMap<EDIDataDetail>
    {
        public EDIDataDetailMap()
        {
            Table("StarW_EDIDataDetail");
            LazyLoad();
            Id(x => x.Id).Column("EdiD_ID").GeneratedBy.Identity();
            Map(x => x.Name).Column("EdiD_Name");
            Map(x => x.StartPoisition).Column("EdiD_StartPosition");
            Map(x => x.Enable).Column("EdiD_Enable");
            Map(x => x.Size).Column("EdiD_Size");
            Map(x => x.DecimalPlaces).Column("EdiD_DecimalPlaces");
            Map(x => x.Required).Column("EdiD_Required");
            Map(x => x.Description).Column("EdiD_Description");
            References(x => x.EDIDataType).Column("EdiTp_Id");
            References(x => x.OrderServiceField).Column("OrdSFd_ID");
            References(x => x.EDIData).Column("Edi_ID");
        }
    }
}
