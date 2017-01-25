[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Laoshi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Laoshi.App_Start.NinjectWebCommon), "Stop")]

namespace Laoshi.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    using Laoshi.Domain;
    using System.Reflection;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                kernel.Load(Assembly.GetExecutingAssembly());
                kernel.Load("Laoshi.Domain");
                kernel.Load("Laoshi.Data");
                kernel.Load("Laoshi.Services");


                kernel.Bind<Laoshi.Domain.Interfaces.IRepositoryFactory>().To<Laoshi.Data.Repository.RepositoryFactory>();
                kernel.Bind<Laoshi.Domain.Interfaces.IServiceFactory>().To<Laoshi.Services.ServiceFactory>();
                kernel.Bind<Laoshi.Domain.Interfaces.IConfiguration>().To<Laoshi.Domain.Common.WebConfiguration>();


                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
        }
    }
}
