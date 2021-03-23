namespace MazeSimulator
{
    class MazeNode
    {
        public MazeNode(Coordinates coordinates = null, bool openSpace = false)
        {
            this.Coordinates = coordinates;
            this.OpenSpace = openSpace;
        }
        public Coordinates Coordinates;
        public bool OpenSpace;
    }
}