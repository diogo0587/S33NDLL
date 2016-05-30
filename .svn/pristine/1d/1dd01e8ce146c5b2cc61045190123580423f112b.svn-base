using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class EDIDataTypeMap : ClassMap<EDIDataType>
    {
        public EDIDataTypeMap()
        {
            Table("StarW_EDIDataType");
            LazyLoad();
            Id(x => x.Id).Column("EdiTp_Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("EdiTp_Name");
            HasMany(x => x.EDIDataDetails).KeyColumn("EdiTp_Id").Inverse();
        }
    }
}
