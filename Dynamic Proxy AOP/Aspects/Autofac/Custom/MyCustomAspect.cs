using Castle.DynamicProxy;
using Dynamic_Proxy_AOP.Interceptors;
using System;

namespace Dynamic_Proxy_AOP.Aspects.Autofac.Custom
{
    public class MyCustomAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("Befor !");
        }
        public override void OnSuccess(IInvocation invocation)
        {
            Console.WriteLine("Success !");
        }
        public override void OnException(IInvocation invocation, Exception exc)
        {
            Console.WriteLine("Exception !");
        }
        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("After !");
        }
    }
}
