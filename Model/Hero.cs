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
        private int experiece;

        public int Experience
        {
            get
            {
                return this.experiece;
            }
         private  set
            {
             int newExperience = this.experiece+value;
                if (newExperience>=100)
                {
                    this.Experience = newExperience % 100;
                    this.Level++;
                }
                this.experiece += value;
            }
        }
        public int Level 
        {
            get
            {
                return level;
            }
          private  set
            {
                level += value;
            }
        }
        public Weapon Weapon 
        {
            get
            {
                return weapon;
            }
          private  set
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

        public override bool Attack(Character target)
        {
            bool attackResult = base.Attack(target);
            if (attackResult)
            {
                this.Experience += 10;
            }
            return attackResult;                     
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
