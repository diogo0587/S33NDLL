using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ZipCodeRangeMap : ClassMap<ZipCodeRange>
    {
        public ZipCodeRangeMap()
        {
            Table("StarW_ZipCodeRange");
            LazyLoad();
            Id(x => x.Id).Column("ZipCR_Id").GeneratedBy.Identity();
            Map(x => x.RangeStart).Column("ZipCR_Start");
            Map(x => x.RangeEnd).Column("ZipCR_End");
            HasMany(x => x.ZipCodeRangeStartPointOperations).KeyColumn("ZipCR_Id").Inverse();
        }
    }
}
