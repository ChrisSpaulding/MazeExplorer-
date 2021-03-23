using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeSimulator;

namespace unitTesting
{
    [TestClass]
    public class MazeTest
    {
       
        #region TestMaze

        [TestMethod]
        public void TestWinningSpace()
        {
            MazeRunnerJumper jumper = new MazeRunnerJumper();
            Coordinates coordinates = new Coordinates(0,0,0);
            SquareMaze maze = new SquareMaze(coordinates, 0, 0);
            maze.IsPositionWinningSpace(coordinates);
        }

        [TestMethod]
        public void TestWinningSpaceFromBike()
        {
            MazeRunnerJumper jumper = new MazeRunnerJumper();
            Coordinates coordinates = new Coordinates(0, 0, 0);
            SquareMaze maze = new SquareMaze(coordinates, 0, 0);
            Assert.IsTrue(maze.IsPositionWinningSpace(jumper.Position()));
        }

        [TestMethod]
        public void TestIsValidMoveValid()
        {
            MazeRunnerJumper jumper = new MazeRunnerJumper();
            Coordinates coordinates = new Coordinates(0, 0, 0);
            SquareMaze maze = new SquareMaze(coordinates, 0, 0);
            Assert.IsTrue(maze.IsMoveValid(coordinates));
        }

        [TestMethod]
        public void TestIsValidMoveInvalidX()
        {
            Coordinates coordinates = new Coordinates(0, 0, 0);
            SquareMaze maze = new SquareMaze(coordinates, 0, 0);
            Coordinates outOfBounds = new Coordinates(1, 0, 0);
            Assert.IsFalse(maze.IsMoveValid(outOfBounds));
        }
        [TestMethod]
        public void TestIsValidMoveInvalidY()
        {
            Coordinates coordinates = new Coordinates(0, 0, 0);
            SquareMaze maze = new SquareMaze(coordinates, 0, 0);
            Coordinates outOfBounds = new Coordinates(0, 1, 0);
            Assert.IsFalse(maze.IsMoveValid(outOfBounds));
        }
        [TestMethod]
        public void TestIsValidMoveInvalidZ()
        {
            Coordinates coordinates = new Coordinates(0, 0, 0);
            SquareMaze maze = new SquareMaze(coordinates, 0, 0);
            Coordinates outOfBounds = new Coordinates(0, 0, 1);
            Assert.IsFalse(maze.IsMoveValid(outOfBounds));
        }
        [TestMethod]
        public void TestIsValidMoveInvalidXY()
        {
            Coordinates coordinates = new Coordinates(0, 0, 0);
            SquareMaze maze = new SquareMaze(coordinates, 0, 0);
            Coordinates outOfBounds = new Coordinates(1, 1, 0);
            Assert.IsFalse(maze.IsMoveValid(outOfBounds));
        }

        #endregion
        #region FileMaze
        #region Constants
        const string basicTestFile = @"C:\\Users\\Spauldch\\source\\repos\\ConsoleApp2\\Testfiles.txt";
        #endregion
    

        [TestMethod]
        public void TestFileImport()
        {
            Coordinates coordinates = new Coordinates(0, 0, 0);
            FileMaze maze = new FileMaze();
            maze.ImportMapText(basicTestFile);
            Assert.IsTrue(true);
        }
        #endregion
    }

}


