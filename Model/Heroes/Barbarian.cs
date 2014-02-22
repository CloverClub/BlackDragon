using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Barbarian : Hero
    {
        private bool frenzy;

        public bool Frenzy
        {
            get
            {
                return frenzy;
            }
            set
            {
                frenzy = value;
            }
        }
         

        public Barbarian(string name, int exp, int level, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.Level = level;
            this.HealthPoints = health;
            this.DamagePoints = damage;
        }
    }
}
