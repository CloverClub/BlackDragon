using System;
using System.Text;
using System.Threading;

namespace Model
{
    public class Enemy : Character
    {
        private EnemyMoveDirection moveDirection;

        public EnemyMoveDirection MoveDirection
        {
            get { return moveDirection; }
            set { moveDirection = value; }
        }

        public Enemy()
        {
            
            Array values = Enum.GetValues(typeof(EnemyMoveDirection));
            Random random = new Random();
            EnemyMoveDirection randomDirection = (EnemyMoveDirection)values.GetValue(random.Next(values.Length));
            this.moveDirection = randomDirection;
            
            //this.moveDirection = EnemyMoveDirection.downRight;
        }

        public override void Move(int fieldWidth, int fieldHeight)
        {           
            bool isOnTopBorder = (this.Position.Top == PlayField.borderTop);
            bool isOnRightFieldBorder = (this.Position.Left == fieldWidth - 1 - this.Width - PlayField.borderSides);
            bool isOnLeftFieldBorder = (this.Position.Left == PlayField.borderSides);
            bool isOnDownFieldBorder = (this.Position.Top == fieldHeight - 1 - this.Length - PlayField.borderBottom);

            // change the direction if the enemy position is on the field border
            if (this.MoveDirection == EnemyMoveDirection.downRight)
            {
                if (isOnRightFieldBorder)
                {
                    this.MoveDirection = EnemyMoveDirection.downLeft;
                }
                else if (isOnDownFieldBorder)
                {
                    this.MoveDirection = EnemyMoveDirection.upRight;
                }
            }
            else if (this.MoveDirection == EnemyMoveDirection.downLeft)
            {
                if (isOnLeftFieldBorder)
                {
                    this.MoveDirection = EnemyMoveDirection.downRight;
                }
                else if (isOnDownFieldBorder)
                {
                    this.MoveDirection = EnemyMoveDirection.upLeft;
                }
            }
            else if (this.MoveDirection == EnemyMoveDirection.upRight)
            {
                if (isOnRightFieldBorder)
                {
                    this.MoveDirection = EnemyMoveDirection.upLeft;
                }
                else if (isOnTopBorder)
                {
                    this.moveDirection = EnemyMoveDirection.downRight;
                }
            }
            else if (this.MoveDirection == EnemyMoveDirection.upLeft)
            {
                if (isOnLeftFieldBorder)
                {
                    this.MoveDirection = EnemyMoveDirection.upRight;
                }
                else if (isOnTopBorder)
                {
                    this.MoveDirection = EnemyMoveDirection.downLeft;
                }
            }

            // move enemy 
            if (this.MoveDirection == EnemyMoveDirection.downRight)
            {
                this.MoveDownRight();
            }
            else if (this.MoveDirection == EnemyMoveDirection.downLeft)
            {
                this.MoveDownLeft();
            }
            else if (this.MoveDirection == EnemyMoveDirection.upRight)
            {
                this.MoveUpRight();
            }
            else if (this.MoveDirection == EnemyMoveDirection.upLeft)
            {
                this.MoveUpLeft();
            }

        }

        public void MoveDownRight()
        {
            this.Erase();
            this.Position.Left++;
            this.Position.Top++;
            this.Draw();
        }

        public void MoveDownLeft()
        {
            this.Erase();
            this.Position.Left--;
            this.Position.Top++;
            this.Draw();
        }

        public void MoveUpRight()
        {
            this.Erase();
            this.Position.Left++;
            this.Position.Top--;
            this.Draw();
            
        }

        public void MoveUpLeft()
        {
            this.Erase();
            this.Position.Left--;
            this.Position.Top--;
            this.Draw();
        }
    }
}
