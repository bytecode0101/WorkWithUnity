using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;

namespace UnitySample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer();
            //container.RegisterType<IStrategy, StrategyOne>();
            //container.RegisterType<IStrategy, StrategyTwo>();
            //container.RegisterType<Game, Game>();

            IUnityContainer container = new UnityContainer().LoadConfiguration();

            Game game = container.Resolve<Game>();
            game.DoSomething();
            Console.ReadLine();
        }
    }
}
