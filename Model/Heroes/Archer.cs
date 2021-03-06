﻿using System;

namespace Model
{
    public class Archer : Hero
    {
        private bool doubleDamage;
        private Bow weapon;

        
        

        public bool DoubleDamage
        {
            get 
            { 
                return this.doubleDamage;
            }
            set 
            { 
                this.doubleDamage = value;
            }
        }
        

        public Archer(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
            this.Width = 7;
            this.Length = 6;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write("  ^");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" /_\{)");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write("<---) >");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" \ / |");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write("  V /|");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"   |  \");
            //  ^
            // /_\{)
            //<---) >
            // \ / |
            //  V /|
            //   |  \
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
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(new string(' ', this.Width));
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(new string(' ', this.Width));
        }
    }
}
