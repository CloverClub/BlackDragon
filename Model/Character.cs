using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Character
    {
        protected int healthPoints;
        protected int damagePoints;
        protected Image image;

        public abstract void Attack();
        public abstract void LoseHealthPoints();

        public abstract void DrawImage();
        public abstract void MoveLeft();
        public abstract void MoveRight();
    }
}
