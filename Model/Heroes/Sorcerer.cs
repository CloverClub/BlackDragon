﻿using System;

namespace Model
{
    public class Sorcerer : Hero
    {
        private bool damageForLife;
        private Scepter weapon;

        public bool Sacrifice
        {
            get
            {
                return this.damageForLife;
            }
            set
            {
                this.damageForLife = value;
            }
        }
        public Sorcerer(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
            this.Width = 7;
            this.Length = 5;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write("   ^");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write("( _0  *");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" |\ )/|");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" |/_\ |");
            //   ^
            //( _0  *
            // |\ )/|
            // |/_\ |
        }

        public override void Erase()
        {
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write(new string(' ', this.Width));
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(new string(' ', this.Width));
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(new string(' ', this.Width));
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(new string(' ', this.Width));
        }
    }
}
