using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using System;

namespace Dynamic_Proxy_AOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SqlFactory>().As<ISqlFactory>()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions
                {
                    Selector = new AspectInterceptorSelector()
                })
                .InstancePerDependency();

            var container = builder.Build();
            var willBeIntercepted = container.Resolve<ISqlFactory>();
            willBeIntercepted.Add();
        }
    }
}
