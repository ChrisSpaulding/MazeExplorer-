using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSimulator
{
    public class Coordinates
    {
        public int X;
        public int Y { get; set; }
        public int Z { get; set; }

        public Coordinates()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Coordinates(int x, int y, int z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        public void ChangeXPosition(int xChange)
        {
            this.X += xChange;
        }
        public void ChangeYPosition(int yChange)
        {
            this.Y += yChange;
        }
        public void ChagneZPosition(int zChange)
        {
            this.Z += zChange;
        }

        public override bool Equals(Object obj)
        {
            if (obj.GetType().Equals(this.GetType()))
            {
                return this.X.Equals((obj as Coordinates).X)
                        && this.Y.Equals((obj as Coordinates).Y)
                        && this.Z.Equals((obj as Coordinates).Z);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = 373119288;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            hashCode = hashCode * -1521134295 + Z.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return String.Format("X:{0} Y:{1} Z:{2}",X,Y,Z);
        
        }
    }
}
