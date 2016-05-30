using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class SegmentMap : ClassMap<Segment>
    {
        public SegmentMap()
        {
            Table("StarW_Segment");
            Id(x => x.Id).Column("Segm_Id").GeneratedBy.Identity();
            Map(x => x.Description).Column("Segm_Description");
            HasMany(x => x.Operations).KeyColumn("Segm_Id").Inverse();
        }
    }
}
