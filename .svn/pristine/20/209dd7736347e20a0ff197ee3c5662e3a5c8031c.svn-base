using FluentNHibernate.Mapping;
using SeenTechnology.Repository.Infrastructure.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class AuditLogEntryFieldMap : ClassMap<AuditLogEntryField>
    {
        public AuditLogEntryFieldMap()
        {
            Table("StarW_AuditLogEntryField");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("AudLogEF_Id");
            Map(x => x.FieldName).Column("AudLogEF_FieldName");
            Map(x => x.OldValue).Column("AudLogEF_OldValue").CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.NewValue).Column("AudLogEF_NewValue").CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.HasChanges).Column("AudLogEF_HasChanges");
            References(x => x.AuditLogEntry).Column("AudLogE_Id");
        }
    }
}
