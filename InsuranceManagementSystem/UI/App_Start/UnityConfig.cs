using System.Data.Entity.Core.Metadata.Edm;
using System.Web.Mvc;
using DAL.Data;
using DAL.Repository;
using Unity;
using Unity.AspNet.Mvc;

namespace UI
{
    public static class UnityConfig
    {
        public static IUnityContainer Container { get; internal set; }

        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IAdminRepository, AdminRepository>();

            container.RegisterType<ICustomerRepository, CustomerRepository>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            Container=container;
            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}