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
            : base()
        {
            this.Health = health;
            this.Damage = damage;
            this.Width = 9;
            this.Length = 7;
        }

           
        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write("    , ,");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" /\ |V| /\");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"/  (("")) *\");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"\ |_/_\_/ /");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" \_(()))_/");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"   _/ \_");

            //    , ,
            // /\ |V| /\
            ///  ((")) *\
            //\ |_/_\_/ /
            // \_(()))_/
            //   _/ \_
            //fallen

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