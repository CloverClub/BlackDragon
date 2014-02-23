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
        {
            this.Health = health;
            this.Damage = damage;
            this.Width = 4;
            this.Length = 4;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.WriteLine(" _@_");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine("| | |");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine("  |");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@" / \");
            // _@_
            //| | |
            //  |
            // / \

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
        }
    }
}
