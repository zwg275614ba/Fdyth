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
        /// 获取unity容器
        /// </summary>
        public static IUnityContainer Container { get; set; }
        public static void RegisterComponents()
        {
            Container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            Container.RegisterType<I用户表Service, 用户表Service>();
            Container.RegisterType<I用户表Repository, 用户表Repository>();
            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        public static I用户表Service 用户表Service
        {
            get
            {
                return UnityConfig.Container.Resolve<I用户表Service>();
            }
        }
    }
}