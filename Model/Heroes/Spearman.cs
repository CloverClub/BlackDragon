﻿using System;

namespace Model
{
    public class Spearman : Hero
    {
        private bool invincibility;
        private Javelin weapon;

        public bool Invinsible
        {
            get
            {
                return this.invincibility;
            }
            set
            {
                this.invincibility = value;
            }
        }
        public Spearman(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
            this.Width = 6;
            this.Length = 4;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write(" _O  ^");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write("| |`-|");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"  |\ |");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(" /  L|");
            // _O  ^
            //| |`-|
            //  |\ |
            // /  L|
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
