using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class HolidayMap : ClassMap<Holiday>
    {
        public HolidayMap()
        {
            Table("StarW_Holidays");
            LazyLoad();
            Id(x => x.Id).Column("Hol_ID").GeneratedBy.Identity();
            Map(x => x.StartDate).Column("Hol_StartDate");
            Map(x => x.FinalDate).Column("Hol_FinalDate");
            Map(x => x.Description).Column("Hol_Description");
            Map(x => x.Enable).Column("Hol_Enable");
        }
    }
}
