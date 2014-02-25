using System;

namespace Model
{
    public class Dragon : Enemy
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

        public Dragon(int health, int damage)
            : base()
        {
            this.Health = health;
            this.Damage = damage;
            this.Width = 21;
            this.Length = 8;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.WriteLine("   (_(");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"  ('')");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"_  ''\ )>,_     .-->");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"_>--w/((_ >,_.'");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"       ///");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"      ''`''");
            //
            //   (_(
            //  ('')
            //_  ''\ )>,_     .-->
            //_>--w/((_ >,_.'
            //       ///
            //       "`"

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
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(new string(' ', this.Width));
        }
    }
}