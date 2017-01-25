using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace Laoshi.WCF
{
    public class NinjectInstanceProvider : IInstanceProvider
    {
        private Type serviceType;
        private IKernel kernel;

        public NinjectInstanceProvider(IKernel kernel, Type serviceType)
        {
            this.kernel = kernel;
            this.serviceType = serviceType;
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return this.GetInstance(instanceContext, null);
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            kernel.Load(Assembly.GetExecutingAssembly());
            kernel.Load("Laoshi.Domain");
            kernel.Load("Laoshi.Data");
            kernel.Load("Laoshi.Services");


            kernel.Bind<Laoshi.Domain.Interfaces.IRepositoryFactory>().To<Laoshi.Data.Repository.RepositoryFactory>();
            kernel.Bind<Laoshi.Domain.Interfaces.IServiceFactory>().To<Laoshi.Services.ServiceFactory>();
            kernel.Bind<Laoshi.Domain.Interfaces.IConfiguration>().To<Laoshi.Domain.Common.WebConfiguration>();
            // Create the instance with your IoC container of choice, here I use Ninject.
            return kernel.Get(this.serviceType);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
        }
    }
}