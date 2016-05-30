using NHibernate;
using SeenTechnology.Domain.Interfaces;
using SeenTechnology.Repository.Infrastructure;
using StructureMap;

namespace SeenTechnology.Repository.IoCModule
{
    public class ModuleRegistry : Registry
    {
        public ModuleRegistry()
        {
            For<ISession>().Use(c => NHibernateSessionFactory.Instace.CurrentSessionFactory.OpenSession());
            For<IStatelessSession>().Use(c => NHibernateSessionFactory.Instace.CurrentSessionFactory.OpenStatelessSession());
            For<IRepository>().Use<Repository>();
            For<IUnitOfWork>().Use<UnitOfWork>();            
        }
    }
}
