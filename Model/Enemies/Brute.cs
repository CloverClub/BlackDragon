﻿namespace Model
{
    public class Brute : Enemy
    {
        public int Damage
        {
            get { return this.damagePoints; }
            set { this.damagePoints = value; }
        }

        public int Health
        {
            get { return this.healthPoints; }
            set { this.healthPoints = value; }
        }

        public Brute(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }
    }
}