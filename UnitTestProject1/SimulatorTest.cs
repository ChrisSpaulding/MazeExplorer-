using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeSimulator;

namespace unitTesting
{
    [TestClass]
    public class SimulatorTest
    {

        [TestMethod]
        public void TestOneSquaremaze()
        {
            MazeRunnerJumper jumper = new MazeRunnerJumper();
            Coordinates coordinates = new Coordinates(0, 0, 0);
            SquareMaze maze = new SquareMaze(coordinates, 0, 0);
            Simulator simulator = new Simulator();

            Assert.AreEqual(0, simulator.MazeTrial(maze, jumper));
        }
        [TestMethod]
        public void TestTenSquaremaze()
        {
            MazeRunnerJumper jumper = new MazeRunnerJumper();
            Coordinates coordinates = new Coordinates(8, 9, 0);
            SquareMaze maze = new SquareMaze(coordinates, 10, 10);
            Simulator simulator = new Simulator();
            int results = simulator.MazeTrial(maze, jumper);
            Assert.AreNotEqual(0 , results);
        }
    }
}

