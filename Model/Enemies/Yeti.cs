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
            : base()
        {
            this.Health = health;
            this.Damage = damage;
            this.Width = 9;
            this.Length = 5;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write(@" __("")__");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"( (   ) )");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"/ |   | \");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"\( ( ) )/");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" /_| |_\");
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