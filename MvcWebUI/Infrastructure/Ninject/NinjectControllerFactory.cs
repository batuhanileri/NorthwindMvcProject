using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Ninject;
using NorthwindInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace MvcWebUI.Infrastructure.Ninject
{
    //Dependency Injection
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        //Manage NuGet Packages added ninject
        //Hangi interface'i çağırıcaksak bağımlı olucağı dal,manager getirir. Injection yapıyoruz..
        //Kernel Ninjectin alt mekanizması..
        //Constructorları set ettiğimiz zaman arka planda yorumlamaya yarayan framework
        //Dependency Container 
        IKernel _ninjectKernel;
        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            AddBllBindings();
        }

        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal", new EfProductDal());//IProductService istenen yerde ProductManagere erişmesini sağla onu ver

            _ninjectKernel.Bind<ICategoryService>().To<CategoryManager>().WithConstructorArgument("categoryDal", new EfCategoryDal());
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
        }
    }
}