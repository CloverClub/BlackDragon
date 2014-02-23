﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlay
{
    public class Engine
    {
        private Menu menu;
        private short choice;
        private Hero hero;
        private List<Enemy> enemies;
        private ConsoleKeyInfo key;

        public Menu Menu
        {
            get
            {
                if (menu == null)
                    menu = new Menu();
                return menu;
            }
        }
        public Hero Hero
        {
            get
            {
                return hero;
            }
            set
            {
                hero = value;
            }
        }
        public List<Enemy> Enemies
        {
            get
            {
                return enemies;
            }
            set
            {
                enemies = value;
            }
        }
        public short Choice
        {
            get
            {
                return choice;
            }
            set
            {
                choice = value;
            }
        }
        public ConsoleKeyInfo Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }

        public Engine()
        {
            InitializeGame();
            SetHero();
            Play();
        }

        public void InitializeGame()
        {
            Menu.DisplayTitle();
            Menu.DisplayOptions();

            short.TryParse(Console.ReadLine(), out choice);
            while (Choice < 1 || Choice > 5)
            {
                Menu.DisplayInvalidMessage();
                short.TryParse(Console.ReadLine(), out choice);
            }

            Menu.ClearScreen();
        }

        public void SetHero()
        {
            Hero = Factory.GetHero((HeroEnum)Choice);
            Console.Write(Hero.DrawImage());
        }

        public void Play()
        {
            int positionLeft;
            int positionTop;

            while(true)
            {
                Key = Console.ReadKey();
                switch(Key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        break;
                    case ConsoleKey.RightArrow:
                        break;
                    case ConsoleKey.UpArrow:
                        break;
                    case ConsoleKey.DownArrow:
                        break;
                }
            }
        }
    }
}