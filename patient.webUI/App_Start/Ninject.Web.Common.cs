[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(patient.webUI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(patient.webUI.App_Start.NinjectWebCommon), "Stop")]

namespace patient.webUI.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Moq;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using smartPatient.Domain.Abstract;
    using smartPatient.Domain.entities;

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

            Mock<iproductrepository> mock= new Mock<iproductrepository>();
            mock.Setup(m => m.products).Returns(new List<product>
            {
                new product{Name= "DR Baseer", fee = 23, speciality="gynocholigist"},
                new product{Name= "DR Kazim", fee = 87, speciality="Ortopedics"},
                new product{Name= "DR Base", fee = 27, speciality="Eye surgeon"},
                new product{Name= "DR kareem", fee = 289},


            });
            kernel.Bind<iproductrepository>().ToConstant(mock.Object);
        }

       
    }
}