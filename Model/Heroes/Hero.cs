﻿using System;
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
                int newExperience = this.experiece + value;
                if (newExperience >= 100)
                {
                    this.Experience = newExperience % 100;
                    this.Level++;
                }
                this.experiece += value;
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
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    this.Erase();
                    this.Position.Left--;
                    this.Draw();
                    break;
                case ConsoleKey.RightArrow:
                    this.Erase();
                    this.Position.Left++;
                    this.Draw();
                    break;
                case ConsoleKey.UpArrow:
                    this.Erase();
                    this.Position.Top--;
                    this.Draw();
                    break;
                case ConsoleKey.DownArrow:
                    this.Erase();
                    this.Position.Top++;
                    this.Draw();
                    break;
            }
        }
    }
}
