using System;

namespace Model
{
    public class Dwarf : Hero
    {
        private bool increaseRange;
        private ThrowingAxe weapon;

        public bool IncreaseRange
        {
            get
            {
                return this.increaseRange;
            }
            set
            {
                this.increaseRange = value;
            }
        }

        public Dwarf(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
            this.Width = 9;
            this.Length = 4;
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.WriteLine("  , ,");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine("   Q (|)");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"()( )\|");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine("  | L");
            //   , ,
            //    Q (|)
            // ()( )\|
            //   | L
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
