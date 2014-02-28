using System;

namespace Model
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
            :base()
        {
            this.Health = health;
            this.Damage = damage;
            this.Width = 7;
            this.Length = 4;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write(" __o__");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"/ [ ]/\");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"[// \\]");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" /_|_\");
            

            // __o__
            /// [ ]/\
            //[// \\]
            // /_|_\
            
            //brute

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