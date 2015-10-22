using System;

namespace UWar
{
    public interface IAttackStrategy
    {
        void Attack();
    }

    public class SwordAttakStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Sword attak");
        }
    }

    public class BowAttakStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Bow attak");
        }
    }
}