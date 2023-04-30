using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Proxy_AOP.Interceptors
{
    public class MethodInterception : MethodInterceptionBaseAttribuite
    {
        public override void Intercept(IInvocation invocation)
        {
            bool success = true;
            try
            {
                OnBefore(invocation);
                invocation.Proceed();
            }
            catch (Exception exc)
            {
                success = false;
                OnException(invocation, exc);
            }
            finally
            {
                if (success)
                    OnSuccess(invocation);
            }
            OnAfter(invocation);
        }
        public virtual void OnBefore(IInvocation invocation) { }
        public virtual void OnAfter(IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation, Exception exc) { }
        public virtual void OnSuccess(IInvocation invocation) { }
    }
}
