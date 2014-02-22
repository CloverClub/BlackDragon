﻿namespace Model
{
    public class Dwarf : Hero
    {
        private bool increaseRange;

        public bool IncreaseRange
        {
            get
            {
                return this.increaseRange;
            }
            set
            {
                this.increaseRange = value;
            }
        }

        public Dwarf(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
        }
    }
}