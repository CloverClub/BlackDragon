using System;

namespace Model
{
    public class Ogre : Enemy
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

        public Ogre(int health, int damage)
            : base()
        {
            this.Health = health;
            this.Damage = damage;
            this.Width = 8;
            this.Length = 5;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write(@" /oo\  _");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" \ o/ |/");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"/    \V");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"( __ )");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" |--|");
            
            // /@@\  _
            // \ o/ |/
            ///    \V
            //( __ )
            // |--|

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