using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlay
{
    public class Menu
    {
        private StringBuilder title;
        private StringBuilder options;
        private StringBuilder invalidMessage;
        
        public void DisplayTitle()
        {
            Console.WriteLine(BuildStringTitle());
        }

        public void DisplayOptions()
        {
            Console.SetCursorPosition((Console.WindowWidth / 2), 5);
            Console.WriteLine("Choose your character: ");
            Console.SetCursorPosition((Console.WindowWidth / 2), 7);
            Console.WriteLine("1. Archer");
            Console.SetCursorPosition((Console.WindowWidth / 2), 8);
            Console.WriteLine("2. Barbarian");
            Console.SetCursorPosition((Console.WindowWidth / 2), 9);
            Console.WriteLine("3. Sorcerer");
            Console.SetCursorPosition((Console.WindowWidth / 2), 10);
            Console.WriteLine("4. Spearman");
            Console.SetCursorPosition((Console.WindowWidth / 2), 11);
            Console.WriteLine("5. Dwarf");
            Console.SetCursorPosition((Console.WindowWidth / 2), 12);
        }

        public void DisplayInvalidMessage()
        {
            Console.WriteLine(BuildInvalidMessage());
        }

        private string BuildStringTitle()
        {
            title = new StringBuilder();
            title.Append("Black Dragon \n");

            return title.ToString();
        }

        public string BuildInvalidMessage()
        {
            invalidMessage = new StringBuilder();
            invalidMessage.Append("Invalid input. Enter a number between 1 and 5");
            return invalidMessage.ToString();
        }

        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
