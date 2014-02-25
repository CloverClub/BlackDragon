using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Character : IDrawable, IMovable
    {
        protected int healthPoints;
        protected int damagePoints;
        protected Image image;
        public bool IsDead { get; private set; }
        private Position position;
        private int width;
        private int length;
        
        public Position Position
        {
            get
            {
                if (position == null)
                    position = new Model.Position();
                return position;
            }
            set
            {
                position = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public virtual bool Attack(Character target)
        {
          return  target.Collision(this);  
           
        }
        private void LoseHealthPoints(int damage) 
        {
            int hitPointsAfterDamage = this.healthPoints-damage;
            if (hitPointsAfterDamage<=0)
            {
                this.IsDead = true;
            }
        }
        public bool Collision(Character attacker)
        {
            if (this is Enemy && attacker is Enemy)
            {
                return false; 
            }
            int attack = attacker.damagePoints;
            if (attacker is Hero)
            {
                attack += (attacker as Hero).Weapon.Damage;
            }
            LoseHealthPoints(attack);
            return this.IsDead;

        }

        public virtual void Draw()
        {
           
        }
        public virtual void Erase()
        {
        }
        
        public void Move()
        {
        }
    }
}
