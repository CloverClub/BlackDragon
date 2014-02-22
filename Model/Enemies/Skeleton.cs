using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Skeleton : Enemy
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

        public Skeleton(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }
    }
}
