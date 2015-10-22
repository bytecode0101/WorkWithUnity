using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWar;

namespace SuperAttacks
{
    public class SuperAttack : IAttackStrategy
    {
        public int HitPoints { get; set; }

        public void Attack()
        {
            Console.WriteLine("This is a super attack {0}", HitPoints);
        }
    }
}
