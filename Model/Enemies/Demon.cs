using System;
using System.Text;

namespace Model
{
    public class Demon : Enemy
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

        public Demon(int health, int damage)
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
            Console.WriteLine("   {__}");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"   \/");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"/^(  )^\ ");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"\,(..),/ ");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"  |~~|'')");
            

            //  {__}
            //   \/
            ///^(  )^\  
            //\,(..),/      
            //  |~~|");

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