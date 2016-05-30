using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class ZipCodeRangeStartPointOperationMap : ClassMap<ZipCodeRangeStartPointOperation>
    {
        public ZipCodeRangeStartPointOperationMap()
        {
            Table("StarW_ZipCodeRangeXStartPointXOperation");
            LazyLoad();
            Id(x => x.Id).Column("ZpStOp_Id").GeneratedBy.Identity();
            References(x => x.ZipCodeRange).Column("ZipCR_Id");
        }
    }
}
