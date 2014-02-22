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
            Console.WriteLine(BuildStringOptions());
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

        private string BuildStringOptions()
        {
            options = new StringBuilder();
            options.Append("Choose your character: ");
            options.AppendLine();
            options.Append("1. Archer\n");
            options.Append("2. Barbarian\n");
            options.Append("3. Sorcerer\n");
            options.Append("4. Spearman\n");
            options.Append("5. Dwarf");

            return options.ToString();
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
