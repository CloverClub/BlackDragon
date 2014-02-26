using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PlayField
    {
        private int width;
        private int height;
        public static int borderTop = 3;
        public static int borderBottom = 3;
        public static int borderSides = 4;
        
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public PlayField(int height, int width)
        {
            this.Height = height;
            this.Width = width;
            Console.WindowHeight = height;
            Console.WindowWidth = width;
            DrawBorders();
        }

        public void DrawBorders()
        {
            //Vertical borders
            for (int i = 1; i < this.Height - 1; i++)
            {
                if (i == 1)
                {
                    WriteAt("╔", 0, 0);
                    WriteAt("╔", 3, 2);
                    WriteAt("╗", this.Width - 1, 0);
                    WriteAt("╗", this.Width - 4, 2);
                    WriteAt("╚", 0, this.Height - 1);
                    WriteAt("╝", this.Width - 1, this.Height - 1);
                }
                if (i <= 2)
                {
                    WriteAt("║", 0, i);
                    WriteAt("║", this.Width - 1, i);
                }
                if (i > 2 && i < this.Height - 3)
                {
                    WriteAt("║_-║", 0, i);
                    WriteAt("║_-║", this.Width - 4, i);
                }
                if (i >= this.Height - 3)
                {
                    WriteAt("║", 0, i);
                    WriteAt("║", this.Width - 1, i);
                }
            }

            //Horizontal borders
            for (int i = 1; i < this.Width; i++)
            {
                if (i > 0 && i < this.Width - 1)
                {
                    WriteAt("═", i, 0);
                    WriteAt("═", i, this.Height - 3);
                    WriteAt("═", i, this.Height - 1);
                }
                if (i > 3 && i < this.Width - 4)
                {
                    WriteAt("═", i, 2);
                }
            }
        }

        private void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(0 + x, 0 + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

    }
}
