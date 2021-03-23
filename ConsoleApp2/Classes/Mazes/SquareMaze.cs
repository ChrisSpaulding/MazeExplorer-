using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSimulator

{
    public class SquareMaze : IMaze
    {
        Coordinates WinningSpace;
        int XSize;
        int YSize;
        int Zsize = 0;

        public SquareMaze()
        {
            Random random = new Random();
            WinningSpace = new Coordinates(random.Next(-10, 11), random.Next(-10, 11), 0);
            XSize = 10;
            YSize = 10;
        }
        public SquareMaze(Coordinates winningSpace)
        {
            this.WinningSpace = winningSpace;
            XSize = 10;
            YSize = 10;
        }
        public SquareMaze(Coordinates winningSpace, int xSize, int ySize)
        {
            this.WinningSpace = winningSpace;
            this.XSize = xSize;
            this.YSize = ySize;
        }
        public bool IsMoveValid(Coordinates attemptedMove)
        {
            return (
                xCoordinateValid(attemptedMove.X)
                && yCoordinateValid(attemptedMove.Y)
                && zCoordinateValid(attemptedMove.Z));
        }

        public bool IsPositionWinningSpace(Coordinates coordinates)
        {
            return (WinningSpace.Equals(coordinates));
        }
        
        private bool xCoordinateValid(int x)
        {
            return (x <= XSize && x >= -1*XSize);
        }
        private bool yCoordinateValid(int y)
        {
            return (y <= YSize && y >= -1*YSize);
        }
        private bool zCoordinateValid(int z)
        {
            return (z <= Zsize && z >= -1*Zsize);
        }
    }
}
