using System.Web.Mvc;
using MentorStore.BL;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace MentorStore.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType(typeof(IMainLogic<>), typeof(MainLogic<>));
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            var productContainer = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            productContainer.RegisterType(typeof(IProductLogic), typeof(ProductLogic));

            DependencyResolver.SetResolver(new UnityDependencyResolver(productContainer));


            var categoryContainer = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            categoryContainer.RegisterType(typeof(ICategoryLogic), typeof(CategoryLogic));

            DependencyResolver.SetResolver(new UnityDependencyResolver(categoryContainer));
        }
    }
}