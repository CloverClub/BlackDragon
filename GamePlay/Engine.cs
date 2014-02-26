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
        private Thread weaponsThread;
        private ManualResetEvent pauseEvent;
        private PlayField playfield;

        public PlayField PlayField
        {
            get 
            {
                if (playfield == null)
                {
                    playfield = new PlayField(40, 146);
                }
                return playfield; 
            }
            set { playfield = value; }
        }
        

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
            Console.WindowHeight = this.PlayField.Height;
            Console.WindowWidth = this.PlayField.Width;
            Console.BufferHeight = this.PlayField.Height + 1;
            InitializeGame();
            SetHero();
            Play();
        }

        public void EnemyCollision() //TOOD fix the Collision system
        {
            for (int i = 0; i < Enemies.Count; i++)
			{
                if ((Enemies[i].Width == PlayingHero.Width && Enemies[i].Length == PlayingHero.Length)
                    || (Enemies[i].Width + 1 == PlayingHero.Width && Enemies[i].Length == PlayingHero.Length)
                    || (Enemies[i].Width - 1 == PlayingHero.Width && Enemies[i].Length == PlayingHero.Length)
                    || (Enemies[i].Width == PlayingHero.Width && Enemies[i].Length + 1 == PlayingHero.Length)
                    || (Enemies[i].Width == PlayingHero.Width && Enemies[i].Length - 1 == PlayingHero.Length))
                {
                    Enemies[i].Attack(PlayingHero);
                }
			}
        }
        //public void WeaponCollision() 
        //{
        //    for (int i = 0; i < Enemies.Count; i++)
        //    {
        //        if (Enemies[i].Width == PlayingHero.Weapon.Width && Enemies[i].Length == PlayingHero.Weapon.Length)
        //        {
        //            PlayingHero.Attack(Enemies[i]);
        //        }
        //    }
        //}

        public void InitializeGame()
        {
            Console.SetCursorPosition((Console.WindowWidth / 2), 3);
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
            PlayingHero.Position.Top = Console.WindowHeight - PlayingHero.Length - PlayField.borderTop;
            PlayingHero.Draw();
        }

        public void PositionEnemies()
        {
            int previousEnemyPositionLeft = PlayField.Width / 2 - 40;
            int previousEnemyPositionTop = 10;

            Enemies.Clear();
            for (int i = 0; i < 10; i++)
            {
                Enemy newEnemy = Factory.GetEnemy((EnemyEnum)PlayingHero.Level);
                
                newEnemy.Position.Left = previousEnemyPositionLeft;
                newEnemy.Position.Top = previousEnemyPositionTop;
                newEnemy.Draw();

                Enemies.Add(newEnemy);
                previousEnemyPositionLeft += newEnemy.Width + 2;

                Thread.Sleep(30);
            }
        }

        public void Play()
        {
            //while (true)
            {
                //PlayingHero.Level = level;
                playfield.DrawBorders();
                PositionEnemies();

                enemiesThread = new Thread(MoveAllEnemies);
                weaponsThread = new Thread(MoveWeaponsOnScreen);
                enemiesThread.Start();
                weaponsThread.Start();

                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey();
                        PlayingHero.Move(Key);
                        PlayingHero.AddNewMovingWeapon(Key, Factory.GetWeapon((HeroEnum)Choice));
                    }
                    EnemyCollision();
                    // WeaponCollision();
                    EnemiesTurnThread();
                    WeaponsTurnThread();

                    
                    if (PlayingHero.IsDead) // hero isDead
                    {
                        GameOver.Initialize();
                    }
                    else if (true) // method - detect whether all enemies are dead 
                    {
                        // game over
                    }
                }

                if (PlayingHero.IsDead) // hero isDead
                {
                    Console.Clear();// game over
                }
                else if (true) // gragon is dead
                {
                    // game over
                }
            }
        }

        private void EnemiesTurnThread()
        {
            if (!enemiesThread.IsAlive)
            {
                enemiesThread = new Thread(MoveAllEnemies);
                enemiesThread.Start();
            }
        }

        private void MoveAllEnemies()
        {
            Thread.Sleep(200);
            for (int i = 0; i < Enemies.Count; i++)
            {
                Enemies[i].Move(this.PlayField.Width, this.PlayField.Height);
            }
        }

        private void WeaponsTurnThread()
        {
            if (!weaponsThread.IsAlive)
            {
                weaponsThread = new Thread(MoveWeaponsOnScreen);
                weaponsThread.Start();
            }
        }

        private void MoveWeaponsOnScreen()
        {
            Thread.Sleep(25);
            for (int i = 0; i < PlayingHero.MovingWeapons.Count; i++)
            {
                PlayingHero.MovingWeapons[i].Move(this.PlayField.Width, this.PlayField.Height);
                if (PlayingHero.MovingWeapons[i].ToBeRemoved)
                {
                    PlayingHero.MovingWeapons.Remove(PlayingHero.MovingWeapons[i]);
                    i--;
                }
            }
        }
    }
}
