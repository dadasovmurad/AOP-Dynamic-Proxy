using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.DependencyResolvers.Autofac;
using Castle.DynamicProxy;
using Dynamic_Proxy_AOP.Abstract;
using Dynamic_Proxy_AOP.Concrete;
using Dynamic_Proxy_AOP.Interceptors;
using System;

namespace Dynamic_Proxy_AOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacBusinessModule());

            var container = builder.Build();
            var willBeIntercepted = container.Resolve<ISqlFactory>();
            willBeIntercepted.Add();
        }
    }
}
