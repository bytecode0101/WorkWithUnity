using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWar
{
    public interface IUnit
    {
        IAttackStrategy AttacStrategy { get; set; }
        void Attack();
    }

    public class Unit : IUnit
    {
        IAttackStrategy attacStrategy;

       // [Dependency]
        public IAttackStrategy AttacStrategy
        {
            get
            {
                return attacStrategy;
            }

            set
            {
                attacStrategy = value;
            }
        }

        public void Attack()
        {
            attacStrategy.Attack();
        }
    }
}
