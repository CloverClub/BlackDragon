using System;
using System.Text;

namespace Model
{
    public class Archer : Hero
    {
        private bool doubleDamage;

        public bool DoubleDamage
        {
            get 
            { 
                return this.doubleDamage;
            }
            set 
            { 
                this.doubleDamage = value;
            }
        }

        public Archer(string name, int exp, int health, int damage)
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
            Console.WriteLine("|_O");
            Console.SetCursorPosition(Position.Left,++y);
            Console.WriteLine(@"  |\_)_");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@"  |\ )");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.WriteLine(@" /  |");

              //|_O
              //  |\_)_
              //  |\ )
              // /  |
        }

        public override void Erase()
       {
            int y = Position.Top;

            for (int i = 0; i < this.Length; i++)
            {
                Console.SetCursorPosition(Position.Left, y++);
                Console.WriteLine(new string(' ', this.Width));
            }
        }

    }
}
