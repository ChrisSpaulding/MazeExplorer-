using System;

namespace MazeSimulator
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            MazeRunnerJumper bike = new MazeRunnerJumper();
            SquareMaze maze = new SquareMaze(new Coordinates(1,1,0),1,1);
            Simulator simulator = new Simulator();
            int turns = simulator.MazeTrial(maze, bike, 50);
            Console.WriteLine("Number of turns taken: " + turns);
         
        }
    }  
}
