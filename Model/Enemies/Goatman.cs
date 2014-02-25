﻿using System;

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
            : base()
        {
            Health = health;
            Damage = damage;
            this.Width = 6;
            this.Length = 5;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.WriteLine(" )__)");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@" _\/_");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine("| |  |");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine("  |_");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@" /  \");
            // )__)
            // _\/_
            //| |  |
            //  |_
            // /  \

        }

        public override void Erase()
        {
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.WriteLine(new string(' ', this.Width));
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(new string(' ', this.Width));
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(new string(' ', this.Width));
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(new string(' ', this.Width));
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(new string(' ', this.Width));
        }
    }
}
