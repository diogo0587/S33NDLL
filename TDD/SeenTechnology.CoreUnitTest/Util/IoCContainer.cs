using StructureMap;

namespace SeenTechnology.CoreUnitTest.Util
{
    public static class IoCContainer
    {
        private static readonly IContainer Container;

        static IoCContainer()
        {
            Container = ConfigureDependencies();
        }
        private static IContainer ConfigureDependencies()
        {
            return new Container(registry =>
            {
                registry.Scan(scan =>
                {
                    scan.Assembly("SeenTechnology.Domain");
                    scan.Assembly("SeenTechnology.Repository");
                    scan.LookForRegistries();
                });
            });
        }
        public static T Get<T>()
        {
            return Container.GetNestedContainer().GetInstance<T>();
        }
    }
}
