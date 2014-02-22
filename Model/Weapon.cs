using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Weapon
    {
        protected int addDamage;

        public int Damage { get; private set; }

        public abstract void DrawWeapon();

    }
}
