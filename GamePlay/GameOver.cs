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

            DrawAtPosition.WriteAt(20 , 73, "Game Over!", ConsoleColor.Red);


            DrawAtPosition.WriteAt(25, 78, "Your scores are " + Highscores.currentScores, ConsoleColor.Red);
            DrawAtPosition.WriteAt(25, 78, "Enter your name: ", ConsoleColor.Red);
            DrawAtPosition.WriteAt(30, 83, "The name should be between 3 and 10 symbols!", ConsoleColor.White);

            // ENTER YOUR NAME starts //
            Console.CursorVisible = true;
            while (Highscores.playerNameGameOver.Length < 3 || Highscores.playerNameGameOver.Length > 10)
            {
                Console.SetCursorPosition(42, 78);
                Highscores.playerNameGameOver = Console.ReadLine().ToUpper().TrimStart(' ').TrimEnd(' ');
            }
            Console.CursorVisible = false;
            // ENTER YOUR NAME ends //

            Highscores.WriteScores();
            Console.Clear();


            while (true)
            {
                Highscores.ShowHighScores(ConsoleColor.Yellow);

                DrawAtPosition.WriteAt(21, 73, "To EXIT the game press ESC button", ConsoleColor.White);

                /////////// checks if the player is in top 5 ///////////
                List<string> topFive = Highscores.GetHighScores();

                bool inTopFive = false;

                for (int index = 0; index < topFive.Count; index++)
                {
                    string[] scoreAndName = topFive[index].Split(new char[] { '|' }); // split the line, gets the name and points

                    if (scoreAndName[1] == Highscores.playerNameGameOver
                        && scoreAndName[0].TrimStart('0') == Convert.ToString(Highscores.currentScores))
                    {
                        DrawAtPosition.WriteAt(20, 68, "YOU ARE IN TOP 5");
                        inTopFive = true;
                        break;
                    }
                }

                if (inTopFive == false)
                {
                    DrawAtPosition.WriteAt(22, 66, "You are NOT in TOP 5");
                    DrawAtPosition.WriteAt(18, 64, "Try again!");
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
