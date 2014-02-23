using System;
using System.Text;
namespace Model
{
    public class Sorcerer : Hero
    {
        private bool damageForLife;

        public bool Sacrifice
        {
            get
            {
                return this.damageForLife;
            }
            set
            {
                this.damageForLife = value;
            }
        }
        public Sorcerer(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
            this.Width = 9;
            this.Length = 5;
        }

        public override void Draw()
        {
            int y = this.Position.Top;

            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write("( _o  *");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" |\ )/|");
            Console.SetCursorPosition(Position.Left, ++y);
            Console.Write(@" |/_\ |");

           //( _o  *
           // |\ )/|
           // |/_\ |

        }

        public override void Erase()
        {
            int y = Position.Top;
            for(int i = 0; i <= this.Length; i++)
            {
                Console.SetCursorPosition(Position.Left, y++);
                Console.Write(new string(' ', this.Width));
            }
        }
    }
}
