using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Goatman : Enemy
    {
        public int Health
        {
            get
            {
                return healthPoints;
            }
            set
            {
                healthPoints = value;
            }
        }

        public int Damage
        {
            get
            {
                return damagePoints;
            }
            set
            {
                damagePoints = value;
            }
        }

        public Goatman(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public override string DrawImage()
        {
            StringBuilder image = new StringBuilder();
            image.Append(@"
                         @__@
                         _\/_
                        | |  |
                          |_
                         /  \");
            return image.ToString();
        }
    }
}
