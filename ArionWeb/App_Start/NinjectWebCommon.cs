[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ArionWeb.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ArionWeb.App_Start.NinjectWebCommon), "Stop")]

namespace ArionWeb.App_Start
{
    using System;
    using System.Data.Entity;
    using System.Web;
    using MappingAndBinding.ArionWebDbContext;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Models;
    using Ninject;
    using Ninject.Web.Common;
    using Repositories.Implemantations;
    using Repositories.Interfaces;
    using Repositories.UnitOfWork;
    using Services.BaseService;

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
            //db context
            kernel.Bind<DbContext>().To<ArionWebDbContext>();
            //unitOfWork
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            //repositories
            kernel.Bind<IRepository<Coefficient>>().To<Repository<Coefficient>>();
            kernel.Bind<IRepository<Description>>().To<Repository<Description>>();
            kernel.Bind<IRepository<ElementClass>>().To<Repository<ElementClass>>();
            kernel.Bind<IRepository<ElementGroup>>().To<Repository<ElementGroup>>();
            kernel.Bind<IRepository<Key>>().To<Repository<Key>>();
            kernel.Bind<IRepository<Model>>().To<Repository<Model>>();
            kernel.Bind<IRepository<Position>>().To<Repository<Position>>();
            kernel.Bind<IRepository<Property>>().To<Repository<Property>>();
            //services
            kernel.Bind<IClassifierService<Coefficient>>().To<ClassifierService<Coefficient>>();
            kernel.Bind<IClassifierService<Description>>().To<ClassifierService<Description>>();
            kernel.Bind<IClassifierService<ElementClass>>().To<ClassifierService<ElementClass>>();
            kernel.Bind<IClassifierService<ElementGroup>>().To<ClassifierService<ElementGroup>>();
            kernel.Bind<IClassifierService<Key>>().To<ClassifierService<Key>>();
            kernel.Bind<IClassifierService<Model>>().To<ClassifierService<Model>>();
            kernel.Bind<IClassifierService<Position>>().To<ClassifierService<Position>>();
            kernel.Bind<IClassifierService<Property>>().To<ClassifierService<Property>>();
        }        
    }
}
