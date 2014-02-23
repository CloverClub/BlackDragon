using System;

namespace Model
{
    public class ThrowingAxe : Weapon
    {
        public int Damage
        {
            get { return this.addDamage; }
            set { this.addDamage = 10; }
        }
        public int Range
        {
            get { return this.range; }
            set { this.range = value; }
        }

        public override void Draw()
        {
            int x = Position.Left;
            int y = Position.Top;
            Console.SetCursorPosition(x, y);
            if (WeaponDirection == WeaponDirectionEnum.up)
            {
                Console.WriteLine("(|)");
                Console.SetCursorPosition(Position.Left, ++y);
                Console.WriteLine(" |");
                Console.SetCursorPosition(Position.Left, ++y);
                Console.WriteLine(" |");
            }
            else if (WeaponDirection == WeaponDirectionEnum.down)
            {
                Console.WriteLine(" |");
                Console.SetCursorPosition(Position.Left, ++y);
                Console.WriteLine(" |");
                Console.SetCursorPosition(Position.Left, ++y);
                Console.WriteLine("(|)");
            }
            else if (WeaponDirection == WeaponDirectionEnum.left)
            {
                Console.WriteLine("8--");
            }
            else if (WeaponDirection == WeaponDirectionEnum.right)
            {
                Console.WriteLine("--8");
            }
        }

        public override void Erase()
        {
            int y = Position.Top;
            Console.SetCursorPosition(Position.Left, Position.Top);

            if (WeaponDirection == WeaponDirectionEnum.up || WeaponDirection == WeaponDirectionEnum.down)
            {
                Console.WriteLine(new string(' ', 3));
                Console.SetCursorPosition(Position.Left, ++y);
                Console.WriteLine(new string(' ', 3));
                Console.SetCursorPosition(Position.Left, ++y);
                Console.WriteLine(new string(' ', 3));
                Console.SetCursorPosition(Position.Left, ++y);
            }
            else if (WeaponDirection == WeaponDirectionEnum.left || WeaponDirection == WeaponDirectionEnum.right)
            {
                Console.WriteLine(new string(' ', 3));
            }
        }

        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
