using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    public class Storage
    {
        List<Weapon> weapons;

        public Storage(Weapon weapon1, Weapon weapon2) : this(weapon1, weapon2, null)
        {

        }

        public Storage(Weapon weapon1, Weapon weapon2, Weapon weapon3)
        {
            weapons = new List<Weapon>();
            weapons.Add(weapon1);
            weapons.Add(weapon2);

            if (weapon3 != null)
            weapons.Add(weapon3);
        }

        public void ShowTree()
        {
            foreach (Weapon weapon in weapons)
            {           
                weapon.ShowMethods();
            }
        }
    }
}
