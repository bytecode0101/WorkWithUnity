using System;

namespace UWar
{
    public interface IAttackStrategy
    {
        int HitPoints { get; set; }
        void Attack();
    }

    public class SwordAttakStrategy : IAttackStrategy
    {
        public int HitPoints { get; set; }
        public void Attack()
        {
            Console.WriteLine("Sword attak");
        }
    }

    public class BowAttakStrategy : IAttackStrategy
    {
        public int HitPoints { get; set; }
        public void Attack()
        {
            Console.WriteLine("Bow attak");
        }
    }
}