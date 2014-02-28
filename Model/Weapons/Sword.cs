using System;

namespace Model
{
    public class Sword : Weapon
    {
        public int Damage
        {
            get { return this.addDamage; }
            set { this.addDamage = 20; }
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
                Console.Write("|");
                Console.SetCursorPosition(Position.Left, ++y);
                Console.Write("|");
                Console.SetCursorPosition(Position.Left, ++y);
                Console.Write("^");
                Console.SetCursorPosition(Position.Left, ++y);
                Console.Write("|");
            }
            else if (WeaponDirection == WeaponDirectionEnum.down)
            {
                Console.Write("|");
                Console.SetCursorPosition(Position.Left, ++y);
                Console.Write("v");
                Console.SetCursorPosition(Position.Left, ++y);
                Console.Write("|");
                Console.SetCursorPosition(Position.Left, ++y);
                Console.Write("|");
            }
            else if (WeaponDirection == WeaponDirectionEnum.left)
            {
                Console.Write("--<-");
            }
            else if (WeaponDirection == WeaponDirectionEnum.right)
            {
                Console.Write("->--");
            }
        }

        public override void Erase()
        {
            int y = Position.Top;
            Console.SetCursorPosition(Position.Left, Position.Top);

            if (WeaponDirection == WeaponDirectionEnum.up || WeaponDirection == WeaponDirectionEnum.down)
            {
                Console.Write(new string(' ', 1));
                Console.SetCursorPosition(Position.Left, ++y);
                Console.Write(new string(' ', 1));
                Console.SetCursorPosition(Position.Left, ++y);
                Console.Write(new string(' ', 1));
                Console.SetCursorPosition(Position.Left, ++y);
                Console.Write(new string(' ', 1));
                Console.SetCursorPosition(Position.Left, ++y);
            }
            else if (WeaponDirection == WeaponDirectionEnum.left || WeaponDirection == WeaponDirectionEnum.right)
            {
                Console.Write(new string(' ', 4));
            }
        }
    }
}