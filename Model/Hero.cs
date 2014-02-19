using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hero : Character
    {
        private int level;
        private Weapon weapon;
        private int highScore;

        public int Level 
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }
        public Weapon Weapon 
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }
        public int HighScore
        {
            get
            {
                return highScore;
            }
            set
            {
                highScore = value;
            }
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void LoseHealthPoints()
        {
            throw new NotImplementedException();
        }

        public override void DrawImage()
        {
            throw new NotImplementedException();
        }

        public override void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public override void MoveRight()
        {
            throw new NotImplementedException();
        }
    }
}
