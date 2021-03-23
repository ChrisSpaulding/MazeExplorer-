using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSimulator
{
    public interface IMazeRunner
    {
        Coordinates DesiredMove();
        int MovesMade();
        void MakeMoveIfAllowed(bool okToMove);
        void SetMovesToZero();
        Coordinates Position();
    }
}
