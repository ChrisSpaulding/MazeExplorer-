using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSimulator
{
    public interface IMaze
    {
        bool IsMoveValid(Coordinates attemptedMove);
        bool IsPositionWinningSpace(Coordinates coordinates);


    }
}
