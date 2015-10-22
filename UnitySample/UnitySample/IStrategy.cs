using System;

namespace UnitySample
{
    public interface IStrategy
    {
        void DoSomething();
    }

    public class StrategyOne : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("Strategy one");
        }
    }

    public class StrategyTwo : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("Strategy two");
        }
    }
}
