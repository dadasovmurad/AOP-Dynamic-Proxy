using Dynamic_Proxy_AOP.Abstract;
using Dynamic_Proxy_AOP.Aspects.Autofac.Custom;
using System;

namespace Dynamic_Proxy_AOP.Concrete
{
    public class SqlFactory : ISqlFactory
    {
        [MyCustomAspect]
        public void Add()
        {
            Console.WriteLine("Data successfully added !");
        }
    }
}
