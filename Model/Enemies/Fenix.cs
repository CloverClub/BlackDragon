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
            : base()
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
            Console.Write(@" (\  (\");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"(  \_('>");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"(__(=_)");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"  -''=");
            

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