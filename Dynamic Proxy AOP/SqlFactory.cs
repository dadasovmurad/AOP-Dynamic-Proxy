using System;

namespace Dynamic_Proxy_AOP
{
    public class SqlFactory : ISqlFactory
    {
        [MyCustomeAspect]
        public void Add()
        {
            Console.WriteLine("Data successfully added !");
        }
    }
}
