using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace SeenTechnology.Repository.Infrastructure
{
    public sealed class NHibernateSessionFactory
    {
        public ISessionFactory CurrentSessionFactory { get { return _sessionFactory; } }

        private readonly ISessionFactory _sessionFactory;
        private static volatile NHibernateSessionFactory _instance;
        private static readonly object SyncRoot = new object();

        private NHibernateSessionFactory()
        {
            FluentConfiguration fluentConfiguration = Fluently.Configure();

            fluentConfiguration.Database(
                MsSqlConfiguration.MsSql2008.ConnectionString(_ => _.FromConnectionStringWithKey("dbConn"))
                    .FormatSql()
                    .ShowSql());

            fluentConfiguration.ExposeConfiguration(_ => _.SetInterceptor(new SqlStatementInterceptor()));
            fluentConfiguration.ExposeConfiguration(_ => _.SetListener(NHibernate.Event.ListenerType.PostInsert, new AuditUpdateListener()));
            fluentConfiguration.ExposeConfiguration(_ => _.SetListener(NHibernate.Event.ListenerType.PostUpdate, new AuditUpdateListener()));
            fluentConfiguration.ExposeConfiguration(_ => _.SetListener(NHibernate.Event.ListenerType.PostDelete, new AuditUpdateListener()));

            fluentConfiguration.Mappings(_ => _.FluentMappings.AddFromAssembly(typeof(NHibernateSessionFactory).Assembly));
            fluentConfiguration.CurrentSessionContext("managed_web");

            _sessionFactory = fluentConfiguration.BuildSessionFactory();
        }

        public static NHibernateSessionFactory Instace
        {
            get
            {
                if (Equals(_instance, null))
                {
                    lock (SyncRoot)
                    {
                        if (Equals(_instance, null))
                            _instance = new NHibernateSessionFactory();
                    }
                }
                return _instance;
            }
        }
    }
}
