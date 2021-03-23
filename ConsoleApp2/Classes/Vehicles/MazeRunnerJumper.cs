using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSimulator
{
    public class MazeRunnerJumper : Vehicle, IMazeRunner
    {
        private Coordinates desiredMove;
        private const int ACCELERATION= 1;

        public MazeRunnerJumper()
        {
            
        }

        //The bike will try and move forward a distance equal to its speed. 
        public Coordinates DesiredMove()
        {
            desiredMove = this.Position();
            Random random = new Random();
            if (random.Next(400) % 4 == 0)
            {
                Crash();
                ChooseNewDirection();
            }
            switch (this.direction)
            {
                case Direction.North:
                    this.desiredMove.ChangeYPosition(this.speed+ ACCELERATION);
                    break;
                case Direction.South:
                    this.desiredMove.ChangeYPosition(-1 * (this.speed+ ACCELERATION));
                    break;
                case Direction.East:
                    this.desiredMove.ChangeXPosition(this.speed+ ACCELERATION);
                    break;
                case Direction.West:
                    this.desiredMove.ChangeXPosition(-1 * (this.speed+ ACCELERATION));
                    break;

                default:
                    throw new Exception("not implemented");
            }
            return this.desiredMove;
        }

  
        public void ChooseNewDirection()
        {
            TurnLeft();
        }

        //If the moves is not allowed then a new direction will be chosen. 
        public void MakeMoveIfAllowed(bool okToMove)
        {
            if (okToMove)
            {
                this.coordinates = desiredMove;
                this.movesMade += 1;
            }
            else
            {
                Crash();
                ChooseNewDirection();
            }
        }

        public void SetMovesToZero()
        {
            this.movesMade = 0;
        }
    }
}
