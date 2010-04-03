using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;

namespace ControllerFactories
{
        public class MyNinjectControllerFactory : DefaultControllerFactory
        {
            private IKernel _kernel;

            public MyNinjectControllerFactory(IKernel kernel)
            {
                _kernel = kernel;
            }

            protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
            {
				return _kernel.Get(controllerType) as IController;
            }
        }
}