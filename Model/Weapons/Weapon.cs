using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Weapon : IDrawable, IMovable
    {
        protected int addDamage;
        protected int range;
        private Position position;
        private WeaponDirectionEnum weaponDirection;

        public int Damage { get; private set; }

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

        public WeaponDirectionEnum WeaponDirection
        {
            get 
            { 
                return weaponDirection; 
            }
            set 
            { 
                weaponDirection = value; 
            }
        }

        public abstract void Draw();
        public abstract void Erase();

        public abstract void Move();
    }
}
