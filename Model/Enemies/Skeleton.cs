using System;

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
            : base()
        {
            this.Health = health;
            this.Damage = damage;
            this.Width = 5;
            this.Length = 4;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write(" _@_");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write("| | |");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write("  |");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" / \");
            // _@_
            //| | |
            //  |
            // / \

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
