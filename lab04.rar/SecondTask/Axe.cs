using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    public class Axe : Weapon
    {
        public override int CalculateDamage()
        {
            return SwingAttack() + 10;
        }

        public int SwingAttack()
        {
            return damage + 20;
        }
    }
}
