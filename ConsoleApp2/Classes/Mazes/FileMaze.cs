using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSimulator
{
    public class FileMaze : IMaze
    {
        MazeNode [,] map;
        string[] textLines;
        int YOffset = 0;
        int XOffset = 0;
        Coordinates WinningSpace; 
        public FileMaze()
        {

        }
        public void ImportMapText(string fileName)
        {
         
         
            textLines = System.IO.File.ReadAllLines(fileName);
         
            AddTextLinesToMap();
        }

        //When looking at a page 0,0 is naturally the top left. So the Y coordinate must be negative as the actual index increases. 
        //The offset is positive because the value will be subtracted from the coordinate suggested to account for the S being 0,0 for the map
        //example "real" starting coordinate of 5, -8 gets transalted to 0,0 by adding the coordninate -5, + 8 
        private void AddTextLinesToMap()
        {
            map = new MazeNode[textLines[0].Length, textLines.Count()];
            // Y (rows) then X (columns) 
            for (int rows=0; rows < textLines.Count(); rows++)
            {
                for (int columns=0; columns < textLines[rows].Length; columns++)
                {
                    char symbol = textLines[rows].ElementAt(columns);
                    if (symbol == ' '){
                        map[rows, columns] = new MazeNode(new Coordinates(columns, -rows), true);
                    }
                    else if(symbol == 'S')
                    {
                        map[rows, columns] = new MazeNode(new Coordinates(columns, -rows), true);
                        YOffset = rows;
                        XOffset = -columns;
                    }
                    else if(symbol == 'G')
                    {
                        map[rows, columns] = new MazeNode(new Coordinates(columns, -rows), true);
                        WinningSpace = new Coordinates(columns, -rows);
                    }
                    else
                    {
                        map[rows, columns] = new MazeNode(new Coordinates(columns, -rows), false);
                    }
                }
            }
        }
        public bool IsMoveValid(Coordinates attemptedMove)
        {
            throw new NotImplementedException();
        }

        public bool IsPositionWinningSpace(Coordinates coordinates)
        {
            throw new NotImplementedException();
        }
    }
}
