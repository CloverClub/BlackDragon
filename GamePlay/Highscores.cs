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
    }
}
