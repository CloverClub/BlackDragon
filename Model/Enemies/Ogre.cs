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
        {
            this.Health = health;
            this.Damage = damage;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.WriteLine(@" /oo\  _");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@" \ o/ |/");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"/    \V");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"( __ )");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@" |--|");
            
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