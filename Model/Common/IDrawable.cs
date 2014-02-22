using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    interface IDrawable
    {
        void Draw(int x, int y);
        string DrawImage();
    }
}
