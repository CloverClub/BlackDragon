using System;
using System.Text;
using System.Threading;

namespace Model
{
    public class Enemy : Character
    {
       
        public override string DrawImage()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            // TO DO: implement logic of the ricochet to the borders
            this.MoveLowerRight();
        }

        public void MoveLowerRight()
        {
            this.Erase();
            this.Position.Left++;
            this.Position.Top++;
            this.Draw();
        }

        public void MoveLowerLeft()
        {
            this.Erase();
            this.Position.Left++;
            this.Position.Top++;
            this.Draw();
        }

        public void MoveUpperRight()
        {
            this.Erase();
            this.Position.Left++;
            this.Position.Top--;
            this.Draw();
            
        }

        public void MoveUpperLeft()
        {
            this.Erase();
            this.Position.Left--;
            this.Position.Top++;
            this.Draw();
        }
    }
}
