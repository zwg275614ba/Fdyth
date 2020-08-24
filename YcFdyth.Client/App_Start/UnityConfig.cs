using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Yckj.YcFdyth.IRepository.IRepository.Table;
using Yckj.YcFdyth.IService.IService.Table;
using Yckj.YcFdyth.Repository.Repository.Table;
using Yckj.YcFdyth.Service.Service.Table;

namespace YcFdyth.Client
{
    public static class UnityConfig
    {
        /// <summary>
        /// ��ȡunity����
        /// </summary>
        public static IUnityContainer Container { get; set; }
        public static void RegisterComponents()
        {
            Container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            Container.RegisterType<I�û���Service, �û���Service>();
            Container.RegisterType<I�û���Repository, �û���Repository>();
            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        public static I�û���Service �û���Service
        {
            get
            {
                return UnityConfig.Container.Resolve<I�û���Service>();
            }
        }
    }
}