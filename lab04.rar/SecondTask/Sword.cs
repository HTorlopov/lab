using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    public class Sword : Weapon
    {
        public override int CalculateDamage()
        {
            return ThrustAttack();
        }

        public override void Repair()
        {
            condition += 50;
        }


        public int ThrustAttack()
        {
            return damage + 20;
        }
    }
}
