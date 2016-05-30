using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class EDIDataMap : ClassMap<EDIData>
    {
        public EDIDataMap()
        {
            Table("StarW_EDIData");
            LazyLoad();
            Id(x => x.Id).Column("Edi_ID").GeneratedBy.Identity();
            Map(x => x.Prefix).Column("Edi_Prefix");
            Map(x => x.Name).Column("Edi_Name");
            Map(x => x.Enable).Column("Edi_Enable");
            HasMany(x => x.EDIDataDetails).KeyColumn("Edi_ID").Inverse();
        }
    }
}
