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

        public void Play()
        {
            PositionEnemies();

            enemiesThread = new Thread(MoveAllEnemy);
            enemiesThread.Start();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    PlayingHero.Move(key);
                }
                EnemiesTurnThread();
            }
        }

        private void EnemiesTurnThread()
        {
            if (!enemiesThread.IsAlive)
            {
                enemiesThread = new Thread(MoveAllEnemy);
                enemiesThread.Start();
            }
        }

        private void MoveAllEnemy()
        {
            Thread.Sleep(1000);
            for (int i = 0; i < Enemies.Count; i++)
            {
                Enemies[i].Move();
            }
        }
    }
}
