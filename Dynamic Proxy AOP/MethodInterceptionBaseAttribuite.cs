using Castle.DynamicProxy;
using System;

namespace Dynamic_Proxy_AOP
{
    public class MethodInterceptionBaseAttribuite : Attribute, IInterceptor
    {
        public int Priority { get; set; }
        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
