using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class DocumentMap : ClassMap<Document>
    {
        public DocumentMap()
        {
            Table("StarW_Document");
            LazyLoad();
            Id(x => x.Id).Column("Doc_Id").GeneratedBy.Identity();
            Map(x => x.FileName).Column("Doc_FileName");
            Map(x => x.LastUpdated).Column("Doc_LastUpdated");
            Map(x => x.Enable).Column("Doc_Enable");
        }
    }
}
