using System;

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
            Console.Write(" )__)");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" _\/_");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write("| |  |");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write("  |_");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" /  \");
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
