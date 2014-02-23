using System;

namespace Model
{
    public class Fallen : Enemy
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

        public Fallen(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }

           
        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.WriteLine("    , ,");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"/\ |V| /\");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"/  (('')) *\");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"\ |_/_\_/ /");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"\_(()))_/");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@" _/ \_");

            //    , ,
            ///\ |V| /\
            ///  ((")) *\
            //\ |_/_\_/ /
            //\_(()))_/
            //   _/ \_
            //fallen

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