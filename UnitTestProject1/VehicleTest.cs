using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeSimulator;

namespace unitTesting
{
    [TestClass]
    public class VehicleTest
    {
        #region testVehicle
        [TestMethod]
        public void TestTurnLeft()
        {
            Vehicle vehicle = new Vehicle();

            Assert.AreEqual(Direction.North, vehicle.GetDirection());
            vehicle.TurnLeft();
            Assert.AreEqual(Direction.West, vehicle.GetDirection());
            vehicle.TurnLeft();
            Assert.AreEqual(Direction.South, vehicle.GetDirection());
            vehicle.TurnLeft();
            Assert.AreEqual(Direction.East, vehicle.GetDirection());
            vehicle.TurnLeft();
            Assert.AreEqual(Direction.North, vehicle.GetDirection());
        }

        [TestMethod]
        public void TestTurnRight()
        {
            Vehicle vehicle = new Vehicle();

            Assert.AreEqual(Direction.North, vehicle.GetDirection());
            vehicle.TurnRight();
            Assert.AreEqual(Direction.East, vehicle.GetDirection());
            vehicle.TurnRight();
            Assert.AreEqual(Direction.South, vehicle.GetDirection());
            vehicle.TurnRight();
            Assert.AreEqual(Direction.West, vehicle.GetDirection());
            vehicle.TurnRight();
            Assert.AreEqual(Direction.North, vehicle.GetDirection());
        }

        [TestMethod]
        public void TestMoveForwardNorth()
        {
            Vehicle vehicle = new Vehicle();
            Assert.AreEqual(Direction.North, vehicle.GetDirection());
            Coordinates expectedCoordinates = new Coordinates(0, 1, 0);
            vehicle.Accelerate(1);
            vehicle.MoveForward();
            Assert.AreEqual(expectedCoordinates, vehicle.Position());
        }

        [TestMethod]
        public void TestMoveForwardSouth()
        {
            Vehicle vehicle = new Vehicle();
            Assert.AreEqual(Direction.North, vehicle.GetDirection());
            vehicle.TurnLeft();
            vehicle.TurnLeft();
            Assert.AreEqual(Direction.South, vehicle.GetDirection());
            Coordinates expectedCoordinates = new Coordinates(0, -1, 0);
            vehicle.Accelerate(1);
            vehicle.MoveForward();
            Assert.AreEqual(expectedCoordinates, vehicle.Position());
        }

        [TestMethod]
        public void TestMoveForwardEast()
        {
            Vehicle vehicle = new Vehicle();
            Assert.AreEqual(Direction.North, vehicle.GetDirection());
            vehicle.TurnRight();
            Assert.AreEqual(Direction.East, vehicle.GetDirection());
            Coordinates expectedCoordinates = new Coordinates(1, 0, 0);
            vehicle.Accelerate(1);
            vehicle.MoveForward();
            Assert.AreEqual(expectedCoordinates, vehicle.Position());
        }
        [TestMethod]
        public void TestMoveForwardWest()
        {
            Vehicle vehicle = new Vehicle();
            Assert.AreEqual(Direction.North, vehicle.GetDirection());
            vehicle.TurnLeft();
            Assert.AreEqual(Direction.West, vehicle.GetDirection());
            Coordinates expectedCoordinates = new Coordinates(-1, 0, 0);
            vehicle.Accelerate(1);
            vehicle.MoveForward();
            Assert.AreEqual(expectedCoordinates, vehicle.Position());
        }

        #endregion
        
     }
}

