using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hero : Character
    {
        #region Fields

        private int level;
        private List<Weapon> weapons;
        private Weapon weapon;
        private int highScore;
        private int experiece;
        private string name;
        
        #endregion

        #region Properties

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public int Experience
        {
            get
            {
                return this.experiece;
            }
            set
            {
                if (value >= 100)
                {
                    this.experiece = value % 100;
                    this.Level++;
                }
                this.experiece = value;
            }
        }
        public int Level 
        {
            get
            {
                return level;
            }
          private  set
            {
                level += value;
            }
        }
        public List<Weapon> MovingWeapons
        {
            get
            {
                if (weapons == null)
                    weapons = new List<Weapon>();
                return weapons;
            }
            set
            {
                weapons = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }
        public int HighScore
        {
            get
            {
                return highScore;
            }
            set
            {
                highScore = value;
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                healthPoints = value;
            }
        }
        public int DamagePoints
        {
            get
            {
                return damagePoints;
            }
            set
            {
                damagePoints = value;
            }
        }

        #endregion

        public Hero()
        {
            this.Level = 1;
        }

        public override bool Attack(Character target)
        {
            bool attackResult = base.Attack(target);
            if (attackResult)
            {
                this.Experience += 10;
            }
            return attackResult;
        }

        public void Move(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (this.Position.Left > PlayField.borderSides)
                    {
                        this.Erase();
                        this.Position.Left--;
                        this.Draw();
                        break;
                    }
                    else
                    {
                        break;
                    }
                case ConsoleKey.RightArrow:
                    if (this.Position.Left + this.Width < Console.WindowWidth - PlayField.borderSides)
                    {
                        this.Erase();
                        this.Position.Left++;
                        this.Draw();
                        break;
                    }
                    else
                    {
                        break;
                    }
                case ConsoleKey.UpArrow:
                    if (this.Position.Top > PlayField.borderTop)
                    {
                        this.Erase();
                        this.Position.Top--;
                        this.Draw();
                        break;
                    }
                    else
                    {
                        break;
                    }
                case ConsoleKey.DownArrow:
                    if (this.Position.Top + this.Length < Console.WindowHeight - PlayField.borderBottom)
                    {
                        this.Erase();
                        this.Position.Top++;
                        this.Draw();
                        break;
                    }
                    else
                    {
                        break;
                    }
            }
        }

        public void AddNewMovingWeapon(ConsoleKeyInfo key, Weapon weapon)
        {
            switch (key.Key)
            {
                case ConsoleKey.A:
                    weapon.Position.Left = this.Position.Left - 1;
                    weapon.Position.Top = this.Position.Top;
                    weapon.WeaponDirection = WeaponDirectionEnum.left;
                    weapon.Draw();
                    MovingWeapons.Add(weapon);
                    break;
                case ConsoleKey.S:
                    weapon.Position.Left = this.Position.Left;
                    weapon.Position.Top = this.Position.Top + this.Length;
                    weapon.WeaponDirection = WeaponDirectionEnum.down;
                    weapon.Draw();
                    MovingWeapons.Add(weapon);
                    break;
                case ConsoleKey.W:
                    weapon.Position.Left = this.Position.Left;
                    weapon.Position.Top = this.Position.Top - 1;
                    weapon.WeaponDirection = WeaponDirectionEnum.up;
                    weapon.Draw();
                    MovingWeapons.Add(weapon);
                    break;
                case ConsoleKey.D:
                    weapon.Position.Left = this.Position.Left + this.Width + 1;
                    weapon.Position.Top = this.Position.Top;
                    weapon.WeaponDirection = WeaponDirectionEnum.right;
                    weapon.Draw();
                    MovingWeapons.Add(weapon);
                    break;
            }
        }
    }
}
