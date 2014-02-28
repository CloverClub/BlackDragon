using System;

namespace Model
{
    public class Barbarian : Hero
    {
        private bool frenzy;
        private ThrowingAxe weapon;

        public bool Frenzy
        {
            get
            {
                return frenzy;
            }
            set
            {
                frenzy = value;
            }
        }
         

        public Barbarian(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
            this.Width = 7;
            this.Length = 4;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write(@"|_O (|)");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write("  |`-|");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@"  |\");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(" /  |");
            //|_O (|)
            //  |`-|
            //  |\
            // /  |
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
