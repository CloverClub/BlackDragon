using System;

namespace Model
{
    public class Yeti : Enemy
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

        public Yeti(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.WriteLine(@" __("")__");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"( (   ) )");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"/ |   | \");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"\( ( ) )/");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@" /_| |_\");
            // __(")__
            //( (   ) )
            /// |   | \
            //\( ( ) )/
            // /_| |_\


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