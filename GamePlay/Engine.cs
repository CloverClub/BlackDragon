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
            while (!PlayingHero.IsDead)
            {
                playfield.DrawBorders();
                PositionEnemies();

                enemiesThread = new Thread(MoveAllEnemies);
                weaponsThread = new Thread(MoveWeaponsOnScreen);
                enemiesThread.Start();
                weaponsThread.Start();
                PlayingHero.HealthPoints = 100;

                while (Enemies.Count != 0)
                {
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey();
                        PlayingHero.Move(Key);
                        PlayingHero.AddNewMovingWeapon(Key, Factory.GetWeapon((HeroEnum)Choice));
                    }
                    EnemyCollision();
                    WeaponCollision();
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

                PlayingHero.Level++;
            }
        }

        public void EnemyCollision()
        {
            for (int i = 0; i < Enemies.Count; i++)
            {
                for (int enemyY = Enemies[i].Position.Top; enemyY <= Enemies[i].Position.Top + Enemies[i].Length; enemyY++)
                {
                    for (int enemyX = Enemies[i].Position.Left; enemyX <= Enemies[i].Position.Left + Enemies[i].Width; enemyX++)
                    {
                        if (enemyX == PlayingHero.Position.Left && enemyY == PlayingHero.Position.Top)
                        {
                            Enemies[i].Attack(PlayingHero);
                            return;
                        }
                    }           
                }
            }
        }

        public void WeaponCollision()
        {
            try
            {
                #region
                for (int i = 0; i < Enemies.Count; i++)
                {
                    for (int enemyY = Enemies[i].Position.Top; enemyY <= Enemies[i].Position.Top + Enemies[i].Length; enemyY++)
                    {
                        for (int enemyX = Enemies[i].Position.Left; enemyX <= Enemies[i].Position.Left + Enemies[i].Width; enemyX++)
                        {
                            for (int weaponIndex = 0; weaponIndex < PlayingHero.MovingWeapons.Count; weaponIndex++)
                            {
                                Weapon currentWeapon = PlayingHero.MovingWeapons[weaponIndex];

                                if (currentWeapon.Position.Left == enemyX && currentWeapon.Position.Top == enemyY)
                                {
                                    PlayingHero.Weapon = currentWeapon;
                                    currentWeapon.Erase();
                                    PlayingHero.MovingWeapons.Remove(currentWeapon);

                                    if (PlayingHero.Attack(Enemies[i]))
                                    {
                                        Enemies[i].Erase();
                                        Enemies.Remove(Enemies[i]);
                                        if (i > 0)
                                        {
                                            i--;
                                        }
                                        if (Enemies.Count == 0 || PlayingHero.MovingWeapons.Count == 0)
                                            return;
                                    }
                                }

                            }
                        }
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                return;
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
            PrintStats();
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
                try
                {
                    PlayingHero.MovingWeapons[i].Move(this.PlayField.Width, this.PlayField.Height);
                    if (PlayingHero.MovingWeapons[i].ToBeRemoved)
                    {
                        PlayingHero.MovingWeapons.Remove(PlayingHero.MovingWeapons[i]);
                        i--;
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

        private void PrintStats()
        {
            Console.SetCursorPosition(2, PlayField.Height - 2);
            Console.Write("Level {0}   Experiance {1}   Health {2}   Damage {3}", this.PlayingHero.Level, this.PlayingHero.Experience, this.PlayingHero.HealthPoints, this.PlayingHero.DamagePoints);
        }
    }
}
