using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Dynamic_Proxy_AOP.Abstract;
using Dynamic_Proxy_AOP.Concrete;
using Dynamic_Proxy_AOP.Interceptors;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SqlFactory>().As<ISqlFactory>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
