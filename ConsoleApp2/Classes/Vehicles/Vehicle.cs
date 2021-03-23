using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSimulator
{
    public class  Vehicle 
    {
        protected int movesMade;
        protected Coordinates coordinates;
        protected Direction direction;
        protected int speed;
        protected void Crash()
        {
            speed = 0;
        }

        public Vehicle()
        {
            coordinates = new Coordinates();
            direction = Direction.North;
            speed = 0;
        }
        public int Accelerate(int speedChange)
        {
            this.speed = speed + speedChange;
            return speed;
        }

        public Direction GetDirection()
        {
            return direction;
        }
        

        public void MoveForward()
        {
            switch (this.direction)
            {
                case Direction.North:
                    this.coordinates.ChangeYPosition(this.speed);
                    break;
                case Direction.South:
                    this.coordinates.ChangeYPosition(-1 * this.speed);
                    break;
                case Direction.East:
                    this.coordinates.ChangeXPosition(this.speed);
                    break;
                case Direction.West:
                    this.coordinates.ChangeXPosition(-1 * this.speed);
                    break;

                default:
                    throw new Exception("not implemented");
            }
        }

        public Coordinates Position()
        {
            return new Coordinates(coordinates.X,coordinates.Y, coordinates.Z);
        }

        public void TurnLeft()
        {
            if (direction == Direction.North)
            {
                this.direction = Direction.West;
            }
            else
            {
                this.direction -= 1;
            }
            
        }

        public void TurnRight()
        {
            if (direction == Direction.West)
            {
                direction = Direction.North;
            }
            else
            {
                this.direction += 1;
            }
        }
        public int MovesMade()
        {
            return movesMade;
        }
    }
}
