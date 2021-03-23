using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MazeSimulator
{
    public class MazeRunnerExplorer : Vehicle, IMazeRunner
    {
        const int ACCELERATION = 1;

        // Implemenation Documentation: Because maps must be rectangles (business rule for now) 
        // When a new position is explored the map boundaries need to be expanded. 
        private List<List<MapNodes>> Map;
        private Coordinates PositionToBeScouted {
            get => DesiredMove();
        }
        private int NumberOfMovesMade = 0;

        public MazeRunnerExplorer()
        {
            this.Map = new List<List<MapNodes>>();
            //starting node must always be explored and part of the map
            MapNodes startingNode = new MapNodes(new Coordinates(0, 0), true, true);
            Map.Add(new List<MapNodes>());
            Map[0].Add(startingNode);
        }
        public Coordinates DesiredMove()
        {
            if (this.speed == 0)
            {
                this.Accelerate(ACCELERATION);
            }
           
            Coordinates tempPotentialPosition = this.Position();
            switch (this.direction)
            {
                case Direction.North:
                    tempPotentialPosition.ChangeYPosition(this.speed);
                    break;
                case Direction.South:
                    tempPotentialPosition.ChangeYPosition(-1 * this.speed);
                    break;
                case Direction.East:
                    tempPotentialPosition.ChangeXPosition(this.speed);
                    break;
                case Direction.West:
                    tempPotentialPosition.ChangeXPosition(-1 * this.speed);
                    break;
                default:
                    throw new Exception("not implemented");
            }
            return tempPotentialPosition;
        }

        public void MakeMoveIfAllowed(bool okToMove)
        {
            if (okToMove)
            {
                this.MoveForward();
            }
        }


        private void MapPotentialNode(Coordinates node)
        {

        }

        public bool WestOfPotentialTeritory(Coordinates node)
        {
            int westMostNodePostion = this.Map[0][0].coordinates.X;
            return node.X < westMostNodePostion ;
        }
        public bool EastOfPotentialTeritory(Coordinates node)
        {
            int eastMostNodePostion = this.Map[Map[0].Count-1][0].coordinates.X;
            return  node.X > eastMostNodePostion;
        }
        public bool SouthOfPotentialTeritory(Coordinates node)
        {
            int southMostNodePostion = this.Map[0][0].coordinates.Y;
            return node.Y < southMostNodePostion;
        }
        public bool NorthOfPotentialTeritory(Coordinates node)
        {
            int northMostNodePosition = this.Map[0][0].coordinates.Y;
            return node.Y > northMostNodePosition;
        }

        public void SetMovesToZero()
        {
            this.NumberOfMovesMade = 0;
        }

        class MapNodes
        {

            public MapNodes(Coordinates coordinates = null, bool explored = false, bool openSpace = false)
            {
                this.coordinates = coordinates;
                this.explored = explored;
                this.partOfMaze = openSpace;
                
            }
            public Coordinates coordinates;
            public bool partOfMaze;
            public bool explored;
        }
    }
}
