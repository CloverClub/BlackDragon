using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;


namespace GamePlay
{
    class GameOver
    {
        public static void Initialize()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            DrawAtPosition.WriteAt(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2, "Game Over!", ConsoleColor.Red);
            DrawAtPosition.WriteAt(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 + 3, "Your scores are " + Highscores.currentScores, ConsoleColor.Red);
            DrawAtPosition.WriteAt(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 + 6, "Enter your name: ", ConsoleColor.Red);
            DrawAtPosition.WriteAt(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 + 9, "The name should be between 3 and 10 symbols!", ConsoleColor.White);

            // ENTER YOUR NAME starts //
            Console.CursorVisible = true;
            while (Highscores.playerNameGameOver.Length < 3 || Highscores.playerNameGameOver.Length > 10)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 12);
                Highscores.playerNameGameOver = Console.ReadLine().ToUpper().TrimStart(' ').TrimEnd(' ');
            }
            Console.CursorVisible = false;
            // ENTER YOUR NAME ends //

            Highscores.WriteScores();
            Console.Clear();


            while (true)
            {
                Highscores.ShowHighScores(ConsoleColor.Yellow);

                DrawAtPosition.WriteAt(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 + 5, "To EXIT the game press ESC button", ConsoleColor.White);

                /////////// checks if the player is in top 5 ///////////
                List<string> topFive = Highscores.GetHighScores();

                bool inTopFive = false;

                for (int index = 0; index < topFive.Count; index++)
                {
                    string[] scoreAndName = topFive[index].Split(new char[] { '|' }); // split the line, gets the name and points

                    if (scoreAndName[1] == Highscores.playerNameGameOver
                        && scoreAndName[0].TrimStart('0') == Convert.ToString(Highscores.currentScores))
                    {
                        DrawAtPosition.WriteAt(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 + 5, "YOU ARE IN TOP 5");
                        inTopFive = true;
                        break;
                    }
                }

                if (inTopFive == false)
                {
                    DrawAtPosition.WriteAt(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 + 2, "You are NOT in TOP 5");
                    DrawAtPosition.WriteAt(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 2, "Try again!");
                }

                /////////// checks if the player is in top 5 ///////////

                    bool commandCorrect = false;

                // ESCAPE AND EXIT
                if (Console.KeyAvailable)
                {
                    while (!commandCorrect)
                    {
                        ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                        if (pressedKey.Key == ConsoleKey.Escape)
                        {
                            Console.WriteLine();
                            Console.Clear();
                            Environment.Exit(0); 
                            commandCorrect = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
