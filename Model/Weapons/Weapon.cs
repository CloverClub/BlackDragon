using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Weapon : IDrawable, IMoveable
    {
        #region Fields

        protected int addDamage;
        protected int range;
        private Position position;
        private WeaponDirectionEnum weaponDirection;
        private bool toBeRemoved;
        private int width;
        private int length;

        #endregion

        #region Properties

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
        public bool ToBeRemoved
        {
            get
            {
                return toBeRemoved;
            }
            set
            {
                toBeRemoved = value;
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

        #endregion

        public Weapon()
        {
            this.Length = 4;
        }

        public abstract void Draw();
        public abstract void Erase();

        public void Move(int fieldWidth, int fieldHeight)
        {
            bool isOnTopBorder = (this.Position.Top == PlayField.borderTop);
            bool isOnRightFieldBorder = (this.Position.Left == fieldWidth - 4 - PlayField.borderSides);
            bool isOnLeftFieldBorder = (this.Position.Left == PlayField.borderSides +1);
            bool isOnDownFieldBorder = (this.Position.Top > fieldHeight - 4 - PlayField.borderBottom );

            if (isOnTopBorder || isOnRightFieldBorder || isOnLeftFieldBorder || isOnDownFieldBorder)
            {
                this.ToBeRemoved = true;
                this.Erase();
                return;
            }

            switch (this.WeaponDirection)
            {
                case WeaponDirectionEnum.up:
                    MoveUp();
                    break;
                case WeaponDirectionEnum.down:
                    MoveDown();
                    break;
                case WeaponDirectionEnum.left:
                    MoveLeft();
                    break;
                case WeaponDirectionEnum.right:
                    MoveRight();
                    break;
            }
        }

        private void MoveUp()
        {
            this.Erase();
            this.Position.Top--;
            this.Draw();
        }

        private void MoveDown()
        {
                this.Erase();
                this.Position.Top++;
                this.Draw();
        }

        private void MoveLeft()
        {
            this.Erase();
            this.Position.Left--;
            this.Draw();
        }

        private void MoveRight()
        {
            this.Erase();
            this.Position.Left++;
            this.Draw();
        }
    }
}
