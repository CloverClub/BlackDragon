using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Position
    {
        private int left;
        private int top;

        public int Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
    }
}
