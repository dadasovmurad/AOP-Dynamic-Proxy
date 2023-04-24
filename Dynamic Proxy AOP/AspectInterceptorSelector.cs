using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Proxy_AOP
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttrs = type.GetCustomAttributes<MethodInterceptionBaseAttribuite>(true).ToList();
            var methodAttrs = type.GetMethod(method.Name)?.GetCustomAttributes<MethodInterceptionBaseAttribuite>(true);

            if (methodAttrs != null)
            {
                classAttrs.AddRange(methodAttrs);
            }
            return classAttrs.OrderBy(x => x.Priority).ToArray();
        }
    }
}
