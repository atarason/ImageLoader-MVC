using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using ImageLoader.DAL.Abstraction.UnitOfWork;
using ImageLoader.DAL.Concrete.UnitOfWork;
using ImageLoader.Model.Abstraction;
using ImageLoader.Model.Contexts;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace ImageLoader.IoC
{
    /// <summary>
    ///
    /// </summary>
    public class Startup
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="config"></param>
        /// <param name="assemblies"></param>
        public void Configuration(HttpConfiguration config, Assembly[] assemblies)
        {
            // Create a module of ioc
            var builder = new ContainerBuilder();

            var controllerAssemblies = assemblies;
            builder.RegisterApiControllers(controllerAssemblies).InstancePerDependency();
            builder.RegisterControllers(controllerAssemblies).InstancePerDependency();

            // Registration of module

            builder.RegisterType<DBUnitOfWork>().As<IUnitOfWork>().InstancePerDependency();
            builder.RegisterType<ImageLoaderContext>().As<IImageLoaderContext>().InstancePerDependency();

            var container = builder.Build();

            var resolver = new AutofacWebApiDependencyResolver(container);
            config.DependencyResolver = resolver;

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}