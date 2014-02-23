using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private Thread heroThread;
        private Thread enemiesThread;
        private ManualResetEvent pauseEvent;

        public Menu Menu
        {
            get
            {
                if (menu == null)
                    menu = new Menu();
                return menu;
            }
        }
        public Hero PlayingHero
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
                if (enemies == null)
                    enemies = new List<Enemy>();
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
            PlayingHero = Factory.GetHero((HeroEnum)Choice);
            PlayingHero.Position.Left = Console.WindowWidth / 2;
            PlayingHero.Position.Top = Console.WindowHeight - PlayingHero.Length;
            PlayingHero.Draw();
        }

        public void PositionEnemies()
        {
            int previousEnemyPositionLeft = 0;
            int previousEnemyPositionTop = 0;

            Enemies.Clear();
            for (int i = 0; i < 10; i++)
            {
                Enemy newEnemy = Factory.GetEnemy((EnemyEnum)PlayingHero.Level);
                
                newEnemy.Position.Left = previousEnemyPositionLeft;
                newEnemy.Position.Top = previousEnemyPositionTop;
                newEnemy.Draw();
                
                Enemies.Add(newEnemy);
                previousEnemyPositionLeft += newEnemy.Width + 2;
            }
        }

        public void MoveEnemiesLowerRight()
        {
            Thread.Sleep(1000);
            Enemy currentEnemy = null;
            for (int i = 0; i < 10; i++)
            {
                currentEnemy = Enemies[i];
                currentEnemy.Erase();
                currentEnemy.Position.Left++;
                currentEnemy.Position.Top++;
                currentEnemy.Draw();
            }
        }

        public void MoveHero()
        {
            Key = Console.ReadKey();
            switch (Key.Key)
            {
                case ConsoleKey.LeftArrow:
                    PlayingHero.Erase();
                    PlayingHero.Position.Left--;
                    PlayingHero.Draw();
                    break;
                case ConsoleKey.RightArrow:
                    PlayingHero.Erase();
                    PlayingHero.Position.Left++;
                    PlayingHero.Draw();
                    break;
                case ConsoleKey.UpArrow:
                    PlayingHero.Erase();
                    PlayingHero.Position.Top--;
                    PlayingHero.Draw();
                    break;
                case ConsoleKey.DownArrow:
                    PlayingHero.Erase();
                    PlayingHero.Position.Top++;
                    PlayingHero.Draw();
                    break;
            }
        }

        public void Play()
        {
            PositionEnemies();
            
            enemiesThread = new Thread(MoveEnemiesLowerRight);
            enemiesThread.Start();
            while(true)
            {
                if (Console.KeyAvailable)
                {
                    MoveHero();   
                }

                RestartEnemiesThread();
            }
        }

        private void RestartEnemiesThread()
        {
            if (!enemiesThread.IsAlive)
            {
                enemiesThread = new Thread(MoveEnemiesLowerRight);
                enemiesThread.Start();
            }
        }
    }
}
