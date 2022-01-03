using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionContainer
{
    class Program
    {
        public static void Main()
        {
            var config = new DependenciesConfiguration();
            config.Register<IA, A>(LifeCycle.Singleton);
            config.Register<IB, B>(LifeCycle.Singleton);

            var dp = new DependencyProvider(config);

            IA a = dp.Resolve<IA>();
        }
    }

    public interface IA
    {

    }
    public interface IB
    {

    }
    public class A : IA
    {
        public IB b;
      
    }

    public class B :IB
    {
        public IA a;
        
    }
}
