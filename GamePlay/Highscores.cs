using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlay
{
    class Highscores
    {
        private const string FILEPATH = @"..\..\ExternalFiles\scoreboard.txt";

        public static int currentScores = 0;
        public static string playerNameGameOver = "";

        // STARTS THE HIGH SCORES BOARD
        public static void Initialize()
        {
            List<string> allScores = GetAllScores();

            string[] currentScoreAndName;

            WriteAt(10, 0, "\n" + "                         HIGH SCORES:" + "\n");
            WriteAt(10, 3, "*========================================*");

            int linesNumber = (allScores.Count > 30) ? 30 : allScores.Count;

            for (int index = 0; index < allScores.Count; index++)
            {
                currentScoreAndName = allScores[index].Split(new char[] { '|' });

                string scores = "";

                if (currentScoreAndName[0] != "0000")
                {
                    scores = currentScoreAndName[0].TrimStart('0');
                }
                else
                {
                    scores = "0";
                }

                string lineString = String.Format("* Player {0}: {1}", currentScoreAndName[1], scores);
                WriteAt(10, 4 + index, lineString);
                WriteAt(51, 4 + index, "*");
            }

            if (allScores.Count < 5)
            {
                int emptyRows = 5 - allScores.Count;
                while (emptyRows != 0)
                {
                    WriteAt(10, 4 + (5 - emptyRows), "*");
                    WriteAt(51, 4 + (5 - emptyRows), "*");
                    emptyRows--;
                }
            }

            Console.WriteLine("\n" + "          *========================================*");

            WriteAt(25, 5, "Click ESC to return");

            bool commandCorrect = false;

            while (!commandCorrect)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Initialize();
                    commandCorrect = true;
                }
            }
        }

        // READS THE STATISTICS of the HIGH Scores
        public static void ShowHighScores(ConsoleColor textcolor = ConsoleColor.White)
        {
            try
            {
                List<string> fiveTopPlayers = GetHighScores();

                string[] currentScoreAndName;

                // PRINTS TOP 5 PLAYERS w. HIGH SCORES

                WriteAt(10, 0, "\n" + "                         HIGH SCORES:" + "\n");
                WriteAt(10, 3, "*========================================*");

                for (int index = 0; index < fiveTopPlayers.Count; index++)
                {
                    currentScoreAndName = fiveTopPlayers[index].Split(new char[] { '|' });

                    string scores = "";

                    if (currentScoreAndName[0] != "0000")
                    {
                        scores = currentScoreAndName[0].TrimStart('0');
                    }
                    else
                    {
                        scores = "0";
                    }

                    string lineString = String.Format("* Player {0}: {1}", currentScoreAndName[1], scores);
                    WriteAt(10, 4 + index, lineString, textcolor);
                    WriteAt(51, 4 + index, "*", textcolor);
                }

                if (fiveTopPlayers.Count < 5)
                {
                    int emptyRows = 5 - fiveTopPlayers.Count;
                    while (emptyRows != 0)
                    {
                        WriteAt(10, 4 + (5 - emptyRows), "*", textcolor);
                        WriteAt(51, 4 + (5 - emptyRows), "*", textcolor);
                        emptyRows--;
                    }
                }

                Console.WriteLine("\n" + "          *========================================*", textcolor);
            }
            catch (IOException IOError)
            {
                Console.WriteLine(IOError.Message);
            }
            catch (OutOfMemoryException memoryError)
            {
                Console.WriteLine(memoryError.Message);
            }
            catch (Exception another)
            {
                Console.WriteLine(another.Message);
            }
        }

        public static List<string> GetAllScores()
        {
            StreamReader reader = new StreamReader(FILEPATH);

            List<string> allScoresAndNames = new List<string>();

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    allScoresAndNames.Add(line);
                    line = reader.ReadLine();
                }
            }

            allScoresAndNames.Sort();
            allScoresAndNames.Reverse();

            return allScoresAndNames;
        }

        public static List<string> GetHighScores()
        {
            List<string> allScoresAndNames = GetAllScores();

            if (allScoresAndNames.Count > 5)
            {
                allScoresAndNames.RemoveRange(5, allScoresAndNames.Count - 5);
            }

            List<string> fiveTopPlayers = allScoresAndNames;

            return fiveTopPlayers;
        }

        public static void WriteScores()
        {
            string scores = currentScores.ToString("0000");
            string recordScores = scores + "|" + playerNameGameOver;

            StreamWriter writer = new StreamWriter(FILEPATH, true);
            using (writer)
            {
                writer.WriteLine(recordScores);
            }
        }
        public static void WriteAt(int col, int row, string stringToWrite, ConsoleColor colorText = ConsoleColor.White)
        {
            //try
            //{
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = colorText;
            Console.Write(stringToWrite);
            //}
            //catch (ArgumentOutOfRangeException outOfRange)
            //{
            //    Console.Error.WriteLine(outOfRange.Message);
            //}
            //catch (SecurityException security)
            //{
            //    Console.Error.WriteLine(security.Message);
            //}
            //catch (IOException IO)
            //{
            //    Console.Error.WriteLine(IO.Message);
            //}
            //catch (Exception unknown)
            //{
            //    Console.Error.WriteLine(unknown.Message);
            //}
        }
    }
}
