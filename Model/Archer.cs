﻿namespace Model
{
    class Archer : Hero
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set 
            {
               this.name = value;
            }
        }
        public int Damage
        {
            get { return this.damagePoints; }
            set { this.damagePoints = 10; }
        }

        public int Health
        {
            get { return this.healthPoints; }
            set { this.healthPoints = 100; }
        }
    }
}
