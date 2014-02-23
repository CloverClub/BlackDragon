using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class PlayField
    {
        private int width;
        private int height;
        
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
        }
    }
}
