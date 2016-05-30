using FluentNHibernate.Mapping;
using SeenTechnology.Repository.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeenTechnology.Repository.Mappings
{
    public class AuditLogEntryMap : ClassMap<AuditLogEntry>
    {
        public AuditLogEntryMap()
        {
            Table("StarW_AuditLogEntry");
            LazyLoad();
            Id(x => x.Id).Column("AudLogE_Id").GeneratedBy.Identity().Not.Nullable();
            Map(x => x.DbSessionId).Column("AudLogE_DbSessionId");
            Map(x => x.DbTransactionId).Column("AudLogE_DbTransactionId");
            Map(x => x.UserSession).Column("AudLogE_UserSession");
            Map(x => x.UserId).Column("AudLogE_UserId");
            Map(x => x.UserName).Column("AudLogE_UserName");
            Map(x => x.AuditEntryType).Column("AudLogE_AuditEntryType");
            Map(x => x.EntityId).Column("AudLogE_EntityId");
            Map(x => x.EntityFullName).Column("AudLogE_EntityFullName");
            Map(x => x.EntityShortName).Column("AudLogE_EntityShortName");
            Map(x => x.CreationDate).Column("AudLogE_CreationDate");
            HasMany(x => x.AuditLogEntryFields).KeyColumn("AudLogE_Id").Cascade.SaveUpdate();
        }
    }
}
