using Microsoft.Practices.Unity;

namespace UnitySample
{
    public class Game
    {
        IStrategy myStrategy;
        int age;

        public IStrategy TheStrategy
        {
            get
            {
                return myStrategy;
            }

            set
            {
                myStrategy = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public void DoSomething()
        {
            TheStrategy.DoSomething();
        }
    }
}
