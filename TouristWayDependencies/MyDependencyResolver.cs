using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using CoreInterfaces;
using Data;

namespace TouristWayDependencies
{
   public class MyDependencyResolver:IDependencyResolver
    {
        IUnityContainer container;

        public MyDependencyResolver()
        {
            container = new UnityContainer();
            container.RegisterType<IUnitOfWork, TouristAppUnitOfWork>();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }

            catch
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return container.ResolveAll(serviceType);
            }
            catch
            {
                return null;
            }
        }
    }
}
