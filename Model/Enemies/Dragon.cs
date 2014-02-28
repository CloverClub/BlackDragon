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
            Console.Write("   (_(");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"  ('')");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"_  ''\ )>,_     .-->");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"_>--w/((_ >,_.'");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"       ///");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"      ''`''");
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