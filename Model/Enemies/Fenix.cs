using System;

namespace Model
{
    public class Fenix : Enemy
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

        public Fenix(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
            this.Width = 8;
            this.Length = 4;
        }

        

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.WriteLine(@" (\  (\");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"(  \_('>");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"(__(=_)");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"  -''=");
            

            // (\  (\
            //(  \_('>
            //(__(=_)
            //   -"=

            //FENIX

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