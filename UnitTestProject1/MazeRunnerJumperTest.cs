using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeSimulator;

namespace unitTesting
{
    [TestClass]
    public class MazeRunnerJumperTest
    {
    #region MazeRunnerBike
        [TestMethod]
        public void TestDesiredMove()
        {
            MazeRunnerJumper bike = new MazeRunnerJumper();
            Coordinates coordinates = new Coordinates();
            Assert.AreEqual(coordinates, bike.Position());
            Assert.AreNotEqual(coordinates, bike.DesiredMove());
        }

        [TestMethod]
        public void TestChooseNewDirection()
        {
            MazeRunnerJumper bike = new MazeRunnerJumper();
            //looping through to make sure that it will always choose a new direction
            for (int i = 0; i < 20; i++)
            {
                Direction originalDirection = bike.GetDirection();
                bike.ChooseNewDirection();
                Assert.AreNotEqual(originalDirection, bike.GetDirection());
            }
        }

        [TestMethod]
        public void TestMakeMoveIfAllowedTrue()
        {
            MazeRunnerJumper bike = new MazeRunnerJumper();
            Assert.AreEqual(0, bike.MovesMade());
            bike.MakeMoveIfAllowed(true);
            Assert.AreEqual(1, bike.MovesMade());
        }

        [TestMethod]
        public void TestMakeMoveIfAllowedFalse()
        {
            MazeRunnerJumper bike = new MazeRunnerJumper();
            Assert.AreEqual(0, bike.MovesMade());
            Direction originalDirection = bike.GetDirection();
            bike.MakeMoveIfAllowed(false);
            Assert.AreEqual(0, bike.MovesMade());
            Assert.AreNotEqual(originalDirection, bike.GetDirection());            
        }

        #endregion       
    }
}

