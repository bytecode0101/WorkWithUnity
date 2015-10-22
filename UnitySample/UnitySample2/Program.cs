using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using UWar;

namespace UnitySample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer();

            //container.RegisterType<IAttackStrategy, BowAttakStrategy>();

            //< alias alias = "IAttackStrategy" type = "UWar.SwordAttakStrategy, UWar" />
            //container.RegisterType<IAttackStrategy, SwordAttakStrategy>();

            //container.RegisterType<IUnit, Unit>();

            //IUnit unit1 = container.Resolve<Unit>();

            IUnityContainer container = new UnityContainer().LoadConfiguration();

            IUnit unit1 = container.Resolve<IUnit>("FirstUnit");
            unit1.Attack();
            Console.ReadLine();
        }
    }
}
