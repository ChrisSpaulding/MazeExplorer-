using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeSimulator;

namespace unitTesting
{
    [TestClass]
    public class MazeRunnerExplorerTest
    {

        #region BoundTests
        [TestMethod]
        public void TestNorthBound()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates NEcoordinates = new Coordinates(0, 1, 0);
            Assert.IsTrue(explorer.NorthOfPotentialTeritory(NEcoordinates));

        }

        [TestMethod]
        public void TestSouthBound()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates SEcoordinates = new Coordinates(0, -1);
            Assert.IsTrue(explorer.SouthOfPotentialTeritory(SEcoordinates));

        }

        [TestMethod]
        public void TestEastBound()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates SEcoordinates = new Coordinates(1, 0);
            Assert.IsTrue(explorer.EastOfPotentialTeritory(SEcoordinates));

        }
        [TestMethod]
        public void TestWestBound()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates SWcoordinates = new Coordinates(-1, 0);
            Assert.IsTrue(explorer.WestOfPotentialTeritory(SWcoordinates));

        }
        [TestMethod]
        public void TestNorthBoundExtra()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates NEcoordinates = new Coordinates(-2, 99);
            Assert.IsTrue(explorer.NorthOfPotentialTeritory(NEcoordinates));

        }

        [TestMethod]
        public void TestSouthBoundExtra()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates SEcoordinates = new Coordinates(85, -85);
            Assert.IsTrue(explorer.SouthOfPotentialTeritory(SEcoordinates));

        }

        [TestMethod]
        public void TestEastBoundExtra()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates SEcoordinates = new Coordinates(99, -50);
            Assert.IsTrue(explorer.EastOfPotentialTeritory(SEcoordinates));

        }
        [TestMethod]
        public void TestWestBoundExtra()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates SWcoordinates = new Coordinates(-100, 10);
            Assert.IsTrue(explorer.WestOfPotentialTeritory(SWcoordinates));

        }

        [TestMethod]
        public void TestNorthBoundFalse()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates NEcoordinates = new Coordinates(0, -1, 0);
            Assert.IsFalse(explorer.NorthOfPotentialTeritory(NEcoordinates));

        }

        [TestMethod]
        public void TestSouthBoundFalse()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates SEcoordinates = new Coordinates(0, 1);
            Assert.IsFalse(explorer.SouthOfPotentialTeritory(SEcoordinates));

        }

        [TestMethod]
        public void TestEastBoundFalse()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates SEcoordinates = new Coordinates(0, 0);
            Assert.IsFalse(explorer.EastOfPotentialTeritory(SEcoordinates));

        }

        [TestMethod]
        public void TestWestBoundFalse()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates SWcoordinates = new Coordinates(100, 10);
            Assert.IsFalse(explorer.WestOfPotentialTeritory(SWcoordinates));

        }
        #endregion

        #region Movement

        #region DesiredMove
        [TestMethod]
        public void TestDesiredMoveReturnsPosition()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates desiredMove =  explorer.DesiredMove();
            Assert.AreNotEqual<Coordinates>(desiredMove,explorer.Position());
        }
       
        [TestMethod]
        public void TestDesiredMoveReturnsSamePositionEveryTime()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates desiredMoveA = explorer.DesiredMove();
            for(int i=0; i < 100; i++)
            {
                Assert.AreEqual<Coordinates>(desiredMoveA, explorer.DesiredMove());
            }
        }

        #endregion

        #region MakeMove

        [TestMethod]
        public void TestMoveAllowedMovesToDifferentCoordinate()
        {
            MazeRunnerExplorer explorer = new MazeRunnerExplorer();
            Coordinates startingCoordinates = explorer.Position();
            explorer.MakeMoveIfAllowed(true);
            Assert.AreNotEqual<Coordinates>(startingCoordinates, explorer.Position());
        }
        #endregion

        #endregion
    }
}

