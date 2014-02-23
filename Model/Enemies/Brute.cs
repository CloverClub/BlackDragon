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
        {
            this.Health = health;
            this.Damage = damage;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.WriteLine("__o_/>");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"/ [ ]/\");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"[// \\]");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"/_|_\");
            

            //__o_/>
            /// [ ]/\
            //[// \\]
            ///_|_\
            ///
            //brute

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