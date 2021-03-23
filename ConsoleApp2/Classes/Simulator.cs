namespace MazeSimulator
{
    public class Simulator
    {
        public Simulator()
        {

        }
        public int MazeTrial(IMaze maze, IMazeRunner runner,int maxTurns = int.MaxValue)
        {
            runner.SetMovesToZero();
            bool runnerIsRunning = true;

            while (runnerIsRunning)
            {
                runner.MakeMoveIfAllowed(maze.IsMoveValid(runner.DesiredMove()));
                runnerIsRunning = !maze.IsPositionWinningSpace(runner.Position());
                if (runner.MovesMade() >= maxTurns)
                {
                    break;
                }
            }
            return runner.MovesMade();
        }

    }
}
