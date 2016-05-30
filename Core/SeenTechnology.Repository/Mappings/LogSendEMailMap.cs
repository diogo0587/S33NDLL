using FluentNHibernate.Mapping;
using SeenTechnology.Domain.Entities;

namespace SeenTechnology.Repository.Mappings
{
    public class LogSendEMailMap : ClassMap<LogSendEMail>
    {
        public LogSendEMailMap()
        {
            Table("Starw_LogSendEMail");
            LazyLoad();
            Id(m => m.Id).Column("LogSe_Id").GeneratedBy.Identity();
            Map(m => m.Email).Column("LogSe_Email");
            Map(m => m.TemplateEmail).Column("LogSe_TemplateEmail");
            Map(m => m.Status).Column("LogSe_Status");
        }
    }
}
