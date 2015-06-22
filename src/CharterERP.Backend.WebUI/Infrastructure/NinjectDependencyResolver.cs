using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using System.Web;
using System.Web.Mvc;
using CharterERP.Backend.Repository;
using CharterERP.Backend.Domain.Entities;


namespace CharterERP.Backend.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //put bindings here
            Mock<IProductRepository> mock = new Mock<IProductRepository>();

            //mock.Setup(m => m.Products).Returns(new List<Product>
            //    {
            //        new Product {Name = "Football", Price = 25},
            //        new Product {Name = "Surf Board", Price = 179},
            //        new Product {Name = "Running Shoes", Price = 95}
            //    });

            //mock repository
            //kernel.Bind<IProductsRepository>().ToConstant(mock.Object); 

            kernel.Bind<IProductRepository>().To<ProductRepository>();
         
           

        }
    }
}